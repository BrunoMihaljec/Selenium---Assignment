using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Selenium_Assignment.Web_Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Assignment.Tests
{
    public class Setup
    {
        [SetUp]
        public void Initialize()
        {
            WebDriver.driver = new ChromeDriver(@"C:\Users\mihal\OneDrive\Desktop\New folder (2)");
            
        }

        [TearDown]
        public void CleanUp()
        {
            WebDriver.driver.Close();
            Console.WriteLine("The Browser Closed!");
        }
    }
}
