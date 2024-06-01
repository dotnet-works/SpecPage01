using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecPage01.WebHooks
{
    public class BrowserInit
    {
        private IWebDriver driver;
        public BrowserInit(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebDriver StartBrowser(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    Console.WriteLine("Starting Chrome Browser");
                    ChromeOptions cOptions = new ChromeOptions();
                    cOptions.AddArgument("--test-type");
                    this.driver = new ChromeDriver(cOptions);
                    break;

                case BrowserType.Firefox:
                    Console.WriteLine("Starting Firefox Browser");
                    this.driver = new FirefoxDriver();
                    break;

                default:
                    Console.WriteLine("Starting Chrome Browser by default");
                    this.driver = new ChromeDriver();
                    //throw new ArgumentException("No Browser is defined");
                    break;

            }
            this.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            this.driver.Manage().Window.Maximize();
            //if (browserType == BrowserType.Chrome) {   }
            return driver;
        }


    }
}
