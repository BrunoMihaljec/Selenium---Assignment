using OpenQA.Selenium.Chrome;
using Selenium_Assignment.Web_Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Selenium_Assignment.Tests;

namespace SpecFlow_Assignment.Hooks
{
    [Binding]
    public class MyHooks
    {

        [BeforeScenario]
        public static void SetupTest()
        {
            Setup.Initialize();
        }

        [AfterScenario]
        public static void TearDown()
        {
            Setup.CleanUp();
        }

    }
}
