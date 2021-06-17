using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSTestSuite.POM
{
    public class HomePage : Base
    {
        public string Links = "//h2[text()='{0}']";   
        public void GoToLink(string link)
        {
            navigator.FindElement(By.XPath(string.Format(Links, link))).Click();
        }

        public void GoToLink2()
        {
            navigator.FindElement(By.XPath("//a[@title='Online group insurance quotations']")).Click();
        }
    }
}
