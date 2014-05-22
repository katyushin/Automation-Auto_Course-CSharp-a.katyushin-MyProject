using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Framework_My.Selenium
{
    public class Drivers
    {
         public static IWebDriver Driver { get; set; }
        public static void Initialize()
        {
            Driver = new FirefoxDriver();
            ICookieJar cookieJar = Driver.Manage().Cookies;
            cookieJar.DeleteAllCookies();
            
            Driver.Manage().Window.Maximize();//Раскрытие веб окна на весь экран
            
            TurnOnWait();
        }

        public static void GoTo()
        {
            Driver.Navigate().GoToUrl(BaseAddress);
        }

        public static void Close()
        {
            Driver.Close();
        }

        public static string BaseAddress 
        {
            get { return "http://www.buyincoins.com"; }
        }

        
        private static void TurnOnWait()
        {
            Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(15));
        }
    }
}

