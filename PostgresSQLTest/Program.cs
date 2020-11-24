using PostgresSQLTest.Interfaces;
using PostgresSQLTest.Services;
using PostgresSQLTest.Framework;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace PostgresSQLTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Framework.ConfigureServices.SetupCollection();

            Console.WriteLine("\n Listing Crypto Symbols...\n");
                                    
            var quoteService = Framework.ConfigureServices.sp.GetService<IQuoteService>();
            var quoteData = quoteService.GetAllQuotes();

            foreach (var item in quoteData)
            {
                Console.Write(" " + item.Symbol);
                Console.Write("\n");
            }

            Console.WriteLine("\n Done...\n");

            Console.ReadLine();

        }
    }
}
