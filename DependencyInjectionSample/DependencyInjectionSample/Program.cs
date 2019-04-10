using Microsoft.Extensions.DependencyInjection;
using System;

namespace DependencyInjectionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Container = RegisterServices();
            var controller = Container.GetService<HomeController>();
            var greet = controller.Hello("Stephanie");
            Console.WriteLine(greet);
        }

        public static IServiceProvider Container { get; private set; }

        public static IServiceProvider RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddTransient<IGreetingService, GreetingService>();
            services.AddTransient<HomeController>();
            return services.BuildServiceProvider();
        }
    }
}
