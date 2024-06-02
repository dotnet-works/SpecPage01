using AventStack.ExtentReports.Gherkin.Model;
using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecPage01.SpecExtent;
using TechTalk.SpecFlow;

namespace SpecPage01.WebHooks
{
    [Binding]
    public sealed class WebHook
    {
       
        private readonly IObjectContainer _container;
        private IWebDriver _driver;
        public BrowserInit browserInit;
        private string? _browserName=null;

        public WebHook(IObjectContainer _container) {  this._container = _container;   }

        //[BeforeFeature]
        //public void BeforeFeature1(FeatureContext featureContext) 
        //{
        //    Console.WriteLine("Running Before Feature....");
        //    SpecExtentManager.CreateParentTest<Feature>(featureContext.FeatureInfo.Title,"");
        //}


        [BeforeScenario]
        public void BeforeScenarioWithTag()
        {
            this._browserName = Environment.GetEnvironmentVariable("browserName") ;
            Console.WriteLine($"browserName: {this._browserName}");

            browserInit = new BrowserInit(this._driver);
            this._container.RegisterInstanceAs<IWebDriver>(browserInit.StartBrowser(BrowserType.Chrome));

            //this._driver = browserInit.StartBrowser(this._browserName);
            //this._container.RegisterInstanceAs<IWebDriver>(this._driver);



        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            
        }

        [AfterScenario]
        public void AfterScenario()
        {
            var webDriver = this._container.Resolve<IWebDriver>();

            if (webDriver == null) return;

            webDriver.Close();
            webDriver.Dispose();
        }
    }

    

    






}