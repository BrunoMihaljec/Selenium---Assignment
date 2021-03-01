using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Selenium_Assignment.Methods;
using SeleniumExtras.WaitHelpers;
using System;
using TechTalk.SpecFlow;
using Selenium_Assignment.Web_Driver;
using NUnit.Framework;

namespace SpecFlow_Assignment.StepDefinitions
{
    [Binding]
    public class SaucedemoLogInFeatureSteps : IDisposable
    {
        private string Username;
        private string Password;
        private string CorrectUsername;
        private string CorrectPassword;
        private string Message;

        public SaucedemoLogInFeatureSteps() => WebDriver.driver = new ChromeDriver(@"C:\Users\mihal\OneDrive\Desktop\New folder (2)");       

        public void Dispose()
        {
            
            if (WebDriver.driver != null)
            {
                WebDriver.driver.Dispose();
                WebDriver.driver = null;
            }
        }

        [Given(@"I have navigated to saucedemo website")]
        public void GivenIHaveNavigatedToSaucedemoWebsite()
        {
            WebDriver.driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            Assert.IsTrue(WebDriver.driver.Url.Contains("saucedemo"));
            Assert.IsTrue(WebDriver.driver.Title.Contains("Swag Labs"));
        }
        
        [Given(@"I entered '(.*)' as username")]
        public void GivenIEnteredAsUsername(string p0)
        {
            this.Username = p0;
            var usernameInputBox = WebDriver.driver.FindElement(By.Name("user-name"));
            var wait = new WebDriverWait(WebDriver.driver, TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Name("user-name")));
            usernameInputBox.SendKeys(Username);
            
        }
        
        [Given(@"I entered '(.*)' as password")]
        public void GivenIEnteredAsPassword(string p0)
        {
            this.Password = p0;
            var passwordInputBox = WebDriver.driver.FindElement(By.Name("password"));
            var wait = new WebDriverWait(WebDriver.driver, TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Name("password")));
            passwordInputBox.SendKeys(Password);
            
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


        [Given(@"I entered correct username: '(.*)'")]
        public void GivenIEnteredCorrectUsername(string p0)
        {
            this.CorrectUsername = p0;
            var usernameInputBox = WebDriver.driver.FindElement(By.Name("user-name"));
            var wait = new WebDriverWait(WebDriver.driver, TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Name("user-name")));
            usernameInputBox.SendKeys(CorrectUsername);
            
        }

        [Given(@"I entered correct password: '(.*)'")]
        public void GivenIEnteredCorrectPassword(string p0)
        {
            this.CorrectPassword = p0;
            var passwordInputBox = WebDriver.driver.FindElement(By.Name("password"));
            var wait = new WebDriverWait(WebDriver.driver, TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Name("password")));
            passwordInputBox.SendKeys(CorrectPassword);
            
        }


        [When(@"I submit LOGIN button")]
        public void WhenISubmitLOGINButton()
        {
            var loginbutton = WebDriver.driver.FindElement(By.Id("login-button"));
            var wait = new WebDriverWait(WebDriver.driver, TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("login-button")));
            loginbutton.Submit();

        }
        
        [When(@"I click Menu button")]
        public void WhenIClickMenuButton()
        {
            var Menubutton = WebDriver.driver.FindElement(By.Id("react-burger-menu-btn"));
            var wait = new WebDriverWait(WebDriver.driver, TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("react-burger-menu-btn")));
            Menubutton.Submit();
        }
        
        [Then(@"the login should fail with '(.*)'")]
        public void ThenTheLoginShouldFailWith(string p0)
        {
            this.Message = p0;
            var message = WebDriver.driver.FindElement(By.XPath("//*[@id='login_button_container']/div/form/h3"));
            var wait = new WebDriverWait(WebDriver.driver, TimeSpan.FromSeconds(2));
            string messagetext = message.Text;
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='login_button_container']/div/form/h3")));           
            Assert.IsTrue(messagetext.Contains(Message));
        }
        
        [Then(@"I should be navigated to inventory page")]
        public void ThenIShouldBeNavigatedToInventoryPage()
        {
            Assert.IsTrue(WebDriver.driver.Url.Contains("inventory"));
            Assert.IsTrue(WebDriver.driver.Title.Contains("Swag Labs"));
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
