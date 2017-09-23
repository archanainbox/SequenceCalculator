using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SeqCalculator.Controllers
{
    public class ZOutputController : ApiController
    {
        // GET: api/ZOutput
        public IEnumerable<string> Get()
        {
            return new string[] { "15" };
        }

        // GET: api/ZOutput/5
        public IEnumerable<int> Get(int id)
        {
            if (id > 0)
                return Enumerable.Range(1, id).Where(n => (n % 3 == 0) && (n % 5 == 0));
            return new int[] { 15 };
        }


    }
}
