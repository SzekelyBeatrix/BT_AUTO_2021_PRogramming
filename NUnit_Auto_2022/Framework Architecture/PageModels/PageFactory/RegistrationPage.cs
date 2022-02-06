using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.Framework_Architecture.PageModels
{
    class RegistrationPage
    {
        IWebDriver driver;
        private IWebElement regPageTextElem => driver.FindElement(By.ClassName("text-muted"));
        private IWebElement usernameLabelElem => driver.FindElement(By.CssSelector("#registration-form > div:nth-child(2) > label"));
        private IWebElement usernameInputElem => driver.FindElement(By.Id("input-username"));
        private IWebElement usernameErrElem => driver.FindElement(By.CssSelector("#registration-form > div:nth-child(2) > div > div > div.text-left.invalid-feedback"));
        private IWebElement passwordLabelElem => driver.FindElement(By.CssSelector("#registration-form > div:nth-child(3) > label"));
        private IWebElement passwordInputElem => driver.FindElement(By.Id("input-password"));
        private IWebElement passwordErrElem => driver.FindElement(By.CssSelector("#registration-form > div:nth-child(3) > div > div > div.text-left.invalid-feedback"));
        private IWebElement confPasswordLabelElem => driver.FindElement(By.CssSelector("#registration-form > div:nth-child(4) > label"));
        private IWebElement confPasswordInputElem => driver.FindElement(By.Id("input-password-confirm"));
        private IWebElement confPasswordErrElem => driver.FindElement(By.CssSelector("#registration-form > div:nth-child(4) > div > div > div.text-left.invalid-feedback"));
        private IWebElement titleLabelElem => driver.FindElement(By.CssSelector("#registration-form > div:nth-child(6) > label"));
        private IWebElement MsLabelElem => driver.FindElement(By.CssSelector("#registration-form > div:nth-child(6) > div > div:nth-child(2) > label"));
        private IWebElement MsInputElem => driver.FindElement(By.CssSelector("#registration-form > div:nth-child(6) > div > div:nth-child(2) > input"));
        private IWebElement MrLabelElem => driver.FindElement(By.CssSelector("#registration-form > div:nth-child(6) > div > div:nth-child(1) > label"));
        private IWebElement MrInputElem => driver.FindElement(By.CssSelector("#registration-form > div:nth-child(6) > div > div:nth-child(1) > input"));
        private IWebElement firstNameLabelElem => driver.FindElement(By.CssSelector("#registration-form > div:nth-child(7) > label"));
        private IWebElement firstNameInputElem => driver.FindElement(By.Id("input-first-name"));
        private IWebElement firstNameErrElem => driver.FindElement(By.CssSelector("#registration-form > div:nth-child(7) > div > div > div.text-left.invalid-feedback"));
        private IWebElement lastNameLabelElem => driver.FindElement(By.CssSelector("#registration-form > div:nth-child(8) > label"));
        private IWebElement lastNameInputElem => driver.FindElement(By.Id("input-last-name"));
        private IWebElement lastNameErrElem => driver.FindElement(By.CssSelector("#registration-form > div:nth-child(8) > div > div > div.text-left.invalid-feedback"));
        private IWebElement emailLabelElem => driver.FindElement(By.CssSelector("#registration-form > div:nth-child(9) > label"));
        private IWebElement emailInputElem => driver.FindElement(By.Id("input-email"));
        private IWebElement emailErrElem => driver.FindElement(By.CssSelector("#registration-form > div:nth-child(9) > div > div > div.text-left.invalid-feedback"));
        private IWebElement dateOfBirthLabelElem => driver.FindElement(By.CssSelector("#registration-form > div:nth-child(10) > label"));
        private IWebElement dateOfBirthInputElem => driver.FindElement(By.Id("input-dob"));
        private IWebElement nationalityLabelElem => driver.FindElement(By.CssSelector("#registration-form > div:nth-child(11) > label"));
        private IWebElement nationalityInputElem => driver.FindElement(By.Id("input-nationality"));
        private IWebElement termsLabelElem => driver.FindElement(By.CssSelector("#registration-form > div:nth-child(12) > div.text-left.col-lg > div > label"));
        private IWebElement termsInputElem => driver.FindElement(By.Id("terms"));
        private IWebElement termsErrElem => driver.FindElement(By.CssSelector("#registration-form > div:nth-child(12) > div.text-left.col-lg > div > div"));
        private IWebElement submitButtonElem => driver.FindElement(By.ClassName("btn btn-primary"));

        public RegistrationPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public string CheckPage()
        {
            return regPageTextElem.Text;
        }

        public void Registration(string user, string pass, string confpass, string firstName, string lastName, string email, string dob, string nationality)
        {
            usernameInputElem.Clear();
            usernameInputElem.SendKeys(user);
            passwordInputElem.Clear();
            passwordInputElem.SendKeys(pass);
            confPasswordInputElem.Clear();
            confPasswordInputElem.SendKeys(confpass);
            MsInputElem.Click();
            MrInputElem.Click();
            firstNameInputElem.Clear();
            firstNameInputElem.SendKeys(firstName);
            lastNameInputElem.Clear();
            lastNameInputElem.SendKeys(lastName);
            emailInputElem.Clear();
            emailInputElem.SendKeys(email);
            dateOfBirthInputElem.Clear();
            dateOfBirthInputElem.SendKeys(dob);
            nationalityInputElem.Clear();
            nationalityInputElem.SendKeys(nationality);
            termsInputElem.Click();
            submitButtonElem.Submit();
        }
    }
}
