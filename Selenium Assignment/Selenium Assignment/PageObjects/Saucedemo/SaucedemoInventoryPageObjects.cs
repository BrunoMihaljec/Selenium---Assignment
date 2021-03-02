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
    static class SaucedemoInventoryPageObjects
    {
        
        public static IWebElement buttonMenu => WebDriver.driver.FindElement(By.Id("react-burger-menu-btn"));

        public static IWebElement buttonCart => WebDriver.driver.FindElement(By.XPath("//*[@id='shopping_cart_container']"));

        public static IWebElement textMain => WebDriver.driver.FindElement(By.XPath("//*[@id='inventory_filter_container']/div"));

        public static IWebElement dropdownFilter => WebDriver.driver.FindElement(By.XPath("//*[@id='inventory_filter_container']/select"));

        public static IWebElement productcontainer => WebDriver.driver.FindElement(By.XPath("//*[@id='inventory_container']/div"));

        public static IWebElement textbottom => WebDriver.driver.FindElement(By.XPath("//*[@id='page_wrapper']/footer/div"));

        public static IWebElement buttonX => WebDriver.driver.FindElement(By.Id("react-burger-cross-btn"));

        public static IWebElement buttonAllitems => WebDriver.driver.FindElement(By.XPath("//*[@id='inventory_sidebar_link']"));

        public static IWebElement buttonAbout => WebDriver.driver.FindElement(By.XPath("//*[@id='about_sidebar_link']"));

        public static IWebElement buttonLogout => WebDriver.driver.FindElement(By.XPath("//*[@id='logout_sidebar_link']"));

        public static IWebElement buttonResetappstate => WebDriver.driver.FindElement(By.XPath("//*[@id='reset_sidebar_link']"));

        public static IWebElement buttonTwitter => WebDriver.driver.FindElement(By.XPath("//*[@id='page_wrapper']/footer/ul/li[1]"));

        public static IWebElement buttonFacebook => WebDriver.driver.FindElement(By.XPath("//*[@id='page_wrapper']/footer/ul/li[2]"));
    
        public static IWebElement buttonLinkedIn => WebDriver.driver.FindElement(By.XPath("//*[@id='page_wrapper']/footer/ul/li[3]"));

        public static IWebElement buttonaddtocart => WebDriver.driver.FindElement(By.XPath("//*[@id='inventory_container']/div/div[1]/div[3]/button"));

        //public static IWebElement buttonRemove => WebDriver.driver.FindElement(By.XPath("//*[@id="inventory_container"]/div/div[1]/div[3]/button"));

        public static IWebElement textCart => WebDriver.driver.FindElement(By.XPath("//*[@id='shopping_cart_container']/a/span"));

        public static void InventoryPage()
        {
            try
            {             
                SeleniumSetMethods.StepStart("Loads web page (https://www.saucedemo.com/inventory.html).", "1");
                SeleniumGetMethods.PageLoaded(WebDriver.driver.Url, "inventory");
                Console.WriteLine("Menu button:");
                SeleniumSetMethods.ElementDisplayed(buttonMenu);
                SeleniumSetMethods.ElementEnabled(buttonMenu);
                Console.WriteLine("Cart button:");
                SeleniumSetMethods.ElementDisplayed(buttonCart);
                SeleniumSetMethods.ElementEnabled(buttonCart);
                Console.WriteLine("Main text:");
                string text = SeleniumGetMethods.GetText(textMain);
                SeleniumGetMethods.VerifyText(text, "Products");
                Console.WriteLine("DropDown menu:");
                SeleniumSetMethods.ElementDisplayed(dropdownFilter);
                SeleniumSetMethods.ElementEnabled(dropdownFilter);
                Console.WriteLine("Product List:");        
                SeleniumGetMethods.VerifyProduct(productcontainer, "Sauce Labs Backpack\ncarry.allTheThings() with the sleek, streamlined Sly Pack that melds uncompromising style with unequaled laptop and tablet protection.\n$29.99\nADD TO CART");
                SeleniumGetMethods.VerifyProduct(productcontainer, "Sauce Labs Bike Light\nA red light isn't the desired state in testing but it sure helps when riding your bike at night. Water-resistant with 3 lighting modes, 1 AAA battery included.\n$9.99\nADD TO CART");
                SeleniumGetMethods.VerifyProduct(productcontainer, "Sauce Labs Bolt T-Shirt\nGet your testing superhero on with the Sauce Labs bolt T-shirt. From American Apparel, 100% ringspun combed cotton, heather gray with red bolt.\n$15.99\nADD TO CART");
                SeleniumGetMethods.VerifyProduct(productcontainer, "Sauce Labs Fleece Jacket\nIt's not every day that you come across a midweight quarter-zip fleece jacket capable of handling everything from a relaxing day outdoors to a busy day at the office.\n$49.99\nADD TO CART");
                SeleniumGetMethods.VerifyProduct(productcontainer, "Sauce Labs Onesie\nRib snap infant onesie for the junior automation engineer in development. Reinforced 3-snap bottom closure, two-needle hemmed sleeved and bottom won't unravel.\n$7.99\nADD TO CART");
                SeleniumGetMethods.VerifyProduct(productcontainer, "Test.allTheThings() T-Shirt (Red)\nThis classic Sauce Labs t-shirt is perfect to wear when cozying up to your keyboard to automate a few tests. Super-soft and comfy ringspun combed cotton.\n$15.99\nADD TO CART");
                Console.WriteLine("Twitter button:");
                SeleniumSetMethods.ElementDisplayed(buttonTwitter);
                SeleniumSetMethods.ElementEnabled(buttonTwitter);
                Console.WriteLine("Fcebook button:");
                SeleniumSetMethods.ElementDisplayed(buttonFacebook);
                SeleniumSetMethods.ElementEnabled(buttonFacebook);
                Console.WriteLine("LinkedIn button:");
                SeleniumSetMethods.ElementDisplayed(buttonLinkedIn);
                SeleniumSetMethods.ElementEnabled(buttonLinkedIn);
                text = SeleniumGetMethods.GetText(textbottom);
                SeleniumGetMethods.VerifyText(text, "© 2021 Sauce Labs. All Rights Reserved. Terms of Service | Privacy Policy");

                SeleniumSetMethods.StepStart("Clicks Dropdown Menu.", "2");
                SeleniumSetMethods.Clicks(dropdownFilter);
                text = SeleniumGetMethods.GetText(dropdownFilter).Replace("\r", string.Empty);
                SeleniumGetMethods.VerifyText(text, "Name (A to Z)\nName (Z to A)\nPrice (low to high)\nPrice (high to low)");

                SeleniumSetMethods.StepStart("Clicks Menu button.", "3");
                SeleniumSetMethods.Clicks(buttonMenu);
                var wait = new WebDriverWait(WebDriver.driver, TimeSpan.FromSeconds(2));
                wait.Until(ExpectedConditions.ElementIsVisible(By.Id("react-burger-cross-btn")));

                Console.WriteLine("Button 'X':");
                SeleniumSetMethods.ElementDisplayed(buttonX);
                SeleniumSetMethods.ElementEnabled(buttonX);
                Console.WriteLine("Button 'All Items':");
                SeleniumSetMethods.ElementDisplayed(buttonAllitems);
                SeleniumSetMethods.ElementEnabled(buttonAllitems);
                Console.WriteLine("Button 'About':");
                SeleniumSetMethods.ElementDisplayed(buttonAbout);
                SeleniumSetMethods.ElementEnabled(buttonAbout);
                Console.WriteLine("Button 'Logout':");
                SeleniumSetMethods.ElementDisplayed(buttonLogout);
                SeleniumSetMethods.ElementEnabled(buttonLogout);
                Console.WriteLine("Button 'Reset App State':");
                SeleniumSetMethods.ElementDisplayed(buttonResetappstate);
                SeleniumSetMethods.ElementEnabled(buttonResetappstate);

                SeleniumSetMethods.StepStart("Clicks button 'X'.", "4");
                SeleniumSetMethods.Clicks(buttonX);
                wait = new WebDriverWait(WebDriver.driver, TimeSpan.FromSeconds(2));
                wait.Until(ExpectedConditions.ElementIsVisible(By.Id("react-burger-menu-btn")));
                SeleniumSetMethods.ElementHidden(buttonX);

                SeleniumSetMethods.StepStart("Clicks Sauce Labs Backpack 'ADD TO CART' button.", "5");
                SeleniumSetMethods.Clicks(buttonaddtocart);
                text = SeleniumGetMethods.GetText(buttonaddtocart);
                SeleniumGetMethods.VerifyText(text, "REMOVE");
                Console.WriteLine("'REMOVE' button:");
                text = SeleniumGetMethods.GetText(textCart);
                Console.WriteLine("Cart button:");
                SeleniumGetMethods.VerifyText(text, "1");

                SeleniumSetMethods.StepStart("Clicks Cart button.", "6");
                wait = new WebDriverWait(WebDriver.driver, TimeSpan.FromSeconds(2));
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='shopping_cart_container']")));
                SeleniumSetMethods.Clicks(buttonCart);
                SeleniumSetMethods.WaitForPageToLoad(WebDriver.driver, 35);
                SeleniumGetMethods.PageLoaded(WebDriver.driver.Url, "cart");

            }

            catch(Exception e)          
            {
                throw new Exception(String.Format("Test failed! {0}", e.Message));
            }
        
        }
    }
}
