using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegistrationTest
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

        [TestCase("Beatrix.Sz", "THi$!$Myp@ssw0Rd", "THi$!$Myp@ssw0Rd", "Iulia - Beatrix", "Szekely", "beatrix.szekely@btrl.ro", "01.01.1990", "Nigerien",
        "", "", "", "", "", "", "", "")]

        [TestCase(" ", "THi$!$M", "THi$!", "IuliaaaaaaaaaaaBeaaaaaaaaaatriiiiiix", "S", "www.beatrix.szekely.com", "01.01.120", "Palistian",
         "Username is required!", "Minimum of 8 characters is required!", "Passwords do not match!", "Maximum of 35 characters allowed!", "Minimum of 2 characters is required!", "Invalid email address!", "", "")]

        [TestCase("Bea", " ", "0000000000000000000000000000000", ".", "Sssssszzzzzzzzzzzzzzeeeeeeeeeeeeeeeeeeeeeeeeeeeeekkkkkkkkkkkkkkkkkkke", " ", "01.01.10", "Hungaroring",
         "Minimum of 4 characters is required!", "Password is required!", "Passwords do not match!", "Minimum of 2 characters is required!", "Maximum of 35 characters allowed!", "Email is required!", "", "")]

        [TestCase("Beaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", " ", "strong ", ".", "Sssssszzzzzzzzzzzzzzeeeeeeeeeeeeeeeeeeeeeeeeeeeeekkkkkkkkkkkkkkkkkkke", " ", "01.01.10", "Hungaroring",
         "Maximum of 35 characters allowed!", "Password is required!", "Passwords do not match!", "Minimum of 2 characters is required!", "Maximum of 35 characters allowed!", "Email is required!", "", "")]

        [TestCase("SSSSSSSSSSSSzzzzzzzzzzzzzzzzzeeeeeeeeeeeeeeeeeeeeeee", "1234567", "12345687", "BE", "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "b@gamil.ro", "20010101", "HU",
         "Maximum of 35 characters allowed!", "Minimum of 8 characters is required!", "Passwords do not match!", "", "", "", "", "")]


        [Test]

        public void Test01(string user, string pass, string confPass, string fName, string lName, string mail, string dateOfb, string nation, string userErr, string passErr, string confPassErr, string fNameErr, string lNameErr, string mailErr, string dateOfbErr, string nationErr)
        {

            driver.Navigate().GoToUrl(url);

            var pageReg = driver.FindElement(By.CssSelector("#root > div > div.content > div > div:nth-child(1) > div > div > h1 > small"));
            Assert.AreEqual("Registration", pageReg.Text);

            var username = driver.FindElement(By.Id("input-username"));
            var password = driver.FindElement(By.Id("input-password"));
            var confirmPassword = driver.FindElement(By.Id("input-password-confirm"));
            var titleMr = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(6) > div > div:nth-child(1) > input"));
            var titleMs = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(6) > div > div:nth-child(2) > input"));
            var firstName = driver.FindElement(By.Id("input-first-name"));
            var lastName = driver.FindElement(By.Id("input-last-name"));
            var email = driver.FindElement(By.Id("input-email"));
            var dob = driver.FindElement(By.Id("input-dob"));
            var nationality = driver.FindElement(By.Id("input-nationality"));
            var terms = driver.FindElement(By.Id("terms"));
            var submit = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(13) > div.text-left.col-lg > button"));

            var usernameError = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(2) > div > div > div.text-left.invalid-feedback"));
            var passwordError = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(3) > div > div > div.text-left.invalid-feedback"));
            var confirmPasswordError = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(4) > div > div > div.text-left.invalid-feedback"));
            var firstNameError = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(7) > div > div > div.text-left.invalid-feedback"));
            var lastNameError = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(8) > div > div > div.text-left.invalid-feedback"));
            var emailError = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(9) > div > div > div.text-left.invalid-feedback"));

            //var termscheckError = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(12) > div.text-left.col-lg > div > div"));
            //Assert.AreEqual("You need to accept our T&C!", termscheckError.Text);


            username.Clear();
            username.SendKeys(user);
            password.Clear();
            password.SendKeys(pass);
            confirmPassword.Clear();
            confirmPassword.SendKeys(confPass);
            titleMr.Click();
            titleMs.Click();
            firstName.SendKeys(fName);
            lastName.SendKeys(lName);
            email.SendKeys(mail);
            dob.SendKeys(dateOfb);
            nationality.SendKeys(nation);
            terms.Click();
            submit.Submit();

            Assert.AreEqual(userErr, usernameError.Text);
            Assert.AreEqual(passErr, passwordError.Text);
            Assert.AreEqual(confPassErr, confirmPasswordError.Text);
            Assert.AreEqual(fNameErr, firstNameError.Text);
            Assert.AreEqual(lNameErr, lastNameError.Text);
            Assert.AreEqual(mailErr, emailError.Text);

        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }

    }
}

