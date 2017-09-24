using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SeqCalculator.UI.Tests
{
    [TestClass]
    public class UISeqTest
    {
        private static IWebDriver driverGC;
        private bool acceptNextAlert = true;
        string alertText;
        IAlert alert;


        [AssemblyInitialize]
        public static void SetUp(TestContext context)
        {
            
            driverGC = new ChromeDriver(); 
         }
        
        [TestMethod]
        public void TestChromeDriver()
        {
                                 
            driverGC.Navigate().GoToUrl("http://localhost:61000/");
            driverGC.FindElement(By.Id("number_input")).SendKeys("5");
            driverGC.FindElement(By.Id("result")).SendKeys(Keys.Enter);
        }

        [TestMethod]
        public void TestResult()
        {
            driverGC.Navigate().GoToUrl("http://localhost:61000/");
            driverGC.FindElement(By.Id("number_input")).SendKeys("15");
            driverGC.FindElement(By.Id("result")).SendKeys(Keys.Enter);

            Assert.AreEqual("1,1,2,3,5,8,13,21,34,55,89,144,233,377,610", driverGC.FindElement(By.Id("FibonacciSeries")).Text);
            Assert.AreEqual("1,2,3,4,5,6,7,8,9,10,11,12,13,14,15", driverGC.FindElement(By.Id("AllNum")).Text);
            Assert.AreEqual("2,4,6,8,10,12,14", driverGC.FindElement(By.Id("evens")).Text);
            Assert.AreEqual("1,3,5,7,9,11,13,15", driverGC.FindElement(By.Id("odds")).Text);
            Assert.AreEqual("3,6,9,12,15", driverGC.FindElement(By.Id("c")).Text);
            Assert.AreEqual("5,10,15", driverGC.FindElement(By.Id("e")).Text);
            Assert.AreEqual("15", driverGC.FindElement(By.Id("z")).Text);
        }

        [TestMethod]
        public void TestNegativeAndAlert()
        {
            driverGC.Navigate().GoToUrl("http://localhost:61000/");
            driverGC.FindElement(By.Id("number_input")).SendKeys("A");
            
            alert = driverGC.SwitchTo().Alert();
            alertText = alert.Text;
            Assert.AreEqual("Please enter Positive whole Number.", alertText);
            CloseAlertAndGetItsText();

            driverGC.FindElement(By.Id("number_input")).SendKeys("30");
            driverGC.FindElement(By.Id("result")).SendKeys(Keys.Enter);
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }

    }
}
