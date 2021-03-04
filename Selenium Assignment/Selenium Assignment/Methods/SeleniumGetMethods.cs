using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selenium_Assignment.Log;

namespace Selenium_Assignment.Methods
{
    public static class SeleniumGetMethods
    {        

        public static void VerifyProduct (IWebElement element, string productinfo)
        {

            try
            {
                IList<IWebElement> products = element.FindElements(By.ClassName("inventory_item"));

                foreach (IWebElement product in products)
                {
                    string text = product.Text.Replace("\r", string.Empty);

                    if (text.Contains(productinfo))
                    {
                        Console.WriteLine(String.Format("'{0}' is displayed", productinfo));
                        Logger.logger.Debug(String.Format("{0} is displayed", productinfo));
                        return;
                    }
                    
                }
                Console.WriteLine(String.Format("'{0}' does not exist!", productinfo));
                Logger.logger.Debug(String.Format("{0} does not exist", productinfo));
            }
            catch (Exception e)
            {
                Logger.logger.Error(String.Format("No elements in container"));
                //Print message if no elements in container
                throw new Exception(String.Format("No elements in container!", e.StackTrace));
                
            }
        }

        public static void PageLoaded(string url, string condition)
        {
            try
            {
                //Print message if assert is true
                Assert.IsTrue(url.Contains(condition), condition);
                Console.WriteLine("Correct page loaded!");
                Logger.logger.Debug(String.Format("Correct page loaded! ({0})", url));
            }
            catch (Exception e)
            {
                Logger.logger.Error(String.Format("Wrong page loaded {0}", url));
                //Print message if assert is false
                throw new Exception(String.Format("Wrong page loaded! {0}", e.StackTrace));
            }

        }

        public static string GetValue(IWebElement element)
        {
            return element.GetAttribute("value");

        }

        public static string GetText(IWebElement element)
        {
            return element.Text;

        }

        public static void VerifyText(string text, string condition)
        {
            try
            {
                //Print message if assert is true
                StringAssert.Contains(condition, text, "Verify error message.");
                Console.WriteLine("'{0}' is displayed!", text);
                Logger.logger.Debug(String.Format("{0} is displayed", text));
            }

            catch (Exception e)
            {
                Logger.logger.Error(String.Format("Wrong text is displayed {0}", text));
                //Print message if assert is false
                throw new Exception(String.Format("Wrong text is displayed! {0}", e.StackTrace));
            }
        }

    }
}
