using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSTestSuite.POM
{
   public class EQuotesHomePage:Base
    {
        public void GoToLink()
        {
            navigator.FindElement(By.Id("ctl00_Main_NewQuoteButton")).Click();
        }
    }
}
