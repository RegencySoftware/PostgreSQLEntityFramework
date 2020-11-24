using PostgresSQLTest.Interfaces;
using PostgresSQLTest.Services;
using PostgresSQLTest.Framework;
using System;
using System.Collections.Generic;
using System.Text;


using Microsoft.Extensions.DependencyInjection;

namespace PostgresSQLTest.Framework
{
    public static class ConfigureServices
    {
        public static ServiceProvider sp;

        public static void SetupCollection()
        {
            var services = new ServiceCollection();
            services.AddScoped();

            sp = services.BuildServiceProvider();
        }

        private static IServiceCollection AddScoped(this IServiceCollection services)
        {            
            services.AddScoped(typeof(IQuoteService), typeof(QuoteService));
            services.AddScoped(typeof(IProperties), typeof(Properties));
            return services;
        }

    }
}
