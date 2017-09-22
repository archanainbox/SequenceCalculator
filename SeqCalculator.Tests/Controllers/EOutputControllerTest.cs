using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeqCalculator.Controllers;
using System.Linq;

namespace SeqCalculator.Tests.Controllers
{
    /// <summary>
    /// Summary description for EOutputControllerTest
    /// </summary>
    [TestClass]
    public class EOutputControllerTest
    {       
        [TestMethod]
        public void TestPositive()
        {
            var con = new EOutputController();
            var x = con.Get(20);

            Assert.AreEqual(5, x.ElementAt(0));
            Assert.AreEqual(10, x.ElementAt(1));
            Assert.AreEqual(15, x.ElementAt(2));
            Assert.AreEqual(20, x.ElementAt(3));
        }

        [TestMethod]
        public void TestNegative()
        {
            var con = new EOutputController();
            var x = con.Get(-3);
            Assert.AreEqual(1, x.Count());
            Assert.AreEqual(5, x.ElementAt(0));
        }
    }
}
