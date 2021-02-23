using OpenQA.Selenium;
using Selenium_Assignment.Methods;
using Selenium_Assignment.Web_Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Assignment.PageObjects
{
    static class SaucedemoLogInPageObjects
    {

        public static IWebElement textboxUsername => WebDriver.driver.FindElement(By.Name("user-name"));

        public static IWebElement textboxPassword => WebDriver.driver.FindElement(By.Name("password"));

        public static IWebElement buttonLOGIN => WebDriver.driver.FindElement(By.Id("login-button"));

        public static IWebElement textMessage => WebDriver.driver.FindElement(By.XPath("/html/body/div[2]/div[1]/div/div/form/h3"));

        public static IWebElement buttonX => WebDriver.driver.FindElement(By.XPath("//*[@id='login_button_container']/div/form/h3/button"));

        public static IWebElement textUsernames => WebDriver.driver.FindElement(By.XPath("//*[@id='login_credentials']"));

        public static IWebElement textPassword => WebDriver.driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[2]"));


        public static void LogIn(string correctusername, string correctpassword, string incorrectusername, string incorrectpassword)
        {
            try
            {
                SeleniumSetMethods.StepStart("Loads web page (https://www.saucedemo.com/index.html).", "1");
                SeleniumGetMethods.PageLoaded(WebDriver.driver.Url, "index");               
                Console.WriteLine("Text box 'Username':");
                SeleniumSetMethods.ElementDisplayed(textboxUsername);
                SeleniumSetMethods.ElementEnabled(textboxUsername);
                SeleniumSetMethods.ElementEmpty(textboxUsername);
                Console.WriteLine("Text box 'Password':");
                SeleniumSetMethods.ElementDisplayed(textboxPassword);
                SeleniumSetMethods.ElementEnabled(textboxPassword);
                SeleniumSetMethods.ElementEmpty(textboxPassword);
                Console.WriteLine("Button 'LOGIN':");
                SeleniumSetMethods.ElementDisplayed(buttonLOGIN);
                SeleniumSetMethods.ElementEnabled(buttonLOGIN);


                string Usernames = SeleniumGetMethods.GetText(textUsernames).Replace("\r", string.Empty);
                SeleniumGetMethods.VerifyText(Usernames, "Accepted usernames are:\nstandard_user\nlocked_out_user\nproblem_user\nperformance_glitch_user");
                
                
                string Password = SeleniumGetMethods.GetText(textPassword).Replace("\r", string.Empty);
                SeleniumGetMethods.VerifyText(Password, "Password for all users:\nsecret_sauce");

                SeleniumSetMethods.StepStart("Submits button 'LOGIN'.", "2");
                SeleniumSetMethods.Submits(buttonLOGIN);
                Console.WriteLine("Button 'X':");
                SeleniumSetMethods.ElementDisplayed(buttonX);
                SeleniumSetMethods.ElementEnabled(buttonX);
                string message = SeleniumGetMethods.GetText(textMessage);
                SeleniumGetMethods.VerifyText(message, "Epic sadface: Username is required");

                SeleniumSetMethods.StepStart("Enters incorrect password.", "3");
                SeleniumSetMethods.EnterText(textboxPassword, incorrectpassword);
                string enteredtext = SeleniumGetMethods.GetValue(textboxPassword);
                SeleniumGetMethods.VerifyText(enteredtext, incorrectpassword);

                SeleniumSetMethods.StepStart("Submits button 'LOGIN'.", "4");
                SeleniumSetMethods.Submits(buttonLOGIN);
                Console.WriteLine("Button 'X':");
                SeleniumSetMethods.ElementDisplayed(buttonX);
                SeleniumSetMethods.ElementEnabled(buttonX);
                message = SeleniumGetMethods.GetText(textMessage);
                SeleniumGetMethods.VerifyText(message, "Epic sadface: Username is required");

                SeleniumSetMethods.StepStart("Clears 'Password' textbox.", "5");
                SeleniumSetMethods.Clears(textboxPassword);
                SeleniumSetMethods.ElementEmpty(textboxPassword);
                
                SeleniumSetMethods.StepStart("Enters incorrect username.", "6");
                SeleniumSetMethods.EnterText(textboxUsername, incorrectusername);
                enteredtext = SeleniumGetMethods.GetValue(textboxUsername);
                SeleniumGetMethods.VerifyText(enteredtext, incorrectusername);

                SeleniumSetMethods.StepStart("Submits button 'LOGIN'.", "7");
                SeleniumSetMethods.Submits(buttonLOGIN);
                Console.WriteLine("Button 'X':");
                SeleniumSetMethods.ElementDisplayed(buttonX);
                SeleniumSetMethods.ElementEnabled(buttonX);
                message = SeleniumGetMethods.GetText(textMessage);
                SeleniumGetMethods.VerifyText(message, "Epic sadface: Password is required");

                SeleniumSetMethods.StepStart("Clears 'Username' textbox.", "8");
                SeleniumSetMethods.Clears(textboxUsername);
                SeleniumSetMethods.ElementEmpty(textboxUsername);

                SeleniumSetMethods.StepStart("Enters incorrect username and password.", "9");
                SeleniumSetMethods.EnterText(textboxUsername, incorrectusername);
                SeleniumSetMethods.EnterText(textboxPassword, incorrectpassword);
                enteredtext = SeleniumGetMethods.GetValue(textboxUsername);
                SeleniumGetMethods.VerifyText(enteredtext, incorrectusername);
                enteredtext = SeleniumGetMethods.GetValue(textboxPassword);
                SeleniumGetMethods.VerifyText(enteredtext, incorrectpassword);

                SeleniumSetMethods.StepStart("Submits button 'LOGIN'.", "10");
                SeleniumSetMethods.Submits(buttonLOGIN);
                Console.WriteLine("Button 'X':");
                SeleniumSetMethods.ElementDisplayed(buttonX);
                SeleniumSetMethods.ElementEnabled(buttonX);
                message = SeleniumGetMethods.GetText(textMessage);
                SeleniumGetMethods.VerifyText(message, "Epic sadface: Username and password do not match any user in this service");

                SeleniumSetMethods.StepStart("Clears 'Username' and ‘Password’ textboxes.", "11");
                SeleniumSetMethods.Clears(textboxUsername);
                SeleniumSetMethods.Clears(textboxPassword);
                SeleniumSetMethods.ElementEmpty(textboxUsername);
                SeleniumSetMethods.ElementEmpty(textboxPassword);

                SeleniumSetMethods.StepStart("Enters incorrect username and correct password.", "12");
                SeleniumSetMethods.EnterText(textboxUsername, incorrectusername);
                SeleniumSetMethods.EnterText(textboxPassword, correctpassword);
                enteredtext = SeleniumGetMethods.GetValue(textboxUsername);
                SeleniumGetMethods.VerifyText(enteredtext, incorrectusername);
                enteredtext = SeleniumGetMethods.GetValue(textboxPassword);
                SeleniumGetMethods.VerifyText(enteredtext, correctpassword);

                SeleniumSetMethods.StepStart("Submits button 'LOGIN'.", "13");
                SeleniumSetMethods.Submits(buttonLOGIN);
                Console.WriteLine("Button 'X':");
                SeleniumSetMethods.ElementDisplayed(buttonX);
                SeleniumSetMethods.ElementEnabled(buttonX);
                message = SeleniumGetMethods.GetText(textMessage);
                SeleniumGetMethods.VerifyText(message, "Epic sadface: Username and password do not match any user in this service");

                SeleniumSetMethods.StepStart("Clears 'Username' and 'Password' textboxes.", "14");
                SeleniumSetMethods.Clears(textboxUsername);
                SeleniumSetMethods.Clears(textboxPassword);
                SeleniumSetMethods.ElementEmpty(textboxUsername);
                SeleniumSetMethods.ElementEmpty(textboxPassword);

                SeleniumSetMethods.StepStart("Enters correct username and incorrect password.", "15");
                SeleniumSetMethods.EnterText(textboxUsername, correctusername);
                SeleniumSetMethods.EnterText(textboxPassword, incorrectpassword);
                enteredtext = SeleniumGetMethods.GetValue(textboxUsername);
                SeleniumGetMethods.VerifyText(enteredtext, correctusername);
                enteredtext = SeleniumGetMethods.GetValue(textboxPassword);
                SeleniumGetMethods.VerifyText(enteredtext, incorrectpassword);

                SeleniumSetMethods.StepStart("Submits button 'LOGIN'.", "16");
                SeleniumSetMethods.Submits(buttonLOGIN);
                Console.WriteLine("Button 'X':");
                SeleniumSetMethods.ElementDisplayed(buttonX);
                SeleniumSetMethods.ElementEnabled(buttonX);
                message = SeleniumGetMethods.GetText(textMessage);
                SeleniumGetMethods.VerifyText(message, "Epic sadface: Username and password do not match any user in this service");

                SeleniumSetMethods.StepStart("Clears 'Username' and 'Password' textboxes.", "17");
                SeleniumSetMethods.Clears(textboxUsername);
                SeleniumSetMethods.Clears(textboxPassword);
                SeleniumSetMethods.ElementEmpty(textboxUsername);
                SeleniumSetMethods.ElementEmpty(textboxPassword);

                SeleniumSetMethods.StepStart("Enters correct username and correct password.", "18");
                SeleniumSetMethods.EnterText(textboxUsername, correctusername);
                SeleniumSetMethods.EnterText(textboxPassword, correctpassword);
                enteredtext = SeleniumGetMethods.GetValue(textboxUsername);
                SeleniumGetMethods.VerifyText(enteredtext, correctusername);
                enteredtext = SeleniumGetMethods.GetValue(textboxPassword);
                SeleniumGetMethods.VerifyText(enteredtext, correctpassword);

                SeleniumSetMethods.StepStart("Submits button 'LOGIN'.", "19");
                SeleniumSetMethods.Submits(buttonLOGIN);
                string urlInventory = WebDriver.driver.Url;
                SeleniumSetMethods.WaitForPageToLoad(WebDriver.driver, 35);
                SeleniumGetMethods.PageLoaded(urlInventory, "inventory");
                Console.WriteLine("Login successful!");

            }
            catch (Exception e)
            {
                Console.WriteLine("Login failed: {0}", e);
            }
        }
    }
}
