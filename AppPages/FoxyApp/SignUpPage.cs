﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecPage01.AppPages.FoxyApp
{
    public class SignUpPage
    {
        private IWebDriver _driver;
        public SignUpPage(IWebDriver driver)
        {
            this._driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How=How.Id,Using = "first_name")]
        protected IWebElement _uFirstName;

        [FindsBy(How = How.Id, Using = "last_name")]
        protected IWebElement _uLastName;

        [FindsBy(How = How.Id, Using = "email")]
        protected IWebElement _uEmail;

        [FindsBy(How = How.Id, Using = "pwd")]
        protected IWebElement _uPassword;

        [FindsBy(How = How.Id, Using = "foxy_desire")]
        protected IWebElement _uUserDesire;

        [FindsBy(How = How.Id, Using = "how_they_found_us")]
        protected IWebElement _HowUserHear;

    //    [FindsBy(How = How.Id, Using = "")]
    //    protected IWebElement e;
       
        public void EnterAboutYouData(string? missLabel=null)
        {
            if (missLabel.ToLower() != "firstname")
            {
                _uFirstName.SendKeys("somedata");
            }

            if (missLabel.ToLower() != "lastname")
            {
                _uLastName.SendKeys("somedata");
            }
            if (missLabel.ToLower() != "email")
            {
                _uEmail.SendKeys("somedata");
            }

            if (missLabel.ToLower() != "password")
            {
                _uPassword.SendKeys("21312424@ewwer");
            }

            if (!missLabel.ToLower().Contains("what do you want to accomplish with foxycart?"))
            {
                _uUserDesire.SendKeys("somedata");
            }

            if (!missLabel.ToLower().Contains("how did you hear about us?"))
            {
                _HowUserHear.SendKeys("somedata");
            }
        }







    //    /*
    //       driver.get("https://admin.foxycart.com/signup/");
    //driver.manage().window().setSize(new Dimension(984, 692));
    //driver.findElement(By.id("first_name")).click();
    //driver.findElement(By.id("first_name")).sendKeys("joya");
    //driver.findElement(By.id("last_name")).click();
    //driver.findElement(By.id("last_name")).sendKeys("dddfsf");
    //driver.findElement(By.id("email")).click();
    //driver.findElement(By.id("email")).sendKeys("hkdsd@yopmail.com");
    //driver.findElement(By.id("foxy_desire")).click();
    //driver.findElement(By.cssSelector("fieldset:nth-child(2)")).click();
    //driver.findElement(By.id("pwd")).click();
    //driver.findElement(By.id("pwd")).sendKeys("Password@213243454");
    //driver.findElement(By.id("foxy_desire")).click();
    //driver.findElement(By.id("foxy_desire")).sendKeys("ewrewerfter");
    //driver.findElement(By.id("how_they_found_us")).click();
    //driver.findElement(By.id("how_they_found_us")).sendKeys("how u hear");
    //driver.findElement(By.id("is_programmer")).click();
    //driver.findElement(By.id("is_developer")).click();
    //driver.findElement(By.id("is_designer")).click();
    //driver.findElement(By.id("is_merchant")).click();
    //driver.findElement(By.id("store_name")).click();
    //driver.findElement(By.id("store_name")).sendKeys("myzebrastore");
    //driver.findElement(By.id("store_domain")).click();
    //driver.findElement(By.id("store_domain")).sendKeys("myzebrastore");
    //driver.findElement(By.cssSelector(".row > .label_checkbox")).click();
    //driver.switchTo().frame(0);
    //driver.findElement(By.cssSelector(".recaptcha-checkbox-border")).click();
    //driver.switchTo().defaultContent();
    //driver.findElement(By.id("next")).click();
    //driver.findElement(By.linkText("Log Out")).click(); 
        
    //     */

    }
}
