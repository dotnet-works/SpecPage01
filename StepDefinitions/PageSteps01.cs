using NUnit.Framework;
using OpenQA.Selenium;
using SpecPage01.AppPages;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Infrastructure;

namespace SpecPage01.StepDefinitions
{
    [Binding]
    public sealed class PageSteps01
    {
        private IWebDriver driver;
        public Pages appPage;
        private readonly ISpecFlowOutputHelper _helper;
        public PageSteps01(IWebDriver driver, ISpecFlowOutputHelper _helper)
        {
            this.driver = driver;
            this._helper = _helper;
            this.appPage = new Pages(driver);
        }


        [Given(@"simple google test")]
        public void g01()
        {
            this.appPage.goToApp("https://www.google.com/");
            this.appPage.googlePage.SearchInput.SendKeys("hello Specflow\n");
        }

        [Then(@"test should fail")]
        public void f01()
        {
            ((ITakesScreenshot)this.driver).GetScreenshot().SaveAsFile("Screenshot.png");



            this._helper.WriteLine("This is some helper method");
            this._helper.AddAttachment("Screenshot.png");
            this._helper.AddAttachment("");
            Assert.AreEqual(1, 2);
        }
    }
}
