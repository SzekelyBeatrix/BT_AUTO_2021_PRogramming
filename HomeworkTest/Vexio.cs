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

        //https://www.vexio.ro/account/login/#login

        const string protocol = "https";
        const string hostname = "www.vexio.ro";
        const string path = "/account/login/#login";

        string url = protocol + "://" + hostname + path;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }
        [TestCase("Beatrix", "Szekely", "0757215344", "szekely_beatrix@yahoo.com", "Parola12.", "Parola12.",
        "", "", "", "", "", "","")]

        [TestCase("Beatrix", "Szekely", "0757215344", "szekely_beatrix@yahoo.com", "Parola12.", "Parola12.",
        "", "", "", "", "", "", "")]


        [Test]
        public void Test01(string prenRegist, string numeRegist, string tel, string mailRegist, string parolaRegist, string confPar, string prenErr, string numErr, string telErr, string mailErr,string parErr,string confparErr, string condErr )
        {
            driver.Navigate().GoToUrl(url);

            var pageReg = driver.FindElement(By.CssSelector("#body > div.content-wrapper > div:nth-child(4) > div > div.col-xs-12 > h1"));
            Assert.AreEqual("Autentificare", pageReg.Text);

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
 
            var prenumeErr = driver.FindElement(By.CssSelector("#body > div.content-wrapper > div:nth-child(4) > div > div.col-xs-12 > ul > li:nth-child(4)"));
            var numeErr = driver.FindElement(By.CssSelector("#body > div.content-wrapper > div:nth-child(4) > div > div.col-xs-12 > ul > li:nth-child(5)"));
            var telefonErr = driver.FindElement(By.CssSelector("#body > div.content-wrapper > div:nth-child(4) > div > div.col-xs-12 > ul > li:nth-child(6)"));
            var emailErr = driver.FindElement(By.CssSelector("#body > div.content-wrapper > div:nth-child(4) > div > div.col-xs-12 > ul > li:nth-child(1)"));
            var parolaErr = driver.FindElement(By.CssSelector("#body > div.content-wrapper > div:nth-child(4) > div > div.col-xs-12 > ul > li:nth-child(2)"));
            var confParolaErr = driver.FindElement(By.CssSelector("#body > div.content-wrapper > div:nth-child(4) > div > div.col-xs-12 > ul > li:nth-child(3)"));
            var conditiiErr = driver.FindElement(By.CssSelector("#body > div.content-wrapper > div:nth-child(4) > div > div.col-xs-12 > ul > li:nth-child(7)"));
            


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

            Assert.AreEqual(prenErr, prenumeErr.Text);
            Assert.AreEqual(numErr, numeErr.Text);
            Assert.AreEqual(telErr, telefonErr.Text);
            Assert.AreEqual(mailErr, emailErr.Text);
            Assert.AreEqual(parErr, parolaErr.Text);
            Assert.AreEqual(confparErr, confParolaErr.Text);
            Assert.AreEqual(condErr, conditiiErr.Text);
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
