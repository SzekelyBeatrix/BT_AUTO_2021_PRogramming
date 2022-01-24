using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework2
{
    class RegistrationTests
    {
        IWebDriver driver;

        const string protocol = "http";
        const string hostname = "86.121.249.150";
        const string port = "4999";
        const string path = "/#/registration";

        string url = protocol + "://" + hostname + ":" + port + path;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }

        [TestCase("Beatrix.Sz", "THi$!$Myp@ssw0Rd", "THi$!$Myp@ssw0Rd", "Iulia - Beatrix", "Szekely")]
        [Test]

        public void Test01()
        {

            driver.Navigate().GoToUrl(url);

            var username = driver.FindElement(By.Id("input-username"));
            var password = driver.FindElement(By.Id("input-password"));
            var confirmPassword = driver.FindElement(By.Id("input-password-confirm"));
            var titleMr = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(6) > div > div:nth-child(1) > input"));
            var titleMs = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(6) > div > div:nth-child(2) > input"));
            var firstName = driver.FindElement(By.Id("input-first-name"));
            var lastName = driver.FindElement(By.Id("input-last-name"));
            var dob = driver.FindElement(By.Id("input-dob"));
            var nationality = driver.FindElement(By.Id("input-nationality"));
            var terms = driver.FindElement(By.Id("terms"));
            var submit = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(13) > div.text-left.col-lg > button"));

            username.Clear();
            username.SendKeys("Beatrix.Sz");
            password.Clear();
            password.SendKeys("THi$!$Myp@ssw0Rd");
            confirmPassword.Clear();
            confirmPassword.SendKeys("THi$!$Myp@ssw0Rd"); 
            titleMr.Click();
            titleMs.Click();
            firstName.SendKeys("Iulia-Beatrix");
            lastName.SendKeys("Szekely");
            dob.SendKeys("20.06.1996");
            nationality.SendKeys("Nigerien");
            terms.Click();
            submit.Submit();
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }

    }
}

