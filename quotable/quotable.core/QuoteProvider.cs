using System;
using System.Collections.Generic;
using System.Text;

namespace quotable.core
{
    /// <summary>
    /// Provides the contract for implementing random quotes.
    /// </summary>
    interface QuoteProvider
    {
        /// <summary>
        /// Takes in a long which is the number of quotes to return, and returns an IEnumberable with a collection of string quotes.
        /// </summary>
        /// <param name="numQuotesToReturn"></param>
        /// <returns></returns>
        IEnumerable<string> QuoteProviderMethod(long numQuotesToReturn);
    }
}
