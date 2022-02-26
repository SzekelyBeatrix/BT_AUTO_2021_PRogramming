using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project.PageModels
{
    class RegisterPage : BasePage
    {
        const string createAccountTextSelector = "#tt-pageContent > div > div > h1";
        const string firstNameLabelSelector = "#create_customer > div:nth-child(4) > label";
        const string firstNameInputSelector = "loginInputName";  // First Name is a * Required Field, but does not have an error message for empty values
        const string lastNameLabelSelector = "#create_customer > div:nth-child(5) > label";
        const string lastNameInputSelector = "loginLastName"; // Last Name is a * Required Field, but does not have an error message for empty values
        const string emailLabelSelector = "#create_customer > div:nth-child(6) > label";
        const string emailInputSelector = "loginInputEmail";
        const string emailErrorSelector = "#create_customer > div.tt-base-color > div > ul > li:nth-child(2)";
        const string passwordLabelSelector = "#create_customer > div:nth-child(7) > label";
        const string passwordInputSelector = "loginInputPassword";
        const string passwordErrorSelector = "#create_customer > div.tt-base-color > div > ul > li:nth-child(1)";
        const string createSelector = "#create_customer > div.row > div:nth-child(1) > div > button";
        const string returnToStoreSelector = "#create_customer > div.row > div.col-auto.align-self-center > div > ul > li > a";

        public RegisterPage(IWebDriver driver) : base(driver)
        {
        }
        public string CheckPage()
        {
            return driver.FindElement(By.CssSelector(createAccountTextSelector)).Text;
        }

        public void Register(string fname, string lname, string email, string pass)
        {
            var firstNameInput = driver.FindElement(By.Id(firstNameInputSelector));
            firstNameInput.Clear();
            firstNameInput.SendKeys(fname);
            var lastNameInput = driver.FindElement(By.Id(lastNameInputSelector));
            lastNameInput.Clear();
            lastNameInput.SendKeys(lname);
            var emailInput = driver.FindElement(By.Id(emailInputSelector));
            emailInput.Clear();
            emailInput.SendKeys(email);
            var passInput = driver.FindElement(By.Id(passwordInputSelector));
            passInput.Clear();
            passInput.SendKeys(pass);
            var createButton = driver.FindElement(By.CssSelector(createSelector));
            createButton.Submit();
        }
    }
}
