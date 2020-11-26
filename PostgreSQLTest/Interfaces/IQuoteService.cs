using PostgreSQLTest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PostgreSQLTest.Interfaces
{
    public interface IQuoteService 
    {    
        void TruncateQuotesTable();
        void InsertQuoteData();
        List<QuoteData> GetAllQuotes();
    }
}
