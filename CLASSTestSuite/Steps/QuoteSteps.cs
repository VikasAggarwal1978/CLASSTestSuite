using CLASSTestSuite.POM;
using CLASSTestSuite.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace CLASSTestSuite.Steps
{
    [Binding]
    public sealed class QuoteSteps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public QuoteSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
       
        [Given(@"I login to Class group insurance site")]
        public void GivenILoginToClassGroupInsuranceSite()
        {            
            new SignInPage().doLogin("aggvikas11","Class123");
        }

        [Given(@"I navigate to ""(.*)"" section")]
        [When(@"I navigate to ""(.*)"" section")]
        public void GivenINavigateToSection(string link)
        {
            new HomePage().GoToLink(link);
        }

        [Given(@"I proceed to new eQuotes quotation eligibility page")]
        public void GivenIProceedToNewEQuotesQuotationEligibilityPage()
        {           
          new HomePage().GoToLink2();
          new EQuotesHomePage().GoToLink();
        }

        [When(@"I fill new eQuotes quotation using data from excel ""(.*)""")]
        public void WhenIFillNewEQuotesQuotationUsingDataFromExcel(string fileName)
        {
            var data = ExcelUtils.GetExcelColumnData("", "");
            new EQuotesEligibilityPage().FilleQuoteEligibilityPageData(data);
        }


    }
}
