using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Framework_My.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Framework_My.Pages
{
    public class AssertVariables
    {
        public static string Hello()
        {
           var wait = new WebDriverWait(Drivers.Driver, TimeSpan.FromSeconds(5));
           string welcome = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("welcome"))).Text;
           return welcome;
        }

        public static string SignIn()
        {
            var wait = new WebDriverWait(Drivers.Driver, TimeSpan.FromSeconds(5));
            string signin = wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Sign In"))).Text;
            return signin;
        }
        public static string Language()
        {
            var wait = new WebDriverWait(Drivers.Driver, TimeSpan.FromSeconds(5));
            string lang = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("dLang"))).Text;
            return lang;
        }
        public static bool FindCorrect()
        {
            bool y;
            var wait = new WebDriverWait(Drivers.Driver, TimeSpan.FromSeconds(5));
            bool x01 = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div[class='subCates']"))).Displayed;
            bool x02 = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div[class='alert prodLists']"))).Displayed;
            if (x01 && x02)y = true;
            else y = false;
            return y;
        }

        public static bool FindOutOfStock()
        {
            bool y;
            var wait = new WebDriverWait(Drivers.Driver, TimeSpan.FromSeconds(5));
            bool x01 = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div[class='empty']"))).Displayed;
           if (x01) y = true;
            else y = false;
            return y;
        }

        public static bool CreatedAdress_1()
        {
            var wait = new WebDriverWait(Drivers.Driver, TimeSpan.FromSeconds(10));
            bool add_1 = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".alert.alert-success"))).Displayed;
            return add_1;
        }

        public static bool CreateddAdress_2()
        {
            var wait = new WebDriverWait(Drivers.Driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Address"))).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Add new address")));
            bool add_2 = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".dashboard-list>li"))).Displayed;
            return add_2;
        }

        public static string AssertPayment()
        {
            var wait = new WebDriverWait(Drivers.Driver, TimeSpan.FromSeconds(10));
            string pay = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".right-form>h3"))).Text;
            return pay;
        }
        public static string Visa()
        {
            string visa = null;
            var wait = new WebDriverWait(Drivers.Driver, TimeSpan.FromSeconds(60));
            if (wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("img[seed='icon-iIEcmngPng2014032MwRxDWjrx']"))).Displayed)
            visa = "Visa";
            return visa;
        }

        public static string Master()
        {
            string master = null;
            var wait = new WebDriverWait(Drivers.Driver, TimeSpan.FromSeconds(40));
            if (wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("img[seed='icon-iIEcmngPng2014032MwRwqJ7sz']"))).Displayed)
                master = "Master";
            return master;
        }
    }

}
