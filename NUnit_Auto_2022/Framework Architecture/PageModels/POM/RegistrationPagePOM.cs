using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.Framework_Architecture.PageModels.POM
{
    class RegistrationPagePOM : BasePage
    {
        const string regPageTextElem = "text-muted"; // class
        const string usernameLabelElem = "#registration-form > div:nth-child(2) > label"; // css
        const string usernameInputElem = "input-username"; //id
        const string usernameError = "#login-form > div:nth-child(1) > div > div > div.text-left.invalid-feedback"; // css
        const string passwordLabelElem = "#registration-form > div:nth-child(3) > label"; // css
        const string passwordInputElem = "input-password"; // id
        const string passwordErrElem = "#registration-form > div:nth-child(3) > div > div > div.text-left.invalid-feedback"; // css
        const string confPasswordLabelElem = "#registration-form > div:nth-child(4) > label";
        const string confPasswordInputElem = "input-password-confirm";
        const string confPasswordErrElem = "#registration-form > div:nth-child(4) > div > div > div.text-left.invalid-feedback";
        const string titleLabelElem = "#registration-form > div:nth-child(6) > label";
        const string MsLabelElem = "#registration-form > div:nth-child(6) > div > div:nth-child(2) > label";
        const string MsInputElem = "#registration-form > div:nth-child(6) > div > div:nth-child(2) > input";
        const string MrLabelElem = "#registration-form > div:nth-child(6) > div > div:nth-child(1) > label";
        const string MrInputElem = "#registration-form > div:nth-child(6) > div > div:nth-child(1) > input";
        const string firstNameLabelElem = "#registration-form > div:nth-child(7) > label";
        const string firstNameInputElem = "input-first-name";
        const string firstNameErrElem = "#registration-form > div:nth-child(7) > div > div > div.text-left.invalid-feedback";
        const string lastNameLabelElem = "#registration-form > div:nth-child(8) > label";
        const string lastNameInputElem = "input-last-name";
        const string lastNameErrElem = "#registration-form > div:nth-child(8) > div > div > div.text-left.invalid-feedback";
        const string emailLabelElem = "#registration-form > div:nth-child(9) > label";
        const string emailInputElem = "input-email";
        const string emailErrElem = "#registration-form > div:nth-child(9) > div > div > div.text-left.invalid-feedback";
        const string dateOfBirthLabelElem = "#registration-form > div:nth-child(10) > label";
        const string dateOfBirthInputElem = "input-dob";
        const string nationalityLabelElem = "#registration-form > div:nth-child(11) > label";
        const string nationalityInputElem = "input-nationality";
        const string termsLabelElem = "#registration-form > div:nth-child(12) > div.text-left.col-lg > div > label";
        const string termsInputElem = "terms";
        const string termsErrElem = "#registration-form > div:nth-child(12) > div.text-left.col-lg > div > div";
        const string submitButtonElem = "btn btn-primary"; //class

        public RegistrationPagePOM(IWebDriver driver) : base(driver)
        {
        }

        public string CheckPage()
        {
            var regPageElem = driver.FindElement(By.ClassName(regPageTextElem));
            return regPageElem.Text;
        }

        public void Registration(string user, string passw, string confPass, string fName, string lName, string mail, string dateOfb, string nation)
        {
            var usernameInput = driver.FindElement(By.Id(usernameInputElem));
            usernameInput.Clear();
            usernameInput.SendKeys(user);

            var passwordInput = driver.FindElement(By.Id(passwordInputElem));
            passwordInput.Clear();
            passwordInput.SendKeys(passw);

            var confPasswordInput = driver.FindElement(By.Id(confPasswordInputElem));
            confPasswordInput.Clear();
            confPasswordInput.SendKeys(confPass);

            var MsInput = driver.FindElement(By.Id(MsInputElem));
            MsInput.Click();

            var MrInput = driver.FindElement(By.Id(MrInputElem));
            MsInput.Click();

            var firstNameInput = driver.FindElement(By.Id(firstNameInputElem));
            firstNameInput.Clear();
            firstNameInput.SendKeys(fName);

            var lastNameInput = driver.FindElement(By.Id(lastNameInputElem));
            lastNameInput.Clear();
            lastNameInput.SendKeys(lName);

            var emailInput = driver.FindElement(By.Id(emailInputElem));
            emailInput.Clear();
            emailInput.SendKeys(mail);

            var dateOfBirthInput = driver.FindElement(By.Id(dateOfBirthInputElem));
            emailInput.Clear();
            emailInput.SendKeys(dateOfb);

            var nationalityInput = driver.FindElement(By.Id(nationalityInputElem));
            nationalityInput.Clear();
            nationalityInput.SendKeys(nation);

            var termsInput = driver.FindElement(By.Id(termsInputElem));
            termsInput.Click();

            var submitButton = driver.FindElement(By.ClassName(submitButtonElem));
            submitButton.Submit();
        }

    }
}
