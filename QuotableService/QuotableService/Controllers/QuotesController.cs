using QuotesDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuotableService.Controllers
{
    public class QuotesController : ApiController
    {
        [HttpGet]
        public IEnumerable<QUOTE> Get()
        {
            using (QuotesDetailsEntities entities = new QuotesDetailsEntities())
            {
                return entities.QUOTES.ToList();
            }
        }

        [HttpGet]
        public QUOTE Get(int id)
        {
            using (QuotesDetailsEntities entities = new QuotesDetailsEntities())
            {
                return entities.QUOTES.FirstOrDefault(e => e.Id == id);
            }
        }

    }
}
