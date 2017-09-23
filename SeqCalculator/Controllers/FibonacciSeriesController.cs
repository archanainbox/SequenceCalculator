using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SeqCalculator.Controllers
{
    public class FibonacciSeriesController : ApiController
    {
        // GET: api/FibonacciSeries
        public IEnumerable<string> Get()
        {
            return new string[] { "1" };
        }

        // GET: api/FibonacciSeries/5
        public IEnumerable<int> Get(int id)
        {
            int a = 1;
            int b = 0;

            for (int i = 1; i <= id; i++)
            {
                int c = a + b;
                a = b;
                b = c;
                yield return c;
            }

        }


    }
}
