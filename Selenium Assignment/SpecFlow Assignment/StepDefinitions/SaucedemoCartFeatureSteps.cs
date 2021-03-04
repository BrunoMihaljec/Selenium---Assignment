using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using Selenium_Assignment.Web_Driver;
using System;
using TechTalk.SpecFlow;
using Selenium_Assignment.PageObjects;
using Selenium_Assignment.Methods;
using Selenium_Assignment.PageObjects.Saucedemo;

namespace SpecFlow_Assignment.StepDefinitions
{
    [Binding]
    public class SaucedemoCartFeatureSteps : IDisposable
    {
        public void Dispose()
        {

            if (WebDriver.driver != null)
            {
                WebDriver.driver.Dispose();
                WebDriver.driver = null;
            }
        }

        [Given(@"I logged in as standard user")]
        public void GivenILoggedInAsStandardUser()
        {
            WebDriver.driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            SeleniumGetMethods.PageLoaded(WebDriver.driver.Url, "saucedemo");
            var wait = new WebDriverWait(WebDriver.driver, TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("login-button")));
            SeleniumSetMethods.EnterText(SaucedemoLogInPageObjects.textboxUsername, "standard_user");
            SeleniumSetMethods.EnterText(SaucedemoLogInPageObjects.textboxPassword, "secret_sauce");
            SeleniumSetMethods.Submits(SaucedemoLogInPageObjects.buttonLOGIN);
            SeleniumGetMethods.PageLoaded(WebDriver.driver.Url, "inventory");
        }

        [Given(@"I added Sauce Labs Backpack to Cart")]
        public void GivenIAddedSauceLabsBackpackToCart()
        {
            
            var wait = new WebDriverWait(WebDriver.driver, TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='inventory_container']/div/div[1]/div[3]/button")));
            SeleniumSetMethods.Clicks(SaucedemoInventoryPageObjects.buttonaddtocart);
        }

        [Given(@"I navigate to Cart page")]
        public void GivenINavigateToCartPage()
        {
            SeleniumGetMethods.PageLoaded(WebDriver.driver.Url, "inventory");           
            var wait = new WebDriverWait(WebDriver.driver, TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='shopping_cart_container']/a")));
            SeleniumSetMethods.Clicks(SaucedemoCartPageObjects.buttonCart);
            SeleniumGetMethods.PageLoaded(WebDriver.driver.Url, "cart");
        }

        [When(@"I click Menu")]
        public void WhenIClickMenu()
        {           
            var wait = new WebDriverWait(WebDriver.driver, TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("react-burger-menu-btn")));
            SeleniumSetMethods.Clicks(SaucedemoCartPageObjects.buttonMenu);
        }

        [Then(@"Menu is displayed")]
        public void ThenMenuIsDisplayed()
        {
            var wait = new WebDriverWait(WebDriver.driver, TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("react-burger-cross-btn")));
            SeleniumSetMethods.ElementHidden(SaucedemoCartPageObjects.buttonX);
        }

    }
}
