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
            var quoteService = Framework.ConfigureServices.sp.GetService<IQuoteService>();

            Console.WriteLine("\n (1) Truncate Crypto Quotes Table...\n");
            quoteService.TruncateQuotesTable();

            Console.WriteLine("\n (2) Insert Crypto Quote Data...\n");
            quoteService.InsertQuoteData();


            Console.WriteLine("\n (3) Get Crypto Symbols...\n");            
          
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
