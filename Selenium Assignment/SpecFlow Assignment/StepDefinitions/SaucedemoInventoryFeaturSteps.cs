using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Selenium_Assignment.Web_Driver;
using SeleniumExtras.WaitHelpers;
using System;
using TechTalk.SpecFlow;

namespace SpecFlow_Assignment.StepDefinitions
{
    [Binding]
    public class SaucedemoInventoryFeaturSteps : IDisposable
    {
        public SaucedemoInventoryFeaturSteps() => WebDriver.driver = new ChromeDriver(@"C:\Users\mihal\OneDrive\Desktop\New folder (2)");

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
            Assert.IsTrue(WebDriver.driver.Url.Contains("saucedemo"));
            Assert.IsTrue(WebDriver.driver.Title.Contains("Swag Labs"));
            var usernameInputBox = WebDriver.driver.FindElement(By.Name("user-name"));
            var passwordInputBox = WebDriver.driver.FindElement(By.Name("password"));
            var loginbutton = WebDriver.driver.FindElement(By.Id("login-button"));
            var wait = new WebDriverWait(WebDriver.driver, TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("login-button")));
            usernameInputBox.SendKeys("standard_user");
            passwordInputBox.SendKeys("secret_sauce");
            loginbutton.Submit();
        }



        [Given(@"I navigated to saucedemo inventory page")]
        public void GivenINavigatedToSaucedemoInventoryPage()
        {

            Assert.IsTrue(WebDriver.driver.Url.Contains("inventory"));
            Assert.IsTrue(WebDriver.driver.Title.Contains("Swag Labs"));
        }

        [When(@"I click Menu button")]
        public void WhenIClickMenuButton()
        {
            var Menubutton = WebDriver.driver.FindElement(By.Id("react-burger-menu-btn"));
            var wait = new WebDriverWait(WebDriver.driver, TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("react-burger-menu-btn")));
            Menubutton.Submit();
        }

        [Then(@"Menu has been displayed")]
        public void ThenMenuHasBeenDisplayed()
        {
            var buttonX = WebDriver.driver.FindElement(By.Id("react-burger-cross-btn"));
            var wait = new WebDriverWait(WebDriver.driver, TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("react-burger-cross-btn")));
            string hidden = buttonX.GetAttribute("tabindex");
            Assert.IsTrue(hidden == "0");
        }
    }
}
