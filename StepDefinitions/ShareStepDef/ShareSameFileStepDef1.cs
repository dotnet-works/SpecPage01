using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecPage01.StepDefinitions.ShareStepDef
{
    [Binding]
    public class ShareSameFileStepDef1
    {
        private IWebDriver _driver;
        private ScenarioStepContext _stepContext;
        private readonly ScenarioContext _scenarioContext;
        public ShareSameFileStepDef1(IWebDriver driver,ScenarioContext scenarioContext)
        {
            this._driver = driver;
            this._stepContext = scenarioContext.StepContext; 
            this._scenarioContext = scenarioContext;
        }

        [When(@"acces data")]
        public void access_shared_data()
        {
            var mydat = this._scenarioContext.Get<string>("Val1");
            TestContext.WriteLine($"Access data in different step file: {mydat}");
        }
        
    }
}