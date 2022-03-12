using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project.PageModels
{
    public class LandingPage : BasePage
    {
        const string pageTextSelector = "#home-stories > h2"; //css
        const string collectionsButton = "#shopify-section-header-template > header > div.tt-desktop-header > div > div > div.tt-desctop-parent-menu.tt-parent-box.tt-obj-menu > div > nav > ul > li:nth-child(1) > a > span";
        const string catalogButton = "#shopify-section-header-template > header > div.tt-desktop-header > div > div > div.tt-desctop-parent-menu.tt-parent-box.tt-obj-menu > div > nav > ul > li:nth-child(2) > a > span";
        const string searchButton = "#shopify-section-header-template > header > div.tt-mobile-header.tt-mobile-header-inline.tt-mobile-header-inline-stuck > div > div > div.tt-mobile-parent-menu-icons > div.tt-mobile-parent-search.tt-parent-box > div > button";//css
        const string cartButton = "#shopify-section-header-template > header > div.tt-mobile-header.tt-mobile-header-inline.tt-mobile-header-inline-stuck > div > div > div.tt-mobile-parent-menu-icons > div.tt-mobile-parent-cart.tt-parent-box > div > button";//css
        const string accountButton = "#shopify-section-header-template > header > div.tt-desktop-header > div > div > div.tt-obj-options.obj-move-right.tt-position-absolute > div.tt-desctop-parent-account.tt-parent-box > div > button";//css

        public LandingPage (IWebDriver driver) : base(driver)
        {

        }
        public string CheckPage()
        {
            return driver.FindElement(By.CssSelector(pageTextSelector)).Text;
        }

    }
   
}
