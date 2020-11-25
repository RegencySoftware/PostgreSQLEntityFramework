using PostgresSQLTest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PostgresSQLTest.Interfaces
{
    public interface IQuoteService 
    {    
        void TruncateQuotesTable();
        void InsertQuoteData();
        List<QuoteData> GetAllQuotes();
    }
}
