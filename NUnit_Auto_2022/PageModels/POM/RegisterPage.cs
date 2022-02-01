using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.PageModels.POM
{
    class RegisterPage :BasePage
    {
        const string registerTextSelector = "#register > formfield > legend"; // css
        const string firstNameInputSelector = "newfirstname"; // id
        const string lastNameInputSelector = "newlastname"; // id
        const string phoneInputSelector = "telephone"; // id
        const string emailInputSelector = "newemail"; // id
        const string passInputSelector = "newpassword"; // id
        const string passRepeatInputSelector = "newpasswordretype"; // id
        const string newsletterSelector = "newsletter"; // id
        const string agreeSelector = "agree"; // id
        const string regSubmitSelector = "#register > formfield > div:nth-child(9) > div > button"; // css

        const string loginEmailSelector = "email"; //id
        const string loginPassSelector = "password"; // id
        const string loginButtonSelector = "#login > formfield > div:nth-child(5) > div > button";// css 

        const string cookieAcceptSelector = "#cookies-consent > div > div > div:nth-child(2) > div > div.accept-cookies.col-xs-offset-4.col-xs-4.col-sm-offset-0.col-sm-3.pull-right.col-lg-2.text-right > button"; // css

        public RegisterPage(IWebDriver driver) : base(driver)
        {

        }

        public string CheckPage()
        {
            return driver.FindElement(By.CssSelector(registerTextSelector)).Text;
        }

        public void AcceptCookies()
        {
            driver.FindElement(By.CssSelector(cookieAcceptSelector)).Click();
        }

        public void Register(string fname, string lname, string phone, string email, string pass,string confirmPass = null)
        {
            var firstNameInput = driver.FindElement(By.Id(firstNameInputSelector));
            firstNameInput.Clear();
            firstNameInput.SendKeys(fname);
            var lastNameInput = driver.FindElement(By.Id(lastNameInputSelector));
            lastNameInput.Clear();
            lastNameInput.SendKeys(lname);
            var phoneInput = driver.FindElement(By.Id(phoneInputSelector));
            phoneInput.Clear();
            phoneInput.SendKeys(phone);
            var emailInput = driver.FindElement(By.Id(emailInputSelector));
            emailInput.Clear();
            emailInput.SendKeys(email);
            var passInput = driver.FindElement(By.Id(passInputSelector));
            passInput.Clear();
            passInput.SendKeys(pass);
            var passRepeatInput = driver.FindElement(By.Id(passRepeatInputSelector));
            passRepeatInput.Clear();
            passRepeatInput.SendKeys(pass);
            var newsletterCheck = driver.FindElement(By.Id(newsletterSelector));
            //newsletterCheck
            var buttonSubmit = driver.FindElement(By.CssSelector(regSubmitSelector));
            buttonSubmit.Submit();

        }
    }
}
