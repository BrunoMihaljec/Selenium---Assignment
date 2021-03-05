using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selenium_Assignment.Web_Driver;
using Selenium_Assignment.Methods;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Selenium_Assignment.PageObjects
{
    static class LinksProductsPageObject
    {

        public static IWebElement btnRačunala => WebDriver.driver.FindElement(By.XPath("/html/body/div[6]/div[8]/div[6]/div[1]/div[1]/div[2]/ul[2]/li/ul/li[5]/a"));
        

        public static void SelectPCs()
        {
                SeleniumSetMethods.StepStart("Loads web page (https://www.links.hr/hr/).", "1");
                SeleniumGetMethods.PageLoaded(WebDriver.driver.Url, "links");
                
                Console.WriteLine("Button 'Računala':");                           
                SeleniumSetMethods.ElementDisplayedAndEnabled(btnRačunala);

                SeleniumSetMethods.StepStart("Clicks button 'Računala'.", "2");
                SeleniumSetMethods.MoveToElement(btnRačunala, WebDriver.driver);
                SeleniumSetMethods.Clicks(btnRačunala);
                string urlSorted = WebDriver.driver.Url;
                SeleniumSetMethods.WaitForPageToLoad(WebDriver.driver, 35);
                SeleniumGetMethods.PageLoaded(urlSorted, "racunala");
           
        }
    }

    
}
