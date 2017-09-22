using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace SeqCalculator.Tests.Controllers
{
    using SeqCalculator.Controllers;
    /// <summary>
    /// Summary description for ZOutputControllerTest
    /// </summary>
    [TestClass]
    public class ZOutputControllerTest
    {
        [TestMethod]
        public void TestGetPositiveNumber()
        {

            var con = new ZOutputController();
            var t = con.Get(45);

            Assert.AreEqual(15, t.ElementAt(0));
            Assert.AreEqual(30, t.ElementAt(1));
            Assert.AreEqual(45, t.ElementAt(2));
        }


        [TestMethod]
        public void TestGetNegativeNumber()
        {
            var con = new ZOutputController();
            var t = con.Get(-3);

            Assert.AreEqual(1, t.Count());
            

        }
    }
}
