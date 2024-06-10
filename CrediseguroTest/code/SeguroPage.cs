using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrediseguroTest.code
{
    public class SeguroPage : Base
    {
        
        By checkImage = By.XPath("//section[@id=\"content\"]//a");
        public SeguroPage(IWebDriver driver) : base(driver)
        { }
        public string ReadLinkContact()
        {
            return getLinkText(checkImage);
        }
        
    
    }
}
