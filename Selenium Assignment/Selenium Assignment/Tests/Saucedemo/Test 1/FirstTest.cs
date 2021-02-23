using NUnit.Framework;
using Selenium_Assignment.PageObjects;
using Selenium_Assignment.Web_Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Assignment.Tests.Saucedemo.Test_1
{
    public class FirstTest : Setup
    {
        [Test]
        public void ExecuteTest()
        {
            WebDriver.driver.Navigate().GoToUrl("https://www.saucedemo.com/index.html");
            WebDriver.driver.Manage().Window.Maximize();

            SaucedemoLogInPageObjects.LogIn("standard_user", "secret_sauce", "Bruno", "Mihaljec");

        }
    }
}
