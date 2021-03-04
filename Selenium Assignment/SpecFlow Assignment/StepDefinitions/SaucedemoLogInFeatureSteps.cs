using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using Selenium_Assignment.Web_Driver;
using Selenium_Assignment.PageObjects.Saucedemo;
using Selenium_Assignment.PageObjects;
using Selenium_Assignment.Methods;

namespace SpecFlow_Assignment.StepDefinitions
{
    [Binding]
    public class SaucedemoLogInFeatureSteps
    {
        private string Username;
        private string Password;
        private string CorrectUsername;
        private string CorrectPassword;
        private string Message;

        [Given(@"I have navigated to saucedemo website")]
        public void GivenIHaveNavigatedToSaucedemoWebsite()
        {
            
            WebDriver.driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            SeleniumGetMethods.PageLoaded(WebDriver.driver.Url, "saucedemo");
        }
        
        [Given(@"I entered '(.*)' as username")]
        public void GivenIEnteredAsUsername(string p0)
        {
            this.Username = p0;            
            var wait = new WebDriverWait(WebDriver.driver, TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Name("user-name")));
            SeleniumSetMethods.EnterText(SaucedemoLogInPageObjects.textboxUsername, Username);                        
        }
        
        [Given(@"I entered '(.*)' as password")]
        public void GivenIEnteredAsPassword(string p0)
        {
            this.Password = p0;            
            var wait = new WebDriverWait(WebDriver.driver, TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Name("password")));
            SeleniumSetMethods.EnterText(SaucedemoLogInPageObjects.textboxPassword, Password);
        }

        


        [Given(@"I entered correct username: '(.*)'")]
        public void GivenIEnteredCorrectUsername(string p0)
        {
            this.CorrectUsername = p0;
            var wait = new WebDriverWait(WebDriver.driver, TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("user-name")));
            SeleniumSetMethods.EnterText(SaucedemoLogInPageObjects.textboxUsername, CorrectUsername);

        }

        [Given(@"I entered correct password: '(.*)'")]
        public void GivenIEnteredCorrectPassword(string p0)
        {
            this.CorrectPassword = p0;
            var wait = new WebDriverWait(WebDriver.driver, TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Name("password")));
            SeleniumSetMethods.EnterText(SaucedemoLogInPageObjects.textboxPassword, CorrectPassword);

        }


        [When(@"I submit LOGIN button")]
        public void WhenISubmitLOGINButton()
        {            
            var wait = new WebDriverWait(WebDriver.driver, TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("login-button")));
            SeleniumSetMethods.Submits(SaucedemoLogInPageObjects.buttonLOGIN);

        }
        
       
        
        [Then(@"the login should fail with '(.*)'")]
        public void ThenTheLoginShouldFailWith(string p0)
        {
            this.Message = p0;           
            var wait = new WebDriverWait(WebDriver.driver, TimeSpan.FromSeconds(2));
            string messagetext = SeleniumGetMethods.GetText(SaucedemoLogInPageObjects.textMessage);
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='login_button_container']/div/form/h3")));           
            Assert.IsTrue(messagetext.Contains(Message));
            SeleniumGetMethods.VerifyText(messagetext, Message);
        }
        
        [Then(@"I should be navigated to inventory page")]
        public void ThenIShouldBeNavigatedToInventoryPage()
        {
            SeleniumGetMethods.PageLoaded(WebDriver.driver.Url, "inventory");
        }
        
        
    }
}
