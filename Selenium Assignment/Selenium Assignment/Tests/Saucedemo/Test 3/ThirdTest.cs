using NUnit.Framework;
using Selenium_Assignment.PageObjects;
using Selenium_Assignment.PageObjects.Saucedemo;
using Selenium_Assignment.Web_Driver;
using System;
using Selenium_Assignment.Log;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Selenium_Assignment.Tests.Saucedemo.Test_3
{
    public class ThirdTest : Setup
    {
        [Test]
        public void ExecuteTest()
        {
            Logger.XmlRun();
            Logger.logger.Info("Saucedemo Test 3\n");

            Logger.logger.Debug("Launched Browser");

            WebDriver.driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            Logger.logger.Debug("Going to URL 'https://www.saucedemo.com/'");

            Logger.logger.Debug("Maximizing Browser");
            WebDriver.driver.Manage().Window.Maximize();

            Logger.logger.Debug("Logging into a Website");
            SaucedemoLogInPageObjects.LogIn("standard_user", "secret_sauce", "Bruno", "Mihaljec");

            Logger.logger.Debug("Adding product to cart and clicking Cart button");
            SaucedemoInventoryPageObjects.InventoryPage();

            Logger.logger.Debug("Clicking 'CHECKOUT' button");
            SaucedemoCartPageObjects.CartPage();

            Logger.logger.Debug("Exiting the Browser");
        }
    }
}
