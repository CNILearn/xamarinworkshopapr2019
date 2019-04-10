using BooksServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Microsoft.Extensions.DependencyInjection;
using XamarinFormsBooksSample.LocalServices;

namespace XamarinFormsBooksSample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
     
        public MainPage()
        {
            InitializeComponent();
            var pageService = AppServices.GetInstance().Container.GetService<IPageService>();
            pageService.Page = this;
        }


    }
}
