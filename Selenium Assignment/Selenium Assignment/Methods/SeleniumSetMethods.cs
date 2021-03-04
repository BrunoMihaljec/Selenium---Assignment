using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using Selenium_Assignment.Log;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Selenium_Assignment.Methods
{
    public static class SeleniumSetMethods
    {

        public static void ElementDisplayedAndEnabled(IWebElement element)
        {
            ElementDisplayed(element);
            ElementEnabled(element);
        }

        public static void ElementDisplayedEnabledAndEmpty(IWebElement element)
        {
            ElementDisplayed(element);
            ElementEnabled(element);
            ElementEmpty(element);
        }

        public static void ElementDisplayed(IWebElement element)
        {
            try
            {
                //Print message if assert is true
                Assert.IsTrue(element.Displayed);
                Console.WriteLine(String.Format("{0} is displayed.", nameof(element)));
                Logger.logger.Debug(String.Format("{0} is displayed", nameof(element)));
                
            }
            catch (Exception e)
            {
                Logger.logger.Error(String.Format("{0} is not displayed", nameof(element)));
                //Print message if assert is false
                throw new Exception(String.Format("Element is not displayed! {0}", e.StackTrace));
            }
        }
     

        public static void MoveToElement(IWebElement element, IWebDriver driver)
        {
            Actions scroll = new Actions(driver);
            scroll.MoveToElement(element);
            scroll.Perform();
        }

        public static void ElementHidden(IWebElement element)
        {
            try
            {
                //Print message if assert is true
                string hidden = element.GetAttribute("tabindex");
                if(hidden == "-1")
                {
                    Console.WriteLine(String.Format("{0} is hidden.", nameof(element)));
                    Logger.logger.Debug(String.Format("{0} is hidden", nameof(element)));
                }
                else
                {
                    Console.WriteLine(String.Format("{0} is shown.", nameof(element)));
                    Logger.logger.Debug(String.Format("{0} is shown", nameof(element)));
                }
                
            }
            catch (Exception e)
            {
                Logger.logger.Error(String.Format("{0} is displayed", nameof(element)));
                //Print message if assert is false
                throw new Exception(String.Format("Element is displayed! {0}", e.StackTrace));
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
                Logger.logger.Debug(String.Format("{0} is empty", nameof(element)));
            }
            catch (Exception e)
            {
                Logger.logger.Error(String.Format("{0} is not empty", nameof(element)));
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
                Logger.logger.Debug(String.Format("{0} is enabled", nameof(element)));
            }
            catch (Exception e)
            {
                Logger.logger.Error(String.Format("{0} is disabled", nameof(element)));
                //Print message if assert is false
                throw new Exception(String.Format("Element is disabled! {0}", e.StackTrace));
            }

        }
     

        public static void  StepStart(string stepname, string stepnumber)
        {
            Console.WriteLine("\nStep {0} - {1}\n", stepnumber, stepname);
            Logger.logger.Debug(String.Format("Step {0} - {1}\n", stepnumber, stepname));
        }

        public static void Clears(IWebElement element)
        {
            try
            {
                element.SendKeys(Keys.LeftControl + Keys.Backspace);
                Console.WriteLine(String.Format("{0} Cleared.", nameof(element)));
                Logger.logger.Debug(String.Format("{0} Cleared", nameof(element)));
            }

            catch (Exception e)
            {
                Logger.logger.Error(String.Format("{0} is not cleared", nameof(element)));
                throw new Exception(String.Format("Element is not cleared! {0}", e.StackTrace));
            }
        }

        public static void EnterText(IWebElement element, string value)
        {
            try
            {
                element.SendKeys(value);
                Console.WriteLine(String.Format("'{0}' text entered in {1}.", value, nameof(element)));
                Logger.logger.Debug(String.Format("{0} text entered is {1}", value, nameof(element)));
            }

            catch(Exception e)
            {
                Logger.logger.Error(String.Format("{0} is not entered", value));
                throw new Exception(String.Format("Text is not entered! {0}", e.StackTrace));
            }
        }

        public static void Clicks(IWebElement element)
        {
            try
            {
                element.Click();
                Console.WriteLine(String.Format("{0} clicked.", nameof(element)));
                Logger.logger.Debug(String.Format("{0} clicked", nameof(element)));
            }

            catch (Exception e)
            {
                Logger.logger.Error(String.Format("{0} is not clicked", nameof(element)));
                throw new Exception(String.Format("Element is not clicked! {0}", e.StackTrace));
            }
        }

        public static void Submits(IWebElement element)
        {
            try
            {
                element.Submit();
                Console.WriteLine(String.Format("{0} submited.", nameof(element)));
                Logger.logger.Debug(String.Format("{0} submited", nameof(element)));
            }

            catch (Exception e)
            {
                Logger.logger.Error(String.Format("{0} is not submited", nameof(element)));
                throw new Exception(String.Format("Element is not submited! {0}", e.StackTrace));
            }
        }     

        public static void WaitForPageToLoad(IWebDriver driver, int seconds)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(seconds)).Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
        }
    }
}
