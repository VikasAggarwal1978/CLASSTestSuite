Feature: SpecFlowFeature1

Scenario: Create a new CLASS group quote
Given I login to Class group insurance site
And I navigate to "New Schemes" section
And I proceed to new eQuotes quotation eligibility page
When I fill new eQuotes quotation using data from excel "Test.xls"
And I do the risk profile
Then the quote is created successfully


