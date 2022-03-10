using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project.PageModels
{
    class ResetPasswordPage : BasePage
    {

        const string ResetPassTextSelector = "#recover-password > h2";
        const string resetemailLabelSelector = "#recover-password > div > form > div.form-group > label";
        const string resetemailInputSelector = "loginInputName";
        const string resetButtonSelector = "#recover-password > div > form > div.row > div:nth-child(1) > div > button";
        const string cancelResetSelector = "#recover-password > div > form > div.row > div.col-auto.align-self-center > div > ul > li > a";

        public ResetPasswordPage(IWebDriver driver) : base(driver)
        {
        }
        public string CheckPage()
        {
            return driver.FindElement(By.CssSelector(ResetPassTextSelector)).Text;
        }
        public void ResetPassword(string resemail)
        {
            var resetemailInput = driver.FindElement(By.Id(resetemailInputSelector));
            resetemailInput.Clear();
            resetemailInput.SendKeys(resemail);
            var resetButton = driver.FindElement(By.CssSelector(resetButtonSelector));
            resetButton.Submit();
            var cancelReset = driver.FindElement(By.CssSelector(cancelResetSelector));
            cancelReset.Click();
        }
    }
}