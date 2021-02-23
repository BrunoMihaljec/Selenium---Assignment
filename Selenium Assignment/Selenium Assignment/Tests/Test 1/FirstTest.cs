using NUnit.Framework;
using Selenium_Assignment.Web_Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selenium_Assignment.PageObjects;

namespace Selenium_Assignment.Tests.Test_1
{
    public class FirstTest : Setup
    {
        [Test]
        public void ExecuteTest()
        {
            WebDriver.driver.Navigate().GoToUrl("https://www.links.hr/hr/");
            WebDriver.driver.Manage().Window.Maximize();
            

            ProductsPageObject.SelectPCs();

            SearchPageObject.SearchProduct("Razer Laptop");

        }
    }
}
