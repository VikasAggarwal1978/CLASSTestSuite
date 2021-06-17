using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSTestSuite.POM
{
   public class Base
    {
        protected IWebDriver navigator = DriverHandler.driver;

        public void SelectByText(By by, string text)
        {
            IWebElement element = navigator.FindElement(by);
            SelectElement select = new SelectElement(element);
            select.SelectByText(text);
        }
    }
}
