using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using Selenium_Assignment.Web_Driver;
using System;
using TechTalk.SpecFlow;
using Selenium_Assignment.PageObjects;
using Selenium_Assignment.PageObjects.Saucedemo;
using Selenium_Assignment.Methods;


namespace SpecFlow_Assignment.StepDefinitions
{
    [Binding]
    public class SaucedemoInventoryFeaturSteps : IDisposable
    {
        public void Dispose()
        {

            if (WebDriver.driver != null)
            {
                WebDriver.driver.Dispose();
                WebDriver.driver = null;
            }
        }

        [Given(@"I logged in")]
        public void GivenILoggedIn()
        {
            
            WebDriver.driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            SeleniumGetMethods.PageLoaded(WebDriver.driver.Url, "saucedemo");
            var wait = new WebDriverWait(WebDriver.driver, TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("login-button")));
            SeleniumSetMethods.EnterText(SaucedemoLogInPageObjects.textboxUsername, "standard_user");
            SeleniumSetMethods.EnterText(SaucedemoLogInPageObjects.textboxPassword, "secret_sauce");
            SeleniumSetMethods.Submits(SaucedemoLogInPageObjects.buttonLOGIN);
        }



        [Given(@"I navigated to saucedemo inventory page")]
        public void GivenINavigatedToSaucedemoInventoryPage()
        {
            SeleniumGetMethods.PageLoaded(WebDriver.driver.Url, "inventory");
            
        }

        [When(@"I click Menu button")]
        public void WhenIClickMenuButton()
        {           
            var wait = new WebDriverWait(WebDriver.driver, TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("react-burger-menu-btn")));
            SeleniumSetMethods.Clicks(SaucedemoInventoryPageObjects.buttonMenu);
        }

        [Then(@"Menu has been displayed")]
        public void ThenMenuHasBeenDisplayed()
        {           
            var wait = new WebDriverWait(WebDriver.driver, TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("react-burger-cross-btn")));
            SeleniumSetMethods.ElementHidden(SaucedemoInventoryPageObjects.buttonX);
            
        }
    }
}
