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
            long num;
            try
            {
                num = long.Parse(args[0]);
            } catch(Exception e)
            {
                num = 10;
                Console.WriteLine("**No console arg provided. Default value of 10 provided.***\n");
            }
            
            IEnumerable < string > enumerable = new SimpleRandomQuoteProvider().RandomQuoteProviderMethod(num);
            foreach (var val in enumerable)
                Console.WriteLine(val);

            Console.ReadKey();
        }
    }
}
