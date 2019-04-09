using BooksServices;
using System;
using System.Collections.Generic;
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
        private Book _theBook = new Book { BookId = 1, Title = "Professional C#", Publisher = "Wrox" };
        public MainPage()
        {
            InitializeComponent();
            //Title1 = "some title";
            //MyInput = string.Empty;
            this.BindingContext = _theBook;
        }

        private void OnShowTitle(object sender, EventArgs e)
        {
            bookTitle.Text = _theBook.Title;
        }

        private void OnChangeTitleFromCode(object sender, EventArgs e)
        {
            _theBook.Title = "Professional C# 8";
        }

        //public string Title1 { get; set; }

        //private string _myInput;

        //public string MyInput
        //{
        //    get { return _myInput; }
        //    set { _myInput = value; }
        //}


    }
}
