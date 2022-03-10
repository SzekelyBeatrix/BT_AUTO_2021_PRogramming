using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project.PageModels
{
    class WishlistPage : BasePage
    {
        const string WishlistTextSelector = "#tt-pageContent > div > div > div.tt-block-title > h1";
        const string WishSingInButtonSelector = "#tt-pageContent > div > div > div.tt-login-wishlist > div > a.btn.btn-small.ttbtnmainstyle";
        const string WishRegisterButtonSelector = "#tt-pageContent > div > div > div.tt-login-wishlist > div > a.btn.btn-border.btn-small";
        public WishlistPage(IWebDriver driver) : base(driver)
        {
        }

        public string CheckPage()
        {
            return driver.FindElement(By.CssSelector(WishlistTextSelector)).Text;
        }
        public void Wishlist()
        {
            var WishSingInButton = driver.FindElement(By.CssSelector(WishSingInButtonSelector));
            WishSingInButton.Submit();
            var WishRegisterButton = driver.FindElement(By.CssSelector(WishRegisterButtonSelector));
            WishRegisterButton.Submit();
        }
    }
}
