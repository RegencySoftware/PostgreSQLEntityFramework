using PostgresSQLTest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PostgresSQLTest.Interfaces
{
    public interface IQuoteService 
    {
        List<QuoteData> GetAllQuotes(); 

    }
}
