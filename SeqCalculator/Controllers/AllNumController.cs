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
        // GET: api/AllNum
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/AllNum/5
        public IEnumerable<int> Get(int id)
        {

            if (id > 0) { return Enumerable.Range(1, id); }
            return Enumerable.Range(1, 1);
        }


    }
}
