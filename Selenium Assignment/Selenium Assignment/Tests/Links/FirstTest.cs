using NUnit.Framework;
using Selenium_Assignment.Web_Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selenium_Assignment.PageObjects;
using Selenium_Assignment.Log;

namespace Selenium_Assignment.Tests.Links
{
    public class FirstTest : Setup
    {
        [Test]
        public void ExecuteTest()
        {
            Logger.XmlRun();
            Logger.logger.Info("Links Test 1\n");

            Logger.logger.Debug("Launched Browser");

            WebDriver.driver.Navigate().GoToUrl("https://www.links.hr/hr/");
            Logger.logger.Debug("Going to URL 'https://www.links.hr/hr/'");
            
            Logger.logger.Debug("Maximizing Browser");
            WebDriver.driver.Manage().Window.Maximize();

            Logger.logger.Debug("Clicking 'Računala' category");
            LinksProductsPageObject.SelectPCs();

            Logger.logger.Debug("Searching webshop for 'Razer Laptop'");
            LinksSearchPageObject.SearchProduct("Razer Laptop");

            Logger.logger.Debug("Exiting the Browser");

        }
    }
}
