using System;
using System.Configuration;
using Framework_My.Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Framework_My.Pages
{
    public class Payment
    {

        public static bool OpenPayPal()
            {
                var wait = new WebDriverWait(Drivers.Driver, TimeSpan.FromSeconds(5));
                wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("a[class='btn btn-warning ex en']"))).Click();
                bool openpaypal = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("billingBox"))).Displayed;
                return openpaypal;
             }

        public static void CartConfirmation()
            {
                var wait = new WebDriverWait(Drivers.Driver, TimeSpan.FromSeconds(5));
                wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".rounded.addNew"))).Click();
                wait.Until(ExpectedConditions.ElementIsVisible(By.Id("useAddrSaved")));
             }

        public static void Visa()
        {
            var wait = new WebDriverWait(Drivers.Driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("input[value='visa']"))).Click();
            Drivers.Driver.FindElement(By.CssSelector("input[value='Confirm Order']")).Click();
        }

        public static void Master()
        {
            var wait = new WebDriverWait(Drivers.Driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("input[value='master']"))).Click();
            Drivers.Driver.FindElement(By.CssSelector("input[value='Confirm Order']")).Click();
        }
        
        public class Paypal
        {
            private readonly int CardNumber;
            private int ExpirationDateMM;
            private int ExpirationDateYY;
            private int CSS;
            private string FirstName;
            private string LastName;
            private string AddressLine;
            private string City;
            private int ZIPCode;
            private int PhoneNumber;
            private string Email;
            private string Password;
            private string ReEnterPassword;
                
            public Paypal(int CardNumber)
            {
                this.CardNumber = CardNumber;
            }

            public Paypal WExpirationDateMM(int ExpirationDateMM)
            {
                this.ExpirationDateMM = ExpirationDateMM;
                return this;
            }

            public Paypal WExpirationDateYY(int ExpirationDateYY)
            {
                this.ExpirationDateYY = ExpirationDateYY;
                return this;
            }

            public Paypal Wcss(int CSS)
            {
                this.CSS = CSS;
                return this;
            }

            public Paypal WFirstName(string FirstName)
            {
                this.FirstName = FirstName;
                return this;
            }

            public Paypal WLastName(string LastName)
            {
                this.LastName = LastName;
                return this;
            }
            
            public Paypal WAddressLine(string AddressLine)
            {
                this.AddressLine = AddressLine;
                return this;
            }

            public Paypal WCity(string City)
            {
                this.City = City;
                return this;
            }

            public Paypal WzipCode(int ZIPCode)
            {
                this.ZIPCode = ZIPCode;
                return this;
            }

            public Paypal WPhone(int PhoneNumber)
            {
                this.PhoneNumber = PhoneNumber;
                return this;
            }

            public Paypal WEmail(string Email)
            {
                this.Email = Email;
                return this;
            }


            public Paypal WPassword(string Password)
            {
                this.Password = Password;
                return this;
            }

            public Paypal WReEnterPassword(string ReEnterPassword)
            {
                this.ReEnterPassword = ReEnterPassword;
                return this;
            }

            

            //public void Pay()
            //{

            //    //wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("a[class='btn btn-warning ex ru']"))).Click();
            //    //wait.Until(ExpectedConditions.ElementIsVisible(By.Id("billingBox")));//Ждать пока не откроется окно звполнентя PayPal данных

            //    //var country = new SelectElement(driver.FindElement(By.Id("country_code")));//Выбор страны
            //    //country.SelectByText("United States");
            //    //driver.FindElementById("cc_number").SendKeys("5105105105105100");
            //    //driver.FindElementById("expdate_month").SendKeys("12");
            //    //driver.FindElementById("expdate_year").SendKeys("15");
            //    //driver.FindElementById("cvv2_number").SendKeys("123");
            //    //driver.FindElementById("first_name").SendKeys("Andrei");
            //    //driver.FindElementById("last_name").SendKeys("Katyuishin");
            //    //driver.FindElementById("address1").SendKeys("st.Kosmonavtov");
            //    //driver.FindElementById("address2").SendKeys("obl.Mogilevskaya");
            //    //driver.FindElementById("city").SendKeys("Mogilev");

            //    //var state = new SelectElement(driver.FindElement(By.Id("state")));//Выбор штата
            //    //state.SelectByText("AE");

            //    //driver.FindElementById("zip").SendKeys("212022");

            //    //var phone = new SelectElement(driver.FindElement(By.Id("tel_type")));//Выбор типа телефона
            //    //phone.SelectByText("Home");

            //    //driver.FindElementById("H_PhoneNumberUS").SendKeys("555-555-1234");
            //    //driver.FindElementById("email-address").SendKeys("belkatan@yandex.ru");
            //    //driver.FindElementById("password").SendKeys("123456789");
            //    //driver.FindElementById("password-confirm").SendKeys("123456789");
            //    //driver.FindElementById("econsent").Click();
                
                
                
                
                
                
                
                
                
                
                
            //    //var loginInput = Drivers.Driver.FindElement(By.Name("LoginForm[username]"));
            //    //var passwordInput = Drivers.Driver.FindElement(By.Name("LoginForm[password]"));
            //    //var loginButton = Drivers.Driver.FindElement(By.CssSelector("#login-form button"));
               
                
            //    //loginInput.SendKeys(userName);
            //    //passwordInput.SendKeys(password);
            //    //loginButton.Click();

            //}
        }

    }
}
