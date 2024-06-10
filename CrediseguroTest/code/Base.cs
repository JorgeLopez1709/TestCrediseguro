using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrediseguroTest.code
{
    public class Base
    {
        private IWebDriver driver;
        public Base(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebDriver ChromeDriverConecction() 
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait= TimeSpan.FromSeconds(15);
            driver.Manage().Window.Maximize();
            return driver;
        }
        public IWebElement findElement(By locator)
        {
            return driver.FindElement(locator);
        }
        public String getText (By locator) 
        {
            return driver.FindElement(locator).Text;
        }
        public String getLinkText(By locator) 
        {
            return driver.FindElement(locator).GetAttribute("href");
        }
        public void type(String text, By locator)
        {
            driver.FindElement(locator).SendKeys(text);
        }
        public void Click(By locator)
        {
            driver.FindElement(locator).Click();
        }
        public void visit(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
    }
}
