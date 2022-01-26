using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkTest
{
    class Vexio
    {
        IWebDriver driver;

        const string protocol = "https";
        const string hostname = "www.vexio.ro";
        const string path = "/account/login/#login";

        string url = protocol + "://" + hostname + path;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test01(string prenRegist,string numeRegist, string tel,string mailRegist,string parolaRegist, string confPar)
        {
            driver.Navigate().GoToUrl(url);

            var pageReg = driver.FindElement(By.CssSelector("#body > div.content-wrapper > div:nth-child(4) > div > div.col-xs-12 > h1"));
            Assert.AreEqual("Registration", pageReg.Text);

            //Registration
            var prenume = driver.FindElement(By.CssSelector("#register > formfield > div:nth-child(3) > label"));
            var nume = driver.FindElement(By.CssSelector("#register > formfield > div:nth-child(4) > label"));
            var telefon = driver.FindElement(By.CssSelector("#register > formfield > div:nth-child(5) > label"));
            var email = driver.FindElement(By.CssSelector("#register > formfield > div:nth-child(6) > label"));
            var parola = driver.FindElement(By.CssSelector("#register > formfield > div:nth-child(7) > label"));
            var confParola = driver.FindElement(By.CssSelector("#register > formfield > div:nth-child(8) > label"));
            var newsletter = driver.FindElement(By.CssSelector("#register > formfield > div:nth-child(9) > div > label:nth-child(2)"));
            var conditii = driver.FindElement(By.CssSelector("#register > formfield > div:nth-child(9) > div > label:nth-child(6)"));
            var creeaza = driver.FindElement(By.CssSelector("#register > formfield > div:nth-child(9) > div > button"));


            prenume.Clear();
            prenume.SendKeys(prenRegist);
            nume.Clear();
            nume.SendKeys(numeRegist);
            telefon.Clear();
            telefon.SendKeys(tel);
            email.Clear();
            email.SendKeys(mailRegist);
            parola.Clear();
            parola.SendKeys(parolaRegist);
            confParola.Clear();
            confParola.SendKeys(confPar);
            newsletter.Click();
            conditii.Click();
            conditii.Click();
            creeaza.Submit();

        }
        public void Test02()
        { 
            //Login
            var loginEmail = driver.FindElement(By.CssSelector("#login > formfield > div:nth-child(3) > label"));
            var loginParola = driver.FindElement(By.CssSelector("#login > formfield > div:nth-child(4) > label"));
            var parolaReset = driver.FindElement(By.CssSelector("#login > formfield > div:nth-child(4) > div > a"));
            var acceseaza = driver.FindElement(By.CssSelector("#login > formfield > div:nth-child(5) > div > button"));

        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();

        }
    }

}
