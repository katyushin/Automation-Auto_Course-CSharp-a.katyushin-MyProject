using System;
using Framework_My.Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Framework_My.Pages
{
    public class AddAdress
    {
        public static void Myaccount()
        {
            var wait = new WebDriverWait(Drivers.Driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("My Account"))).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Address"))).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Add new address"))).Click();
        }

        public static Adress Lname(string FirstName)
        {
            return new Adress(FirstName);
        }
        
        public class Adress
        {

            private readonly string FirstName;
            private string LastName;
            private string Strit;
            private string City;
            private string State;
            private string PhoneNumber;
            private string Country;
            private string Postcode;
            
                
            public  Adress(string FirstName)
            {
                this.FirstName = FirstName;
            }

            public Adress WLastName(string LastName)
            {
                this.LastName = LastName;
                return this;
            }

            public Adress WStrit(string Strit)
            {
                this.Strit = Strit;
                return this;
            }

            public Adress WCity(string City)
            {
                this.City = City;
                return this;
            }

            public Adress WState(string State)
            {
                this.State = State;
                return this;
            }

            public Adress WPhone(string PhoneNumber)
            {
                this.PhoneNumber = PhoneNumber;
                return this;
            }

            public Adress WCountry(string Country)
            {
                this.Country = Country;
                return this;
            }

             public Adress WPostcode(string Postcode)
            {
                this.Postcode = Postcode;
                return this;
            }

           

            public void Add()
             {
            
                 var firstname = Drivers.Driver.FindElement(By.Id("CustomerAddress_customer_address_fristname"));
                 var lastname = Drivers.Driver.FindElement(By.Id("CustomerAddress_customer_address_lastname"));
                 var strit = Drivers.Driver.FindElement(By.Id("CustomerAddress_customer_address_street"));
                 var city = Drivers.Driver.FindElement(By.Id("CustomerAddress_customer_address_city"));
                 var state = Drivers.Driver.FindElement(By.Id("CustomerAddress_customer_address_state"));
                 var phone = Drivers.Driver.FindElement(By.Id("CustomerAddress_customer_address_tel"));
                 var country = new SelectElement(Drivers.Driver.FindElement(By.Id("CustomerAddress_customer_address_country")));
                 var code = Drivers.Driver.FindElement(By.Id("CustomerAddress_customer_address_postcode"));
                 var button = Drivers.Driver.FindElement(By.CssSelector("#yw1"));
           
                 firstname.SendKeys(FirstName);
                 lastname.SendKeys(LastName);
                 strit.SendKeys(Strit);
                 city.SendKeys(City);
                 state.SendKeys(State);
                 phone.SendKeys(PhoneNumber);
                 country.SelectByText(Country);
                 code.SendKeys(Postcode);
                 button.Click();
             }

            public void AddAdressConfirmation()
            {

                var firstname = Drivers.Driver.FindElement(By.Name("Shipping[orders_shipping_firstname]"));
                var lastname = Drivers.Driver.FindElement(By.Name("Shipping[orders_shipping_lastname]"));
                var adress = Drivers.Driver.FindElement(By.Name("Shipping[orders_shipping_street]"));
                var city = Drivers.Driver.FindElement(By.Name("Shipping[orders_shipping_city]"));
                var state = Drivers.Driver.FindElement(By.Name("Shipping[orders_shipping_state]"));
                var phone = Drivers.Driver.FindElement(By.Name("Shipping[orders_shipping_tel]"));
                var country = new SelectElement(Drivers.Driver.FindElement(By.Id("selectCountry")));
                var code = Drivers.Driver.FindElement(By.Name("Shipping[orders_shipping_postcode]"));
                var button = Drivers.Driver.FindElement(By.Id("useAddrSaved"));

                firstname.SendKeys(FirstName);
                lastname.SendKeys(LastName);
                adress.SendKeys(Strit);
                city.SendKeys(City);
                state.SendKeys(State);
                phone.SendKeys(PhoneNumber);
                country.SelectByText(Country);
                code.SendKeys(Postcode);
                button.Click();
            }
        }





    }
}
