using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using quotable.core;

namespace quotable.api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RandomController : ControllerBase
    {
        // GET: Random
        /// <summary>
        /// Retrieves a random Quote from quoteable.core.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string Get()
        {
            return new SimpleQuoteProvider().GetByRandom();
        }
    }
}
