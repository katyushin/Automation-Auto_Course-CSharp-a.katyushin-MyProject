using System;
using System.Threading;
using Framework_My.Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using Assert = NUnit.Framework.Assert;

namespace Framework_My.Pages
{
    public  class Orders
    {
        //________________________________Выбор выпадающего меню товара_____________________________
        public static void SelectProduct()
        { 
            var wait = new WebDriverWait(Drivers.Driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Electronics")));
           
            Actions build = new Actions(Drivers.Driver);
            Actions goods = build.MoveToElement(Drivers.Driver.FindElement(By.LinkText("Electronics")));
            goods.Build().Perform();
            Actions el = goods.MoveToElement(Drivers.Driver.FindElement(By.LinkText("Laser Pointers")));
            el.Click().Perform();
            
            //________________________________Выбор выбор N-го товара_____________________________
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("li:nth-of-type(1) p.p-img")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("li:nth-of-type(1) p.p-img>a>img"))).Click();

            //PopupWindowFinder finder = new PopupWindowFinder(Drivers.Driver);
            //Console.WriteLine(finder);
            //string newHandle = finder.Click(Drivers.Driver.FindElement(By.CssSelector("li:nth-of-type(1) p.p-title>a")));//ссылка которая открывает новое окно
            //Assert.IsNotNullOrEmpty(newHandle);
            //Console.WriteLine(newHandle);
            //Drivers.Driver.SwitchTo().Window(newHandle);// работа с новым окном


        }

        public static void Quantity()
        {
        //________________________________Выбор кол-ва товара_____________________________
        var wait = new WebDriverWait(Drivers.Driver, TimeSpan.FromSeconds(10));
        wait.Until(ExpectedConditions.ElementIsVisible(By.Id("quantity"))).SendKeys("\b10");
        wait.Until(ExpectedConditions.ElementIsVisible(By.Id("addToCart"))).Click();
            Drivers.Driver.FindElement(By.Id("addToCart")).Click();
        }

        public static bool ValueOrders()
        {
            bool value;
            Thread.Sleep(1000);  
            var wait = new WebDriverWait(Drivers.Driver, TimeSpan.FromSeconds(10));
            string text = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[@id='headerShoppingCart']/span"))).Text;
                //Drivers.Driver.FindElement(By.XPath("//a[@id='headerShoppingCart']/span")).Text;
                int xxx = Convert.ToInt32(text);
                //.GetCssValue("//a[@id='headerShoppingCart']/span");
            if (xxx > 0 && xxx != 0) value = true;
            else value = false;  
            return value;
        }

        public static bool GoToCard()
        {
            var wait = new WebDriverWait(Drivers.Driver, TimeSpan.FromSeconds(40));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("headerShoppingCart"))).Click();
            bool goods = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".row.rounded.productLists"))).Displayed;
            return goods;
        }

        public static string DeleteOders()
        {
            var wait = new WebDriverWait(Drivers.Driver, TimeSpan.FromSeconds(10));
            //wait.Until(ExpectedConditions.ElementIsVisible(By.Id("batchRemove"))).Click();
            Drivers.Driver.FindElement(By.Id("batchRemove")).Click();
            Drivers.Driver.FindElement(By.Id("batchRemoveAct")).Click();
            string del = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".empty>h2"))).Text;
            return del;
        }

        public static bool PayPal()
        {
            Drivers.Driver.FindElement(By.Id("batchRemove")).Click();
            var wait = new WebDriverWait(Drivers.Driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("a[class='btn btn-warning ex ru']"))).Click();
            bool paypal = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("billingBox"))).Displayed;
            return paypal;
        }
    }
}
