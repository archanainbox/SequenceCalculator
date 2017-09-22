using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeqCalculator.Tests.Controllers
{
    using System.Linq;
    using SeqCalculator.Controllers;
    /// <summary>
    /// Summary description for AllNumControllerTest
    /// </summary>
    [TestClass]
    public class AllNumControllerTest
    {
             
        [TestMethod]
        public void TestGetPositiveNumber()
        {
            AllNumController controller = new AllNumController();

            var actural = controller.Get(1500).ElementAt(1499);

            Assert.AreEqual(1500, actural);
        }

        [TestMethod]
        public void TestGetNegativeNumber()
        {
            AllNumController controller = new AllNumController();

            var actural = controller.Get(-1).ElementAt(0);

            Assert.AreEqual(1, actural);
        }
    }
}
