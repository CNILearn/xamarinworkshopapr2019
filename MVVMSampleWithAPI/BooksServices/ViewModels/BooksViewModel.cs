using BooksServices.Events;
using BooksServices.Models;
using BooksServices.Services;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace BooksServices.ViewModels
{
    public class BooksViewModel : BindableBase
    {
        private readonly IBooksService _booksService;
        private readonly ObservableCollection<Book> _books = new ObservableCollection<Book>();
        private readonly IShowMessageService _messageService;
        private readonly IEventAggregator _eventAggregator;

        private bool _booksLoaded = false;

        public BooksViewModel(IBooksService booksService,
            IEventAggregator eventAggregator,
            IShowMessageService messageService)
        {
            _booksService = booksService ?? throw new ArgumentNullException(nameof(booksService));
            _eventAggregator = eventAggregator ?? throw new ArgumentNullException(nameof(eventAggregator));
            _messageService = messageService ?? throw new ArgumentNullException(nameof(messageService));

            RefreshCommand = new DelegateCommand(LoadBooks);
            AddBookCommand = new DelegateCommand(AddBook, CanAddBook);
            ShowMessageCommand = new DelegateCommand(ShowMessage);
        }

        public DelegateCommand RefreshCommand { get; }
        public DelegateCommand AddBookCommand { get; }
        public DelegateCommand ShowMessageCommand { get; }

        public void ShowMessage()
        {
            _messageService.ShowMessageAsync("Hello from the View-Model");
        }

        private async void LoadBooks()
        {
            try
            {
                var books = await _booksService.GetBooksAsync();
                _books.Clear();
                foreach (var book in books)
                {
                    _books.Add(book);
                }
                SelectedBook = Books.FirstOrDefault();
                _booksLoaded = true;
                AddBookCommand.RaiseCanExecuteChanged();
            }
            catch (Exception ex)
            {
                // handling - write to log, inform user
            }
        }

        private bool CanAddBook() => _booksLoaded;

        private void AddBook()
        {
            var book = new Book { BookId = 4, Title = "Professional C# 8", Publisher = "Wrox Press" };
            _books.Add(book);
            _eventAggregator.GetEvent<AddBookEvent>().Publish(book);
        }

        public IEnumerable<Book> Books => _books;

        private Book _selectedBook;

        public Book SelectedBook
        {
            get =>_selectedBook;
            set => SetProperty(ref _selectedBook, value);
        }
    }
}
