using System;
using quotable.core;
using System.Collections.Generic;

namespace quotable.console
{
    class Program
    {
        /**
         * Note: Args[0] -> "N" number of quotes
         */ 
        static void Main(string[] args)
        {
            IEnumerable < string > enumerable = new quotable.core.SimpleRandomQuoteProvider().RandomQuoteProviderMethod(3);
            foreach (var val in enumerable)
                Console.WriteLine(val);

            Console.ReadKey();
        }
    }
}
