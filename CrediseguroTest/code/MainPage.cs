using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrediseguroTest.code
{
    public class MainPage : Base
    {
        By contactButton = By.XPath("//div[@class=\"col-md-8 text-center\"]/a");
        By menuButton = By.XPath("//div[@class=\"container\"]/a[@href=\"#\"]");
        By segurosIndividualesOption = By.XPath("//div[@id=\"menu\"]//a[@href=\"/seguros-individuales\"]");
        public MainPage(IWebDriver driver) : base(driver)
        { }
        public string ReadLinkContact()
        {
            return getLinkText(contactButton);
        }
        public void ClickMenu()
        {
            Click(menuButton);
        }
        public void ClickSeguros() 
        {
            Click(segurosIndividualesOption);
        }
    }
}
