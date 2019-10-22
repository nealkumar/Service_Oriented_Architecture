using NUnit.Framework;

namespace quotable.api.tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestQuoteControllerGetAll()
        {
            var quoteService = new quotable.api.Controllers.QuotesController();
            var fullText = quoteService.Get();
            if (fullText != null) Assert.Pass();
            else Assert.Fail();
        }

        [Test]
        public void TestQuoteControllerGetById()
        {
            var quoteService = new quotable.api.Controllers.QuotesController();
            var singleQuote = quoteService.Get(50);
            if (singleQuote != null) Assert.Pass();
            else Assert.Fail();
        }

        [Test]
        public void TestRandomControllerGet()
        {
            var quoteService = new quotable.api.Controllers.RandomController();
            var singleQuote = quoteService.Get();
            if (singleQuote != null) Assert.Pass();
            else Assert.Fail();
        }
    }
}