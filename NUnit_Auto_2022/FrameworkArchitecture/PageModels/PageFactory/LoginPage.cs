using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.FrameworkArchitecture.PageModels.PageFactory
{
    class LoginPage
    {
        IWebDriver driver;
        private IWebElement authPageTextElem => driver.FindElement(By.ClassName("text-muted"));
        private IWebElement usernameLabelElem => driver.FindElement(By.CssSelector("#login-form > div:nth-child(1) > label"));
        private IWebElement usernameInputElem => driver.FindElement(By.Id("input-login-username"));
        private IWebElement usernameErrElem => driver.FindElement(By.CssSelector("#login-form > div:nth-child(1) > div > div > div.text-left.invalid-feedback"));
        private IWebElement passwordLabelElem => driver.FindElement(By.CssSelector("#login-form > div.form-group.row.row-cols-lg-true > label"));
        private IWebElement passwordInputElem => driver.FindElement(By.Id("input-login-password"));
        private IWebElement passwordErrElem => driver.FindElement(By.CssSelector("#login-form > div.form-group.row.row-cols-lg-true > div > div > div.text-left.invalid-feedback"));
        private IWebElement submitButtonElem => driver.FindElement(By.ClassName("btn-primary"));

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public string CheckPage()
        {
            return authPageTextElem.Text;
        }

        public void Login(string user, string pass)
        {
            usernameInputElem.Clear();
            usernameInputElem.SendKeys(user);
            passwordInputElem.Clear();
            passwordInputElem.SendKeys(pass);
            submitButtonElem.Submit();
        }

    }
}

