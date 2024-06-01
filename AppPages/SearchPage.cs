using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace SpecPage01.AppPages
{
    public class SearchPage
    {
        private IWebDriver _driver;

        public SearchPage(IWebDriver driver)
        {
            this._driver = driver;
            //this.driver.Url = "https://www.google.com/";
            PageFactory.InitElements(driver, this);
        }

        


        [FindsBy(How = How.Name, Using = "q")]
        public IWebElement SearchInput;

       // public IWebElement searchInput = _driver.FindElement(By.Name("q"));

        
        






    }
}
