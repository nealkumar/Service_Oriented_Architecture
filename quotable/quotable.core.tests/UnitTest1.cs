using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace quotable.core.tests
{
    public class Tests
    {
        private SimpleQuoteProvider quoteCore;
        [SetUp]
        public void Setup()
        {
            quoteCore = new quotable.core.SimpleQuoteProvider();
        }

        [Test]
        public void TestIfCoreObjectIsNull()
        {
            if (quoteCore != null) Assert.Pass();
            else Assert.Fail();
        }

        [Test]
        public void TestIfGetAllIsNull()
        {
            var getAll = quoteCore.GetAllQuotes();
            if (getAll != null) Assert.Pass();
            else Assert.Fail();
        }

        [Test]
        public void TestIfCorrectNumberOfValues()
        {
            int num = 50;
            IEnumerable<string> test = quoteCore.QuoteProviderMethod(num);
            List<string> testS = new List<string>(test);
            if (testS.Count() == num)
            {
                Assert.Pass();
            }
            else Assert.Fail();
        }
    }
}