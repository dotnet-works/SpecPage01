using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SpecPage01.AppPages.FoxyApp;



namespace SpecPage01.AppPages
{
    public class Pages
    {
        private IWebDriver _driver;
        public SearchPage googlePage;
        public SignUpPage foxySignUp;

        public Pages(IWebDriver driver)
        {
            this._driver = driver;
            googlePage = new SearchPage(driver);
            foxySignUp = new SignUpPage(driver);
        }

        public void goToApp()
        {
            this._driver.Url = "https://www.google.com/";
        }

        public void goToApp(string _url) 
        {
            this._driver.Url = _url;
        }

        protected IWebElement getPageElement(By _byLocator)
        {
            return WaitForElementDisplayed(_byLocator);
        }

        private IWebElement WaitForElementDisplayed(By _byLocator)
        {
            return new WebDriverWait(this._driver, TimeSpan.FromSeconds(20)).Until(ExpectedConditions.ElementIsVisible(_byLocator));
        }


    }
}
