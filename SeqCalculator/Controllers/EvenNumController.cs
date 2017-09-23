using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SeqCalculator.Controllers
{
    public class EvenNumController : ApiController
    {
        // GET: api/EvenNum
        public IEnumerable<string> Get()
        {
            return new string[] { "0" };
        }

        // GET api/odd/5
        public IEnumerable<int> Get(int id)
        {
            if (id > 0)
            {
                return Enumerable.Range(1, id).Where(x => x % 2 == 0).ToList();
            }
            return Enumerable.Range(2, 1);

        }

    }
}
