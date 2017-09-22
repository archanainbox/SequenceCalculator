using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeqCalculator.Controllers;
using System.Linq;

namespace SeqCalculator.Tests.Controllers
{
    /// <summary>
    /// Summary description for OddNumControllerTest
    /// </summary>
    [TestClass]
    public class OddNumControllerTest
    {
        [TestMethod]
        public void Test_Positive_Odd()
        {
            var con = new OddNumController();
            var t = con.Get(5);

            Assert.AreEqual(1, t.ElementAt(0));
            Assert.AreEqual(3, t.ElementAt(1));
            Assert.AreEqual(5, t.ElementAt(2));
        }

        [TestMethod]
        public void TestNegative()
        {
            var con = new OddNumController();
            var t = con.Get(-2);

            Assert.AreEqual(1, t.Count());
            Assert.AreEqual(1, t.ElementAt(0));

        }
    }
}
