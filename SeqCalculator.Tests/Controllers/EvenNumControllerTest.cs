using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using SeqCalculator.Controllers;

namespace SeqCalculator.Tests.Controllers
{
    /// <summary>
    /// Summary description for EvenNumControllerTest
    /// </summary>
    [TestClass]
    public class EvenNumControllerTest
    {
        [TestMethod]
        public void TestPositive()
        {
            var con = new EvenNumController();
            var t = con.Get(5);

            Assert.AreEqual(2, t.ElementAt(0));
            Assert.AreEqual(4, t.ElementAt(1));
           
        }

        [TestMethod]
        public void TestNegative()
        {
            var con = new EvenNumController();
            var t = con.Get(-2);

            Assert.AreEqual(1, t.Count());
            Assert.AreEqual(2, t.ElementAt(0));

        }
    }
}
