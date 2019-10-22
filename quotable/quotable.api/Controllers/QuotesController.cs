using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace quotable.api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class QuotesController : ControllerBase
    {
        // GET: api/Quotes
        /// <summary>
        /// Returns all of the Quotes.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<string> Get()
        {            
            return new quotable.core.SimpleQuoteProvider().GetAllQuotes();
        }

        // GET: api/Quotes/5
        /// <summary>
        /// Returns a single quote as specified by ID. Since there is no ID field in quotes.json,
        /// it treats the ID as the index of the SimpleRandomQuoteProvider.quotesList()
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return new quotable.core.SimpleQuoteProvider().GetById(id);
        }
    }
}
