using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.PageModels.PageFactory
{
    public class LoginPage
    {
        IWebDriver driver;

        // Page elements that are found automatically once the class is instantiated and page is loaded
        private IWebElement authPageTextElem => driver.FindElement(By.ClassName("text-muted"));
        private IWebElement usernameLabelElem => driver.FindElement(By.CssSelector("#login-form > div:nth-child(1) > label"));
        private IWebElement usernameInputElem => driver.FindElement(By.Id("input-login-username"));
        private IWebElement usernameErrElem => driver.FindElement(By.CssSelector("#login-form > div:nth-child(1) > div > div > div.text-left.invalid-feedback"));
        private IWebElement passwordLabelElem => driver.FindElement(By.CssSelector("#login-form > div.form-group.row.row-cols-lg-true > label"));
        private IWebElement passwordInputElem => driver.FindElement(By.Id("input-login-password"));
        private IWebElement passwordErrElem => driver.FindElement(By.CssSelector("#login-form > div.form-group.row.row-cols-lg-true > div > div > div.text-left.invalid-feedback"));
        private IWebElement submitButtonElem => driver.FindElement(By.ClassName("btn-primary"));


        //Login page constructor that initializes the _driver
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        //Returns the text that appears on the AUTH page to be checked in the test
        public string CheckPage()
        {
            return authPageTextElem.Text;
        }
        
        // Login page with username and password passed from the test
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
