using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSTestSuite.POM
{
   public class EQuotesEligibilityPage : Base
    {
        public void FilleQuoteEligibilityPageData(Dictionary<string,string> data)
        {
            foreach (string field in data.Keys)
            {
                switch (field)
                {
                    case "For how many years has the client been in business?":
                        navigator.FindElement(By.Id("ctl00_Main_txtYears")).SendKeys(data[field]);
                        break;
                    case "Please provide the Companies House registration number":
                        navigator.FindElement(By.Id("ctl00_Main_CompanyNumberTextBox")).SendKeys(data[field]);
                        break;
                    case "Please select the industry":
                        SelectByText(By.Name("ctl00$Main$cmbIndustryType"), data[field]);
                        break;
                    case "Number of employee deaths within the last 12 months":
                        navigator.FindElement(By.Id("ctl00_Main_txtNumLifeClaims")).SendKeys(data[field]);
                        break;
                    case "Number of employees absent for longer than 3 months within the last 12 months":
                        navigator.FindElement(By.Id("ctl00_Main_txtNumIPClaims")).SendKeys(data[field]);
                        break;
                    case "How many employees have suffered from a serious illness within the last 12 months?":
                        navigator.FindElement(By.Id("ctl00_Main_txtNumCIClaims")).SendKeys(data[field]);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
