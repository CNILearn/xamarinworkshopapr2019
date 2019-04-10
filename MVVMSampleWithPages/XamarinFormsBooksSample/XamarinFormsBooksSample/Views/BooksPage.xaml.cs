using BooksServices.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsBooksSample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BooksPage : ContentPage
    {
        public BooksPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        public BooksViewModel ViewModel { get; } = AppServices.GetInstance().Container.GetService<BooksViewModel>();
    }
}