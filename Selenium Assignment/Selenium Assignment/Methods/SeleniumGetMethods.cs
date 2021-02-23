using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Assignment.Methods
{
    public static class SeleniumGetMethods
    {
        public static void PageLoaded(string url, string condition)
        {
            try
            {
                //Print message if assert is true
                Assert.IsTrue(url.Contains(condition), condition);
                Console.WriteLine("Correct page loaded!");
            }
            catch (Exception e)
            {
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
            }

            catch (Exception e)
            {
                //Print message if assert is false
                throw new Exception(String.Format("Wrong text is displayed! {0}", e.StackTrace));
            }
        }

    }
}
