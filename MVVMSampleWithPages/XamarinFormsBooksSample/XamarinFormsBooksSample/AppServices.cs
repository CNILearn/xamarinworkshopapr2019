using BooksServices.Services;
using BooksServices.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using XamarinFormsBooksSample.LocalServices;
using Prism.Events;

namespace XamarinFormsBooksSample
{
    public class AppServices
    {
        private AppServices()
        {
            Container = RegisterServices();
        }

        private static AppServices s_instance;
        public static AppServices GetInstance() => s_instance ?? (s_instance = new AppServices());


        public IServiceProvider Container { get; }

        private IServiceProvider RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddScoped<BooksViewModel>();
            services.AddSingleton<IBooksService, BooksService>();
            services.AddSingleton<IPageService, PageService>();
            services.AddTransient<IShowMessageService, XamarinShowMessageService>();
            services.AddSingleton<IEventAggregator, EventAggregator>();
            return services.BuildServiceProvider();
        }
    }
}
