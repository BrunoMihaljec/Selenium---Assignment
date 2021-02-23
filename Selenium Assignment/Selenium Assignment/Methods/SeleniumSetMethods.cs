using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Assignment.Methods
{
    public static class SeleniumSetMethods
    {
        public static void ElementDisplayed(IWebElement element)
        {
            try
            {
                //Print message if assert is true
                Assert.IsTrue(element.Displayed);
                Console.WriteLine(String.Format("{0} is displayed.", nameof(element)));
            }
            catch (Exception e)
            {
                //Print message if assert is false
                throw new Exception(String.Format("Element is not displayed! {0}", e.StackTrace));
            }
        }

        public static void ElementEmpty(IWebElement element)
        {

            string text = element.GetAttribute("value");

            try
            {
                //Print message if assert is true
                Assert.IsEmpty(text);
                Console.WriteLine(String.Format("{0} is empty.", nameof(element)));
            }
            catch (Exception e)
            {
                //Print message if assert is false
                throw new Exception(String.Format("Element is not empty! {0}", e.StackTrace));
            }
        }

        public static void ElementEnabled(IWebElement element)
        {
            try
            {
                //Print message if assert is true
                Assert.IsTrue(element.Enabled);
                Console.WriteLine(String.Format("{0} is enabled.", nameof(element)));
            }
            catch (Exception e)
            {
                //Print message if assert is false
                throw new Exception(String.Format("Element is not enabled! {0}", e.StackTrace));
            }

        }

        public static void  StepStart(string stepname, string stepnumber)
        {
            Console.WriteLine("Step {0} - {1}", stepnumber, stepname);
        }

        public static void Clears(IWebElement element)
        {
            try
            {
                element.SendKeys(Keys.LeftControl + Keys.Backspace);
                Console.WriteLine(String.Format("{0} Cleared.", nameof(element)));
            }

            catch (Exception e)
            {
                throw new Exception(String.Format("Element is not cleared! {0}", e.StackTrace));
            }
        }

        public static void EnterText(IWebElement element, string value)
        {
            try
            {
                element.SendKeys(value);
                Console.WriteLine(String.Format("'{0}' text entered in {1}.", value, nameof(element)));
            }

            catch(Exception e)
            {
                throw new Exception(String.Format("ext is not entered! {0}", e.StackTrace));
            }
        }

        public static void Clicks(IWebElement element)
        {
            try
            {
                element.Click();
                Console.WriteLine(String.Format("{0} clicked.", nameof(element)));
            }

            catch (Exception e)
            {
                throw new Exception(String.Format("Element is not clicked! {0}", e.StackTrace));
            }
        }

        public static void Submits(IWebElement element)
        {
            try
            {
                element.Submit();
                Console.WriteLine(String.Format("{0} submited.", nameof(element)));
            }

            catch (Exception e)
            {
                throw new Exception(String.Format("Element is not submited! {0}", e.StackTrace));
            }
        }     

        public static void WaitForPageToLoad(IWebDriver driver, int seconds)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(seconds)).Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
        }
    }
}
