using BooksServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinFormsBooksSample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        // private Book _theBook = new Book { BookId = 1, Title = "Beginning C#", Publisher = "Wrox", Authors = new[] { "Karli Watson", "Christian Nagel" } };
        private ObservableCollection<Book> _books;        
        public MainPage()
        {
            InitializeComponent();

            _books = new ObservableCollection<Book>(new BookFactory().GetBooks());
            SelectedBook = _books.FirstOrDefault();
            this.BindingContext = this;
        }

        public IList<Book> Books => _books;

        private Book _selectedBook;

        public Book SelectedBook
        {
            get => _selectedBook;
            set
            {
                if (value != null)
                {
                    _selectedBook = value;

                    base.OnPropertyChanged();
                }
            }
        }


        private void OnShowTitle(object sender, EventArgs e)
        { 

        }

        private void OnChangeTitleFromCode(object sender, EventArgs e)
        {
            // _theBook.Title = "Professional C# 8";
        }

        private void OnBookSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //if (e.SelectedItem is Book book)
            //{
            //    SelectedBook = book;
            //}
        }

        private void OnAddBook(object sender, EventArgs e)
        {
            _books.Add(new Book { BookId = 5, Title = "Professional C# 9", Publisher = "Wrox", Authors = new[] { "Christian Nagel" } });
        }

    }
}
