using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecPage01.StepDefinitions
{
    [Binding]
    public sealed class CommonSteps
    {
        private ScenarioContext scenarioContext;
        private ScenarioStepContext stepContext;
        private IWebDriver _driver;
        public CommonSteps(IWebDriver driver, ScenarioContext scenarioContext )
        {
            this.scenarioContext = scenarioContext;
            this._driver = driver;
        }

        [Given(@"open site url ""(.*)""$")]
        [Given(@"open app url ""(.*)""$")]
        public void openSite(string siteURL)
        {
            this._driver.Url = siteURL;
            TestContext.WriteLine($"site name: foxy");
            this.scenarioContext.Add("Val1", "Halua");
        }

        [When(@"enter all data")]
        public void WhenEnterAllData()
        {
            var mydat = this.scenarioContext.Get<string>("Val1");
            TestContext.WriteLine($"myStep Context: {mydat}");
        }

        [Then(@"user navigates to newpage")]
        public void ThenUserNavigatesToNewpage()
        {
            TestContext.WriteLine($"new page");
        }

    }
}