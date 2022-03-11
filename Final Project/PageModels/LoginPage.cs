using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project.PageModels
{
    class LoginPage : BasePage
    {
        const string loginPageText = "login"; //id
        const string emailLabel = "#customer_login > div:nth-child(4) > label"; //css
        const string emailInput = "loginInputName"; //id
        const string emailError = "#customer_login > div.tt-base-color > div > ul > li"; //css
        const string passwordLabel = "#customer_login > div:nth-child(5) > label"; // css
        const string passwordInput = "loginInputEmail"; // id
        const string passwordError = "#customer_login > div.tt-base-color > div > ul > li"; //css
        const string loginButton = "btn btn-border";//class
        const string lostPassword = "#customer_login > div.row > div.col-auto.align-self-end > div > ul > li > a";

        public LoginPage(IWebDriver driver) : base(driver)
        {
        }
        public string CheckPage()
        {
            var loginPageEl = driver.FindElement(By.Id(loginPageText));
            return loginPageEl.Text;
        }
        public void Login(string email, string passw)
        {
            var emailInputElement = driver.FindElement(By.Id(emailInput));
            emailInputElement.Clear();
            emailInputElement.SendKeys(email);
            var passwordInputElement = driver.FindElement(By.Id(passwordInput));
            passwordInputElement.Clear();
            passwordInputElement.SendKeys(passw);
            var loginButtonElement = driver.FindElement(By.ClassName(loginButton));
            loginButtonElement.Submit();
            var lostPasswordElement = driver.FindElement(By.CssSelector(lostPassword));
            lostPasswordElement.Click();
        }

    }
}
