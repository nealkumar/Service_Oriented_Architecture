using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace quotable.core
{
    public class SimpleRandomQuoteProvider : RandomQuoteProvider
    {
        private string[] quoteList;

        public IEnumerable<string> RandomQuoteProviderMethod(long numQuotesToReturn)
        {
            quoteList = new string[] { "One man's prototype is a manager's product.", "Talk is cheap. Show me the code.", "When the budget is low, go after the low hanging fruit" };
            string[] returnArray = new string[3];
            if (numQuotesToReturn > 3) numQuotesToReturn = 3;
            for(int i=0; i<numQuotesToReturn; i++)
            {
                returnArray[i] = quoteList[i];
            }
            return returnArray;          
        }
    }
}
