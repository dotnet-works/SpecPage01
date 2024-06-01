Feature: Google Search
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecPageModel01/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@web
Scenario: Search google
   Given open search site
   When enter search data "specflow selenium tutorial"
   Then user should navigate to google search page

Scenario: Test PageObjectModel
   Given simple google test
   Then user should navigate to google search page

Scenario: Test Fail PageObjectModel
   Given simple google test
   Then user should navigate to google search page
   But test should fail