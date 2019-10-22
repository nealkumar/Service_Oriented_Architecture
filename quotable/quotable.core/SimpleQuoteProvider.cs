using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Linq;

namespace quotable.core
{
    /// <summary>
    /// Provides a random quote.
    /// </summary>
    public class SimpleQuoteProvider : QuoteProvider
    {
        private IList<Quote> quotesList { get; set; }
        private IList<string> quotesStringList { get; set; }

        /// <summary>
        /// Generates a quote list from data (in either string or Quote format) and allows basic read operations, including random.
        /// </summary>
        public SimpleQuoteProvider()
        {
            quotesList = GenerateQuotes(quotesList);
            Quote[] quotesArray = quotesList.ToArray();
            this.quotesStringList = new List<string>();
            foreach (Quote q in quotesList)
            {
                this.quotesStringList.Add(string.Format("Author: {0} ||  Quote: {1}", q.from, q.Text));
            }
        }

        /// <summary>
        /// Returns a set number of quotes, as specified by {@link numQuotesToReturn}.
        /// 
        /// Used by quotable.console
        /// 
        /// </summary>
        /// <param name="numQuotesToReturn"></param>
        /// <returns></returns>
        public IEnumerable<string> QuoteProviderMethod(long numQuotesToReturn)
        {
            List<string> result = new List<string>();
            for (int index = 0; index < numQuotesToReturn; index++)
            {
                result.Add(this.quotesStringList.ElementAt(index));
            }
            return result;
        }

        private List<Quote> GenerateQuotes(IList<Quote> quotesList)
        {
            using (StreamReader r = File.OpenText("quotes.json"))
            {
                string json = r.ReadToEnd();
                List<Quote> quotes = JsonConvert.DeserializeObject<List<Quote>>(json);
                return quotes;
            }
        }

        /// <summary>
        /// Returns a IEnumberable collection with n number of slots, where n = {@link numQuotesToReturn}
        /// </summary>
        /// <returns>IEnumberable</returns>
        public IEnumerable<string> GetAllQuotes()
        {                 
            return this.quotesStringList;          
        }

        /// <summary>
        /// Returns a String of a Quote object by id n, where n = {@link index}
        /// </summary>
        /// <param name="index" description="Index of the quote to return"></param>
        /// <returns>IEnumberable</returns>
        public string GetById(int index)
        {
            return this.quotesStringList.ElementAt(index);
        }

        /// <summary>
        /// Returns a String of a Quote object by id n, where n = random int -1 < n < quotesStringList.size()
        /// </summary>
        /// <returns>IEnumberable</returns>
        public string GetByRandom()
        {
            Random rand = new Random();
            int index = rand.Next(0, quotesStringList.Count+1);
            return this.quotesStringList.ElementAt(index);
        }

    }
}
