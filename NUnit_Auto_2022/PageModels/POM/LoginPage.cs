using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.PageModels.POM
{
    class LoginPage :BasePage
    {
        const string authPageText = "text-muted"; //class
        const string userNameLabel = "#login-form > div:nth-child(1) > label"; //css
        const string userNameInput = "input-login-username"; //id
        const string userNameError = "#login-form > div:nth-child(1) > div > div > div.text-left.invalid-feedback"; //css
        const string passwordLabel = "#login-form > div.form-group.row.row-cols-lg-true > label"; //css
        const string passwordInput = "input-login-password"; // id
        const string passwordError = "#login-form > div.form-group.row.row-cols-lg-true > div > div > div.text-left.invalid-feedback"; // css
        const string submitButton = "btn-primary"; // class

        public LoginPage(IWebDriver driver) : base(driver)
        {

        }

        public string CheckPage()
        {
            var authPageE1 = driver.FindElement(By.ClassName(authPageText));
            return authPageE1.Text;
        }

        public void Login(string user, string passw)
        {
            var usernameInputElement = driver.FindElement(By.Id(userNameInput));
            usernameInputElement.Clear();
            usernameInputElement.SendKeys(user);

            var passwordInputElement = driver.FindElement(By.Id(passwordInput));
            usernameInputElement.Clear();
            usernameInputElement.SendKeys(passw);

            var submitButtonElement = driver.FindElement(By.ClassName(submitButton));
            submitButtonElement.Submit();
        }

    }
}
