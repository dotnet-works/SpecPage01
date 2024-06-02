using OpenQA.Selenium;
using SpecPage01.AppPages;
using TechTalk.SpecFlow;

namespace SpecPage01.StepDefinitions.ShareStepDef
{
    [Binding]
    public class FoxyNewUserSteps
    {

        private readonly ScenarioContext _scenarioContext;
        private IWebDriver _driver;
        public Pages appPage;
        public FoxyNewUserSteps(IWebDriver _driver,ScenarioContext scenarioContext)
        {
            this._scenarioContext = scenarioContext;
            this._driver = _driver;
            this.appPage = new Pages(this._driver);
        }
        [When(@"enter ""(.*)"" data")]
        public void WhenEnterData(string section_name)
        {
            
        }

        [When(@"enter new user ""(.*)"" data")]
        public void WhenEnterNewUserData(string p0, Table table)
        {
            this.appPage.foxySignUp.EnterAboutYouData("firstname");
        }

        [Then(@"email shoild be avialiable with new user")]
        public void ThenEmailShoildBeAvialiableWithNewUser()
        {
            Thread.Sleep(3000);
        }




        [When(@"click submit button")]
        public void WhenClickSubmitButton()
        {
            
        }

        [Then(@"user should navigate to new page")]
        public void ThenUserShouldNavigateToNewPage()
        {
           
        }
    }
}