using TechTalk.SpecFlow;

namespace SpecPage01.StepDefinitions.ShareStepDef
{
    [Binding]
    public class FoxyNewUserSteps
    {

        private readonly ScenarioContext _scenarioContext;

        public FoxyNewUserSteps(ScenarioContext scenarioContext)
        {
            this._scenarioContext = scenarioContext;
        }
        [When(@"enter ""(.*)"" data")]
        public void WhenEnterData(string section_name)
        {
            
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