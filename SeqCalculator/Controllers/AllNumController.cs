using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SeqCalculator.Controllers
{
    public class AllNumController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "1" };
        }

        // GET: api/AllNum/5
        public IEnumerable<int> Get(int id)
        {

            if (id > 0) { return Enumerable.Range(1, id); }
            return Enumerable.Range(1, 1);
        }


    }
}
