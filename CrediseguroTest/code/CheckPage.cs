using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrediseguroTest.code
{
    internal class CheckPage : Base
    {
        By planAnualPrice = By.XPath("//div[@class=\"col-12 col-sm-12 col-md-6 col-lg-6 col-xl-3 espacio-card-planes\"][4]//div[@class=\"card-footer\"]/h4");
        By tuDeporteOption = By.Id("MainContent_btnSports");
        public CheckPage(IWebDriver driver) : base(driver)
        { }
        public void clickDeporte()
        {
            Click(tuDeporteOption);
        }
        public string getText()
        {
            return getLinkText(planAnualPrice);
        }
    
    }
}
