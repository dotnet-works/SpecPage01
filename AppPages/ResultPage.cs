using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecPage01.AppPages
{

    public class ResultPage
    {
        private IWebDriver _driver;

        public ResultPage(IWebDriver driver)
        {
            this._driver = driver;
            PageFactory.InitElements(driver, this);
        }

        protected By _toolsBTN = By.XPath("//div[@id='hdtb-tls']");
        protected By _resultStat = By.XPath("//div[@id='result-stats']");

        //[FindsBy(How = How.XPath, Using = "//div[@id='hdtb-tls']")]
        //public IWebElement _ToolsBTN;

        //[FindsBy(How=How.Id,Using = "//div[@id='result-stats']")]
        //public IWebElement _ResultStat;






    }
}
