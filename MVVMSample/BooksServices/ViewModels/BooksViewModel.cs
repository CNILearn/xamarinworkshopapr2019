using BooksServices.Models;
using BooksServices.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using TheBestMVVMLibraryInTown;

namespace BooksServices.ViewModels
{
    public class BooksViewModel : ViewModelBase
    {
        private readonly IBooksService _booksService;
        private readonly ObservableCollection<Book> _books = new ObservableCollection<Book>();
        private readonly IShowMessageService _messageService;

        private bool _booksLoaded = false;

        public BooksViewModel(IBooksService booksService,
            IShowMessageService messageService)
        {
            _booksService = booksService ?? throw new ArgumentNullException(nameof(booksService));
            _messageService = messageService ?? throw new ArgumentNullException(nameof(messageService));

            LoadBooksCommand = new DelegateCommand(LoadBooks);
            AddBookCommand = new DelegateCommand(AddBook, CanAddBook);
            ShowMessageCommand = new DelegateCommand(ShowMessage);
        }

        public DelegateCommand LoadBooksCommand { get; }
        public DelegateCommand AddBookCommand { get; }
        public DelegateCommand ShowMessageCommand { get; }

        public void ShowMessage()
        {
            _messageService.ShowMessageAsync("Hello from the View-Model");
        }

        private async void LoadBooks()
        {
            var books = await _booksService.GetBooksAsync();
            _books.Clear();
            foreach (var book in books)
            {
                _books.Add(book);
            }
            _booksLoaded = true;
            AddBookCommand.OnExecuteChanged();
        }

        private bool CanAddBook() => _booksLoaded;

        private void AddBook()
        {
            _books.Add(new Book { BookId = 4, Title = "Professional C# 8", Publisher = "Wrox Press" });
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
