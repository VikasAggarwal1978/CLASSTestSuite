using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace CLASSTestSuite.Steps
{
    [Binding]
    public sealed class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            DriverHandler.InitialiseDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            DriverHandler.driver.Quit();
        }
    }
}
