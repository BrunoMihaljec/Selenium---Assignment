using OpenQA.Selenium;
using Selenium_Assignment.Web_Driver;
using Selenium_Assignment.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Selenium_Assignment.PageObjects.Saucedemo
{
    static class SaucedemoCartPageObjects
    {

        public static IWebElement buttonMenu  => WebDriver.driver.FindElement(By.Id("react-burger-menu-btn"));

        public static IWebElement textMain  => WebDriver.driver.FindElement(By.XPath("//*[@id='contents_wrapper']/div[2]"));

        public static IWebElement buttonCart => WebDriver.driver.FindElement(By.XPath("//*[@id='shopping_cart_container']"));

        public static IWebElement textQuantity => WebDriver.driver.FindElement(By.XPath("//*[@id='cart_contents_container']/div/div[1]/div[1]"));

        public static IWebElement textDescription => WebDriver.driver.FindElement(By.XPath("//*[@id='cart_contents_container']/div/div[1]/div[2]"));

        public static IWebElement buttonContinue => WebDriver.driver.FindElement(By.XPath("//*[@id='cart_contents_container']/div/div[2]/a[1]"));

        public static IWebElement buttonCheckout => WebDriver.driver.FindElement(By.XPath("//*[@id='cart_contents_container']/div/div[2]/a[2]"));

        public static IWebElement buttonTwitter => WebDriver.driver.FindElement(By.XPath("//*[@id='page_wrapper']/footer/ul/li[1]"));

        public static IWebElement buttonFacebook => WebDriver.driver.FindElement(By.XPath("//*[@id='page_wrapper']/footer/ul/li[2]"));

        public static IWebElement buttonLinkedIn => WebDriver.driver.FindElement(By.XPath("//*[@id='page_wrapper']/footer/ul/li[3]"));

        public static IWebElement textBottom => WebDriver.driver.FindElement(By.XPath("//*[@id='page_wrapper']/footer/div"));

        public static IWebElement buttonX => WebDriver.driver.FindElement(By.XPath("//*[@id='menu_button_container']/div/div[3]/div[2]/div"));

        public static IWebElement buttonAllItems => WebDriver.driver.FindElement(By.XPath("//*[@id='inventory_sidebar_link']"));

        public static IWebElement buttonAbout => WebDriver.driver.FindElement(By.XPath("//*[@id='about_sidebar_link']"));

        public static IWebElement buttonLogout => WebDriver.driver.FindElement(By.XPath("//*[@id='logout_sidebar_link']"));

        public static IWebElement buttonResetAppState => WebDriver.driver.FindElement(By.XPath("//*[@id='reset_sidebar_link']"));



        public static void CartPage()
        {
            SeleniumSetMethods.StepStart("Loads web page (https://www.saucedemo.com/cart.html).", "1");
            SeleniumGetMethods.PageLoaded(WebDriver.driver.Url, "cart");
            Console.WriteLine("Menu button:");
            SeleniumSetMethods.ElementDisplayed(buttonMenu);
            SeleniumSetMethods.ElementEnabled(buttonMenu);
            Console.WriteLine("Cart button:");
            SeleniumSetMethods.ElementDisplayed(buttonCart);
            SeleniumSetMethods.ElementEnabled(buttonCart);
            Console.WriteLine("Main text:");
            string text = SeleniumGetMethods.GetText(textMain);
            SeleniumGetMethods.VerifyText(text, "Your Cart");
            Console.WriteLine("'QTY' text:");
            text = SeleniumGetMethods.GetText(textQuantity);
            SeleniumGetMethods.VerifyText(text, "QTY");
            Console.WriteLine("'DESCRIPTION' text:");
            text = SeleniumGetMethods.GetText(textDescription);
            SeleniumGetMethods.VerifyText(text, "DESCRIPTION");
            Console.WriteLine("'CONTINUE SHOPPING' button:");
            SeleniumSetMethods.ElementDisplayed(buttonContinue);
            SeleniumSetMethods.ElementEnabled(buttonContinue);
            Console.WriteLine("'CHECKOUT' button:");
            SeleniumSetMethods.ElementDisplayed(buttonCheckout);
            SeleniumSetMethods.ElementEnabled(buttonCheckout);
            Console.WriteLine("Twitter button:");
            SeleniumSetMethods.ElementDisplayed(buttonTwitter);
            SeleniumSetMethods.ElementEnabled(buttonTwitter);
            Console.WriteLine("Fcebook button:");
            SeleniumSetMethods.ElementDisplayed(buttonFacebook);
            SeleniumSetMethods.ElementEnabled(buttonFacebook);
            Console.WriteLine("LinkedIn button:");
            SeleniumSetMethods.ElementDisplayed(buttonLinkedIn);
            SeleniumSetMethods.ElementEnabled(buttonLinkedIn);
            text = SeleniumGetMethods.GetText(textBottom);
            SeleniumGetMethods.VerifyText(text, "© 2021 Sauce Labs. All Rights Reserved. Terms of Service | Privacy Policy");

            SeleniumSetMethods.StepStart("Clicks Menu button.", "2");
            SeleniumSetMethods.Clicks(buttonMenu);
            var wait = new WebDriverWait(WebDriver.driver, TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='menu_button_container']/div/div[3]/div[2]/div")));
            Console.WriteLine("Button 'X':");
            SeleniumSetMethods.ElementDisplayed(buttonX);
            SeleniumSetMethods.ElementEnabled(buttonX);
            Console.WriteLine("Button 'All Items':");
            SeleniumSetMethods.ElementDisplayed(buttonAllItems);
            SeleniumSetMethods.ElementEnabled(buttonAllItems);
            Console.WriteLine("Button 'About':");
            SeleniumSetMethods.ElementDisplayed(buttonAbout);
            SeleniumSetMethods.ElementEnabled(buttonAbout);
            Console.WriteLine("Button 'Logout':");
            SeleniumSetMethods.ElementDisplayed(buttonLogout);
            SeleniumSetMethods.ElementEnabled(buttonLogout);
            Console.WriteLine("Button 'Reset App State':");
            SeleniumSetMethods.ElementDisplayed(buttonResetAppState);
            SeleniumSetMethods.ElementEnabled(buttonResetAppState);

        }
    }
}
