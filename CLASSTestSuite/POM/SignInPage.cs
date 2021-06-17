using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSTestSuite.POM
{
   public class SignInPage : Base
    {
        public string LoginNameTxtBox = "username";
        public string PasswordTxtBox = "password";
        public string SignInBtn = "//a[@title='Sign In']";

        public SignInPage()
        {
            navigator.Navigate().GoToUrl(ConfigurationManager.AppSettings["SignInUrl"]);
        }

        public void doLogin(string userName, string password)
        {
            navigator.FindElement(By.Id(LoginNameTxtBox)).SendKeys(userName);
            navigator.FindElement(By.Id(PasswordTxtBox)).SendKeys(password);
            navigator.FindElement(By.XPath(SignInBtn)).Click();
        }
    }
}
