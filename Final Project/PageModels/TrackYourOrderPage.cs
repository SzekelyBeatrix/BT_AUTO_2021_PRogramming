using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project.PageModels
{
    class TrackYourOrderPage : BasePage
    {
        const string trackOrderTextSelector = "#tt-pageContent > div.pp_tracking_content > form > h1";
        const string orderNumberTextSelector = "#tt-pageContent > div.pp_tracking_content > form > div:nth-child(2) > div.pp_tracking_span > span";
        const string orderNumberInputSelector = "#tt-pageContent > div.pp_tracking_content > form > div:nth-child(2) > div.pp_tracking_input > span:nth-child(1) > input[type=text]:nth-child(2)";
        const string trackOrderEmailTextSelector = "#tt-pageContent > div.pp_tracking_content > form > div:nth-child(3) > div.pp_tracking_span > span";
        const string trackOrderEmailInputSelector = "#tt-pageContent > div.pp_tracking_content > form > div:nth-child(3) > div.pp_tracking_input > span:nth-child(1) > input[type=text]";
        const string trackButtonSelector = "#tt-pageContent > div.pp_tracking_content > form > div.pp_tracking_button > span > button";
        public TrackYourOrderPage(IWebDriver driver) : base(driver)
        {
        }
        public string CheckPage()
        {
            return driver.FindElement(By.CssSelector(trackOrderTextSelector)).Text;
        }
    }
}
