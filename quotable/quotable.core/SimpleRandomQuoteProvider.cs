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
    public class SimpleRandomQuoteProvider : RandomQuoteProvider
    {
        private string[] quoteList;

        /// <summary>
        /// Returns a IEnumberable collection with n number of slots, where n = {@link numQuotesToReturn}
        /// </summary>
        /// <param name="numQuotesToReturn" description="Number of quotes to return"></param>
        /// <returns>IEnumberable</returns>
        public IEnumerable<string> RandomQuoteProviderMethod(long numQuotesToReturn)
        {             
            IList<Quote> quotesList = new List<Quote>();
            quotesList = GenerateQuotes(quotesList, numQuotesToReturn);
            Quote[] quotesArray = quotesList.ToArray();
            IList<string> quoteStringList = new List<string>();
            for(int i=0; i<numQuotesToReturn; i++)
            {                
                quoteStringList.Add(string.Format("Author: {0} ||  Quote: {1}", quotesArray[i].from, quotesArray[i].Text));
            }
            return quoteStringList;          
        }

        private List<Quote> GenerateQuotes(IList<Quote> quotesList, long numQuotesToReturn)
        {
            using (StreamReader r = File.OpenText("quotes.json"))
            {
                string json = r.ReadToEnd();
                List<Quote> quotes = JsonConvert.DeserializeObject<List<Quote>>(json);
                return quotes;
            }
        }
    }
}
