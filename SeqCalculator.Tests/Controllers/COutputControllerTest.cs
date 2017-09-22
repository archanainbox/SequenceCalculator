using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeqCalculator.Controllers;
using System.Linq;

namespace SeqCalculator.Tests.Controllers
{
    /// <summary>
    /// Summary description for COutputControllerTest
    /// </summary>
    [TestClass]
    public class COutputControllerTest
    {
       
        [TestMethod]
        public void Test_Positive()
        {
            var con = new COutputController();

            var t = con.Get(8);

            Assert.AreEqual(3, t.ElementAt(0));
            Assert.AreEqual(6, t.ElementAt(1));
        }

        [TestMethod]
        public void Test_Negative()
        {
            var con = new COutputController();

            var t = con.Get(-1);

            Assert.AreEqual(1, t.Count());

            Assert.AreEqual(3, t.ElementAt(0));
        }
    }
}
