using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SeqCalculator.Controllers
{
    public class OddNumController : ApiController
    {
        // GET: api/OddNum
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/odd/5
        public IEnumerable<int> Get(int id)
        {
            if (id <= 0)
                return Enumerable.Range(1, 1);
            return Enumerable.Range(1, id).Where(x => x % 2 == 1).ToList();
        }

    }
}
