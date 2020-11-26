using PostgreSQLTest.Interfaces;
using PostgreSQLTest.Models;
using PostgreSQLTest.Framework;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace PostgreSQLTest.Services
{
    public class QuoteService : IQuoteService
    {
        private Properties _properties;
        private SandboxContext _context;     
        //private readonly IMapper _mapper;

        public QuoteService()
        {
            _context = new SandboxContext();
            _properties = new Properties();

            //Set the sanbox content connection string
            _context.cnnString = _properties.cnnString;
        }

        public List<QuoteData> GetAllQuotes()
        {
            var quoteData = new List<QuoteData>();

            var query = (from q in _context.QuoteData
                         select q).ToList();

            return query;
        }
        public void InsertQuoteData()
        {
            InsertQuoteRow("ADA");
            InsertQuoteRow("BTC");
            InsertQuoteRow("ETH");
            InsertQuoteRow("LTC");
            InsertQuoteRow("MRX");
        }
        private void InsertQuoteRow(string symbol)
        {
            var row = new QuoteData();
            row.Symbol = symbol;
            _context.QuoteData.Add(row);
            _context.SaveChanges();
        }
        public void TruncateQuotesTable()
        {
            _context.Database.ExecuteSqlRaw("TRUNCATE TABLE crypto_data.quote_data");
        }
    }
}
