using BooksServices.Services;
using BooksServices.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using XamarinFormsBooksSample.LocalServices;
using Prism.Events;
using Microsoft.Extensions.Http;
using Polly;

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
            services.AddHttpClient("books", config =>
            {
                config.BaseAddress = new Uri("http://localhost:49314/");
            })
            .AddTransientHttpErrorPolicy(policy => policy.WaitAndRetryAsync(new[] { TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(10) }))
            .AddTypedClient<IBooksService, APIBooksService>();
//             services.AddSingleton<IBooksService, APIBooksService>();
            services.AddSingleton<IPageService, PageService>();
            services.AddTransient<IShowMessageService, XamarinShowMessageService>();
            services.AddSingleton<IEventAggregator, EventAggregator>();
            return services.BuildServiceProvider();
        }
    }
}
