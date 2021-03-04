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
using System.Threading;

namespace Selenium_Assignment.PageObjects.Saucedemo
{
    public static class SaucedemoCartPageObjects
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

        public static IWebElement cartproductcontainer => WebDriver.driver.FindElement(By.XPath("//*[@id='cart_contents_container']/div/div[1]/div[3]"));

        public static IWebElement textcart => WebDriver.driver.FindElement(By.XPath("//*[@id='shopping_cart_container']/a/span"));

        

        public static void CartPage()
        {
            SeleniumSetMethods.StepStart("Loads web page (https://www.saucedemo.com/cart.html).", "1");
            SeleniumGetMethods.PageLoaded(WebDriver.driver.Url, "cart");
            Console.WriteLine("Menu button:");
            SeleniumSetMethods.ElementDisplayedAndEnabled(buttonMenu);
            Console.WriteLine("Cart button:");
            SeleniumSetMethods.ElementDisplayedAndEnabled(buttonCart);
            string text = SeleniumGetMethods.GetText(textcart);
            SeleniumGetMethods.VerifyText(text, "1");
            Console.WriteLine("Main text:");
            text = SeleniumGetMethods.GetText(textMain);
            SeleniumGetMethods.VerifyText(text, "Your Cart");
            Console.WriteLine("'QTY' text:");
            text = SeleniumGetMethods.GetText(textQuantity);
            SeleniumGetMethods.VerifyText(text, "QTY");
            Console.WriteLine("'DESCRIPTION' text:");
            text = SeleniumGetMethods.GetText(textDescription);
            SeleniumGetMethods.VerifyText(text, "DESCRIPTION");
            SeleniumGetMethods.VerifyProduct(cartproductcontainer, "1\nSauce Labs Backpack\ncarry.allTheThings() with the sleek, streamlined Sly Pack that melds uncompromising style with unequaled laptop and tablet protection.\n29.99REMOVE");
            Console.WriteLine("'CONTINUE SHOPPING' button:");
            SeleniumSetMethods.ElementDisplayedAndEnabled(buttonContinue);
            Console.WriteLine("'CHECKOUT' button:");
            SeleniumSetMethods.ElementDisplayedAndEnabled(buttonCheckout);
            Console.WriteLine("Twitter button:");
            SeleniumSetMethods.ElementDisplayedAndEnabled(buttonTwitter);
            Console.WriteLine("Fcebook button:");
            SeleniumSetMethods.ElementDisplayedAndEnabled(buttonFacebook);
            Console.WriteLine("LinkedIn button:");
            SeleniumSetMethods.ElementDisplayedAndEnabled(buttonLinkedIn);
            text = SeleniumGetMethods.GetText(textBottom);
            SeleniumGetMethods.VerifyText(text, "© 2021 Sauce Labs. All Rights Reserved. Terms of Service | Privacy Policy");

            SeleniumSetMethods.StepStart("Clicks Menu button.", "2");
            SeleniumSetMethods.Clicks(buttonMenu);
            var wait = new WebDriverWait(WebDriver.driver, TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='menu_button_container']/div/div[3]/div[2]/div")));
            Console.WriteLine("Button 'X':");
            SeleniumSetMethods.ElementDisplayedAndEnabled(buttonX);
            Console.WriteLine("Button 'All Items':");
            SeleniumSetMethods.ElementDisplayedAndEnabled(buttonAllItems);
            Console.WriteLine("Button 'About':");
            SeleniumSetMethods.ElementDisplayedAndEnabled(buttonAbout);
            Console.WriteLine("Button 'Logout':");
            SeleniumSetMethods.ElementDisplayedAndEnabled(buttonLogout);
            Console.WriteLine("Button 'Reset App State':");
            SeleniumSetMethods.ElementDisplayedAndEnabled(buttonResetAppState);

            SeleniumSetMethods.StepStart("Clicks button 'X' ", "3");
            SeleniumSetMethods.Clicks(buttonX);
            Thread.Sleep(2000);
            SeleniumSetMethods.ElementHidden(buttonX);

            SeleniumSetMethods.StepStart("Clicks 'CHECKOUT' button.", "4");
            SeleniumSetMethods.Clicks(buttonCheckout);
            SeleniumSetMethods.WaitForPageToLoad(WebDriver.driver, 35);
            SeleniumGetMethods.PageLoaded(WebDriver.driver.Url, "checkout-step-one");

        }
    }
}
