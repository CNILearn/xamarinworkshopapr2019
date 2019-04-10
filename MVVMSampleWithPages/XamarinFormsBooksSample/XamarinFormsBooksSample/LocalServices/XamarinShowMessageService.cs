using BooksServices.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinFormsBooksSample.LocalServices
{
    public class XamarinShowMessageService : IShowMessageService
    {
        private readonly IPageService _pageService;
        public XamarinShowMessageService(IPageService pageService)
        {
            _pageService = pageService ?? throw new ArgumentNullException(nameof(pageService));
        }

        public Task ShowMessageAsync(string message)
        {
            _pageService.Page.DisplayAlert("Message", message, "Close");
            return Task.CompletedTask;
        }
    }
}
