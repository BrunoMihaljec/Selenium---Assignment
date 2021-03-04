using OpenQA.Selenium.Chrome;
using Selenium_Assignment.Web_Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Selenium_Assignment.PageObjects.Saucedemo;
using Selenium_Assignment.PageObjects;

namespace SpecFlow_Assignment.Hooks
{
    [Binding]
    public class MyHooks
    {

        [BeforeScenario]
        public static void SetupTest()
        { 
            WebDriver.driver = new ChromeDriver(@"C:\Users\mihal\OneDrive\Desktop\New folder (2)");
        }

        [AfterScenario]
        public static void TearDown()
        {
            WebDriver.driver.Close();
        }

    }
}
