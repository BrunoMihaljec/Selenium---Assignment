using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selenium_Assignment.Web_Driver;
using Selenium_Assignment.Methods;
using OpenQA.Selenium;

namespace Selenium_Assignment.PageObjects
{
    static class LinksSearchPageObject
    {
        public static IWebElement txtSearch => WebDriver.driver.FindElement(By.Name("q"));

        public static IWebElement btnSearch => WebDriver.driver.FindElement(By.XPath("/html/body/div[5]/div[1]/div[3]/div/div[4]/div/form/div/input"));
    
    
        public static void SearchProduct(string search)
        {
           
                Console.WriteLine("Textbox 'Search':");
                SeleniumSetMethods.ElementDisplayedAndEnabled(txtSearch);

                SeleniumSetMethods.StepStart("Clears textbox 'Search'.", "3");
                SeleniumSetMethods.Clears(txtSearch);
                SeleniumSetMethods.ElementEmpty(txtSearch);

                SeleniumSetMethods.StepStart("Enters text 'Razer Laptop' in 'Search' textbox.", "4");
                SeleniumSetMethods.EnterText(txtSearch, search);
                string enteredtext = SeleniumGetMethods.GetValue(txtSearch);
                SeleniumGetMethods.VerifyText(enteredtext, search);
                Console.WriteLine("Button 'Search':");
                SeleniumSetMethods.ElementDisplayedAndEnabled(btnSearch);

                SeleniumSetMethods.StepStart("Submits button 'Search'.", "5");
                SeleniumSetMethods.Submits(btnSearch);
                string urlSearch = WebDriver.driver.Url;
                SeleniumSetMethods.WaitForPageToLoad(WebDriver.driver, 35);
                SeleniumGetMethods.PageLoaded(urlSearch, "search");
                Console.WriteLine("Searched Links web shop for '{0}'!", search);
        
        }
    }
}
