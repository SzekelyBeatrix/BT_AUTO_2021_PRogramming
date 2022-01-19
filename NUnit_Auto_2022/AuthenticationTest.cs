using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace NUnit_Auto_2022
{
    class AuthenticationTest
    {
        IWebDriver driver;

        const string protocol = "http";
        const string hostname = "86.121.249.150";
        const string port = "4999";
        const string path = "/#/";

        string url = protocol + "://" + hostname + ":" + port + path;

        [SetUp]

        public void SetUp()
        {
            driver = new ChromeDriver();
        }
        [TestCase("dinosaur", "dinosaurpassword","","")]
        [TestCase("dinosaur","", "","Password is requierd!")]
        [TestCase("", "", "Username is requierd", "Password is requierd!")]
        [TestCase("", "dinopass", "Username is requierd!", "")]
        public void Test01(string user, string pass, string userErr, string passErr)
        {

            Console.WriteLine(url);
            driver.Navigate().GoToUrl(url);

            var pageText = driver.FindElement(By.CssSelector("#root > div > div.content > div > div:nth-child(1) > div > div > h1 > small"));
            Assert.AreEqual("Home", pageText.Text);

            var loginLink = driver.FindElement(By.CssSelector("#root > div > div.sidebar > a:nth-child(2)"));
            loginLink.Click();
            Console.WriteLine(loginLink.GetAttribute("href"));

            pageText = driver.FindElement(By.CssSelector("#root > div > div.content > div > div:nth-child(1) > div > div > h1 > small"));
            Assert.AreEqual("Authentication", pageText.Text);

            var username = driver.FindElement(By.Id("input-login-username"));
            var password = driver.FindElement(By.Id("input-login-password"));
            var submit = driver.FindElement(By.CssSelector("#login-form > div:nth-child(3) > div.text-left.col-lg > button"));

            var usernameError = driver.FindElement(By.CssSelector("#login-form > div:nth-child(1) > div > div > div.text-left.invalid-feedback"));
            var passwordError = driver.FindElement(By.CssSelector("#login-form > div.form-group.row.row-cols-lg-true > div > div > div.text-left.invalid-feedback"));



            username.Clear();
            username.SendKeys(user);

            password.Clear();
            password.SendKeys(pass);

            submit.Submit();

            Assert.AreEqual(userErr, usernameError.Text);
            Assert.AreEqual(passErr, passwordError.Text);
        }
        [Test]

        public void Test02()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            string url = protocol + "://" + hostname + ":8081/lazy.html";
            driver.Navigate().GoToUrl(url);

            var button1 = driver.FindElement(By.Id("btn1"));
            button1.Click();
        }

        //Waituri Implicit= instant/timeout si Explecit= asteapta un moment exact, cat are nevoie - recomandat sa fie utilizat
        //nu pune ambele, alege unul dintre waituri
        //Implicint vf toate elementele din pagina, Explicit= un element ex Terms and conditions
        
        //explicit wait test - la nivelul elemntului
        [Test]
        public void Test03()
        {
            string url = protocol + "://" + hostname + ":8081/lazy.html";
            driver.Navigate().GoToUrl(url);

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            //var button1 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("btn1")));
            var button1 = Utils.WaitForElement(driver, 20, By.Id("btn1"));
            button1.Click();
        }
        [Test]
        public void Test04()
        {
            string url = protocol + "://" + hostname + ":8081/lazy.html";
            driver.Navigate().GoToUrl(url);

            var button2 = Utils.WaitForElement(driver, 15, By.Id("btn2"));
            for(int i = 0; i < 100; i++)
            {
                button2.Click();
            }
            Thread.Sleep(20000); //pausing test execution for 20 seconds!!! Please avoid

        }
        [Test]
        public void Test05()
        {
            string url = protocol + "://" + hostname + ":8081/lazy.html";
            driver.Navigate().GoToUrl(url);

            /*DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(20);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(100);
            fluentWait.Message = "Sorry !! The element in the page can not be found!!";
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            var element = fluentWait.Until(x => x.FindElement(By.Id("btn2")));
            element.Click();*/
            var element = Utils.WaitForElement(driver, 20, By.Id(""));
            element.Click();

        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
