using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework_My.Pages;
using Framework_My.Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Framework_My.Pages
{
    public class Cycles
    {
        public static void Lang()
        {
            Actions build = new Actions(Drivers.Driver);
            var wait = new WebDriverWait(Drivers.Driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div.r.links")));
            Actions man = build.MoveToElement(Drivers.Driver.FindElement(By.Id("dLang")));
            man.Build().Perform();
            Actions rus = man.MoveToElement(Drivers.Driver.FindElement(By.LinkText("Русский")));
            rus.Click().Perform();
        }

        //------------------------------

        public static LoginCommand FinfOf(string findelement)
        {
            return new LoginCommand(findelement);
        }

        public class LoginCommand
        {
            private string findelement;
          
            public LoginCommand(string findelement)
            {
                this.findelement = findelement;
            }
            public void Find()
            {
                var wait = new WebDriverWait(Drivers.Driver, TimeSpan.FromSeconds(5));
                wait.Until(ExpectedConditions.ElementIsVisible(By.Id("globalSearch")));
                var find = Drivers.Driver.FindElement(By.Id("globalSearch"));
                var loginButton = Drivers.Driver.FindElement(By.LinkText("Search in"));

                find.SendKeys(findelement);
                loginButton.Click();
            }
        }
        //--------------------

        public static void SelectPayment()
        {
           var wait = new WebDriverWait(Drivers.Driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".btn.btn-primary"))).Click();
        }

    }
}










