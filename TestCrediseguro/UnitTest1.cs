using CrediseguroTest.code;
using OpenQA.Selenium;
using System.Diagnostics;

namespace TestCrediseguro
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver driver;
        MainPage mainPage;
        String text = "https://bit.ly/CrediseguroWhats";
        [TestInitialize]
        public void SetUp()
        {
            mainPage = new MainPage(driver);
            driver = mainPage.ChromeDriverConecction();
            mainPage.visit("http://www.crediseguro.com.bo/");
        }
        [TestMethod]
        public void TestMethod1()
        {
            Thread.Sleep(1000);
            Trace.WriteLine("Current link:" + mainPage.ReadLinkContact());
            Assert.IsTrue(mainPage.ReadLinkContact() == text, "links don't match");
            
            Thread.Sleep(5000);
        }
        [TestCleanup]
        public void Cleanup() 
        {
            driver.Quit();
        }
    }
}