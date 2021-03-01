using NUnit.Framework;
using Selenium_Assignment.PageObjects;
using Selenium_Assignment.PageObjects.Saucedemo;
using Selenium_Assignment.Web_Driver;
using System;
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
            WebDriver.driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            WebDriver.driver.Manage().Window.Maximize();

            SaucedemoLogInPageObjects.LogIn("standard_user", "secret_sauce", "Bruno", "Mihaljec");

            SaucedemoInventoryPageObjects.InventoryPage();

            SaucedemoCartPageObjects.CartPage();
        }
    }
}
