using OpenQA.Selenium;

namespace SpecPage01.StepDefinitions
{
    [Binding]
    public sealed class WebSteps01
    {
        private IWebDriver _driver;
        public WebSteps01(IWebDriver _driver)
        {
            this._driver = _driver;
        }

        [Given(@"open search site")]
        public void GivenOpenSearchSite()
        {
            this._driver.Url = "https://www.google.com/";
        }

        [When(@"enter search data ""(.*)""")]
        public void WhenEnterSearchData(string p0)
        {
            this._driver.FindElement(By.Name("q")).SendKeys($"{p0}\n");
        }

        [Then(@"user should navigate to google search page")]
        public void ThenUserShouldNavigateToGoogleSearchPage()
        {
            Thread.Sleep(3000);
            _driver.Title.Should().Contain("Google Search");
        }

    }
}
