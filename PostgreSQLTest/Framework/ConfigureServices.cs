using PostgreSQLTest.Interfaces;
using PostgreSQLTest.Services;
using PostgreSQLTest.Framework;
using System;
using System.Collections.Generic;
using System.Text;


using Microsoft.Extensions.DependencyInjection;

namespace PostgreSQLTest.Framework
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
