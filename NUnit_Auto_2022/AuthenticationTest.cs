using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022
{
    class AuthenticationTest
    {
        IWebDriver driver;
        const string protocol = "https";
        const string hostname = "86.121.249.150";
        const string port = "4999";
        const string path = "/#/login";

        string url = protocol + "://" + hostname + ":" + port + path;

        [SetUp]

        public void SetUp()
        {
            driver = new ChromeDriver();
        }
        [TestCase("dinosaur", "dinosaur")]

        [Test]
        public void Test01()
        {
            driver.Navigate().GoToUrl(url);

            var username = driver.FindElement(By.Id("input-login-username"));
            var password = driver.FindElement(By.Id("input-login-password"));
            var submit = driver.FindElement(By.CssSelector("#login-form > div:nth-child(3) "));

            username.SendKeys("beatrix");
            password.SendKeys("1234QWER");

            submit.Submit();
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}
