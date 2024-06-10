using CrediseguroTest.code;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCrediseguro
{
    [TestClass]
    public class UnitTest2
    {
        private IWebDriver driver;
        Base basePage;
        MainPage mainPage;
        SeguroPage seguroPage;
        String text = "https://check.com.bo/";
        [TestInitialize]
        public void SetUp()
        {
            basePage = new Base(driver);
            driver = basePage.ChromeDriverConecction();            
            mainPage = new MainPage(driver); 
            seguroPage = new SeguroPage(driver);
            basePage.visit("http://www.crediseguro.com.bo/");
        }
        [TestMethod]
        public void TestMethod1()
        {
            Thread.Sleep(1000);
            mainPage.ClickMenu();
            Thread.Sleep(1000);
            mainPage.ClickSeguros();
            Trace.WriteLine("Current link:" + seguroPage.ReadLinkContact());
            Assert.IsTrue(seguroPage.ReadLinkContact() == text, "links don't match");

            Thread.Sleep(2000);
        }
        [TestCleanup]
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}
