using Framework_My.Selenium;
using Framework_My.Pages;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace TestBuyincoins.Test
{
    [TestFixture]
    public class TestBuyincoins
    {
       
        [Test]
        public void Login() //проверка логирования
        {
            Drivers.Initialize();
            LoginPage.GoTo();
            LoginPage.LoginAs("a1qatest@yandex.ru").WithPassword("qwaszx@1").Login();

            Assert.True(AssertVariables.Hello() == "Hello a1qatest");
            Drivers.Close();
        }

        [Test]
        public void LogOut() //проверка выхода из пользователя
        {
            Drivers.Initialize();
            LoginPage.GoTo();
            LoginPage.LoginAs("a1qatest@yandex.ru").WithPassword("qwaszx@1").Login();

            if (AssertVariables.Hello() == "Hello a1qatest");
            {
                LoginPage.LogOut();
            }
            Assert.True(AssertVariables.SignIn() == "Sign In");
            Drivers.Close();
        }

        [Test]
        public void ChangeLanguage() //проверка смены языка
        {
            Drivers.Initialize();
            Drivers.GoTo();
            Cycles.Lang();
            Assert.True(AssertVariables.Language() == "Язык");
            Drivers.Close();
        }

        [Test]
        public void FindCorrect() //проверка поиска (товар в наличии)
        {
            Drivers.Initialize();
            Drivers.GoTo();
            Cycles.FinfOf("Green laser").Find();
            Assert.True(AssertVariables.FindCorrect());
            Drivers.Close();
        }

        [Test]
        public void FindOutOfStock() //проверка поиска (товар отсутствует)
        {
            Drivers.Initialize();
            Drivers.GoTo();
            Cycles.FinfOf("qw@111").Find();
            Assert.True(AssertVariables.FindOutOfStock());
            Drivers.Close();
        }

        [Test]
        public void QuantityAddToCard() //проверка добавился ли товар в корзину
        {
            Drivers.Initialize();
            Drivers.GoTo();
            Orders.SelectProduct();
            Orders.Quantity();
            Assert.True(Orders.ValueOrders());
            Assert.IsTrue(Orders.GoToCard());
            Drivers.Close();
        }

        [Test]
        public void DeleteOderFromCard() //проверка удаления товара из корзины
        {
            Drivers.Initialize();
            Drivers.GoTo();
            Orders.SelectProduct();
            Orders.Quantity();
            Orders.ValueOrders();
            Orders.GoToCard();
            
            Assert.True(Orders.DeleteOders() == "Your Shopping Cart is Empty.");
            Drivers.Close();
        }

        [Test]
        public void PayPal() //проверка открытия формы оплаты paypal 
        {
            Drivers.Initialize();
            LoginPage.GoTo();
            LoginPage.LoginAs("a1qatest@yandex.ru").WithPassword("qwaszx@1").Login();
            Orders.SelectProduct();
            Orders.Quantity();
            Orders.ValueOrders();
            Orders.GoToCard();
            Assert.IsTrue(Payment.OpenPayPal());
            Drivers.Close();
        }

        [Test]
        public void Adress() //проверка добавления адреса
        {
            Drivers.Initialize();
            LoginPage.GoTo();
            LoginPage.LoginAs("a1qatest@yandex.ru").WithPassword("qwaszx@1").Login();
            AddAdress.Myaccount();
            AddAdress.Lname("Andru").WLastName("Katyuishin").WStrit("Kosmonavtov 10/46").WCity("Mogilev").WState("Belarus").WPhone("123-456-789").WCountry("Russian Federation").WPostcode("12345").Add();
            Assert.IsTrue(AssertVariables.CreatedAdress_1());
            Assert.IsTrue(AssertVariables.CreateddAdress_2());
            Drivers.Close();
        }

        [Test]
        public void UnauthorizedPayment() //проверка появления окна Sign In при оплате товара неавторизированным пользователем
        {
            Drivers.Initialize();
            Drivers.GoTo();
            Orders.SelectProduct();
            Orders.Quantity();
            Orders.ValueOrders();
            Orders.GoToCard();
            Cycles.SelectPayment();
            Assert.IsTrue(AssertVariables.AssertPayment() == "Sign In");
            Drivers.Close();
        }

        [Test]
        public void Visa() //проверка открытия формы оплаты  visa
        {
            Drivers.Initialize();
            LoginPage.GoTo();
            LoginPage.LoginAs("a1qatest@yandex.ru").WithPassword("qwaszx@1").Login();
            Orders.SelectProduct();
            Orders.Quantity();
            Orders.ValueOrders();
            Orders.GoToCard();
            Cycles.SelectPayment();
            Payment.CartConfirmation();
            AddAdress.Lname("Andru").WLastName("Katyuishin").WStrit("Kosmonavtov 10/46").WCity("Mogilev").WState("Belarus").WPhone("123-456-789").WCountry("Russian Federation").WPostcode("12345").AddAdressConfirmation();
            Payment.Visa();

            Assert.True(AssertVariables.Visa() == "Visa");
            Drivers.Close();
        }
        
        [Test]
        public void Master() //проверка открытия формы оплаты  Master
        {
            Drivers.Initialize();
            LoginPage.GoTo();
            LoginPage.LoginAs("a1qatest@yandex.ru").WithPassword("qwaszx@1").Login();
            Orders.SelectProduct();
            Orders.Quantity();
            Orders.ValueOrders();
            Orders.GoToCard();
            Cycles.SelectPayment();
            Payment.CartConfirmation();
            AddAdress.Lname("Andru").WLastName("Katyuishin").WStrit("Kosmonavtov 10/46").WCity("Mogilev").WState("Belarus").WPhone("123-456-789").WCountry("Russian Federation").WPostcode("12345").AddAdressConfirmation();
            Payment.Master();

            Assert.True(AssertVariables.Master() == "Master");
            Drivers.Close();
        }
    }
}
