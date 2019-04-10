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
    public partial class BooksView : ContentView
    {
        public BooksView()
        {
            InitializeComponent();
            ViewModel = AppServices.GetInstance().Container.GetService<BooksViewModel>();
            this.BindingContext = ViewModel;
        }

        public BooksViewModel ViewModel { get; set; }
    }
}