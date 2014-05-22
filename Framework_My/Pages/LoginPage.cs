using System;
using Framework_My.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Text.RegularExpressions;

namespace Framework_My.Pages
{

    public class LoginPage
    {
        public static void GoTo()
        {
            Drivers.Driver.Navigate().GoToUrl(Drivers.BaseAddress);
            var wait = new WebDriverWait(Drivers.Driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Sign In"))).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("login-form")));
        }

        public static LoginCommand LoginAs(string userName)
        {
            return new LoginCommand(userName);
        }

        public static void LogOut()
        {
           var wait_Logout = new WebDriverWait(Drivers.Driver, TimeSpan.FromSeconds(5));
            wait_Logout.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Logout"))).Click();
        }

        public class LoginCommand
        {
            private readonly string userName;
            private string password;

            public LoginCommand(string userName)
            {
                this.userName = userName;
            }

            public LoginCommand WithPassword(string password)
            {
                this.password = password;
                return this;
            }

            public void Login()
            {
                var loginInput = Drivers.Driver.FindElement(By.Name("LoginForm[username]"));
                var passwordInput = Drivers.Driver.FindElement(By.Name("LoginForm[password]"));
                var loginButton = Drivers.Driver.FindElement(By.CssSelector("#login-form button"));
                loginInput.SendKeys(userName);
                passwordInput.SendKeys(password);
                loginButton.Click();
               
            }
        }
    }
}