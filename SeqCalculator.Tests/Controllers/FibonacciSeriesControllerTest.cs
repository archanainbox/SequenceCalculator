using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeqCalculator.Controllers;
using System.Linq;

namespace SeqCalculator.Tests.Controllers
{
    /// <summary>
    /// Summary description for FibonacciSeriesControllerTest
    /// </summary>
    [TestClass]
    public class FibonacciSeriesControllerTest
    {
        
        [TestMethod]
        public void TestPositive()
        {
            var con = new FibonacciSeriesController();
            var t = con.Get(5);
           
            Assert.AreEqual(1, t.ElementAt(0));
            Assert.AreEqual(1, t.ElementAt(1));
            Assert.AreEqual(2, t.ElementAt(2));
            Assert.AreEqual(3, t.ElementAt(3));
            Assert.AreEqual(5, t.ElementAt(4));
        }
    }
}
