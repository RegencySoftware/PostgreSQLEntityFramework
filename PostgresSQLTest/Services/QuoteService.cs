using PostgresSQLTest.Interfaces;
using PostgresSQLTest.Models;
using PostgresSQLTest.Framework;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace PostgresSQLTest.Services
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
    }
}
