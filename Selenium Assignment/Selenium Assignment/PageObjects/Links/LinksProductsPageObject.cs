using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selenium_Assignment.Web_Driver;
using Selenium_Assignment.Methods;

namespace Selenium_Assignment.PageObjects
{
    static class LinksProductsPageObject
    {
        
        public static IWebElement btnRačunala => WebDriver.driver.FindElement(By.XPath("/html/body/div[5]/div[8]/div[6]/div[1]/div[1]/div[2]/ul[2]/li/ul/li[5]"));


        public static void SelectPCs()
        {
            try
            {
                SeleniumSetMethods.StepStart("Loads web page (https://www.links.hr/hr/).", "1");
                SeleniumGetMethods.PageLoaded(WebDriver.driver.Url, "links");
                Console.WriteLine("Button 'Računala':");
                SeleniumSetMethods.ElementDisplayed(btnRačunala);
                SeleniumSetMethods.ElementEnabled(btnRačunala);

                SeleniumSetMethods.StepStart("Clicks button 'Računala'.", "2");
                SeleniumSetMethods.Clicks(btnRačunala);
                string urlSorted = WebDriver.driver.Url;
                SeleniumSetMethods.WaitForPageToLoad(WebDriver.driver, 35);
                SeleniumGetMethods.PageLoaded(urlSorted, "racunala");
            }
            catch(Exception e)
            {
                throw new Exception(String.Format("Test failed! {0}", e.StackTrace));
            }
        }
    }

    
}
