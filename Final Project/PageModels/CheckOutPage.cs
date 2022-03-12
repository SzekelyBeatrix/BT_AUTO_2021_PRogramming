using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project.PageModels
{
    class CheckOutPage : BasePage
    {
        const string orderSummaryTextSelector = "body > aside > button > span > span > span.order-summary-toggle__text.order-summary-toggle__text--show > span";//css
        const string contactInfoLabelSelector = "main-header"; //id
        const string checkoutEmailInuputSelector = "checkout_email"; //id
        const string checkoutnewsOffersInputElem = "body > div > div > div > main > div.step > form > div.step__sections > div.section.section--contact-information > div.section__content > div.fieldset-description > div > div > div > label"; //css - checkbox
        const string shippingAddressLabelSelector = "section-delivery-title"; //id
        const string shippingAddressInputSelector = "checkout_shipping_address_country"; //id
        const string checkoutfirstNameInputSelector = "checkout_shipping_address_first_name"; //id
        const string checkoutlastNameInputSelector = "checkout_shipping_address_last_name"; //id
        const string checkoutcompanyInputSelector = "checkout_shipping_address_company"; //id
        const string checkoutaddressInputSelector = "checkout_shipping_address_address1"; //id
        const string checkoutapartmentInputSelector = "checkout_shipping_address_address2"; //id
        const string checkoutZipInputSelector = "checkout_shipping_address_zip"; //id
        const string checkoutCityInputSelector = "checkout_shipping_address_city"; //id
        const string checkoutCountryInputSelector = "checkout_shipping_address_province"; //id
        const string checkoutPhoneInputSelector = "checkout_shipping_address_phone"; //id
        const string checkoutSaveInfoSelector = "body > div > div > div > main > div.step > form > div.step__sections > div.section.section--shipping-address > div.section__content > div > div.field.field--show-floating-label > div > label"; //css- checkbox
        const string checkoutContinueShippingButton = "continue_button"; //id
        const string checkoutReturnToCartButton = "body > div > div > div > main > div.step > form > div.step__footer > a > span"; //css

        public CheckOutPage (IWebDriver driver) : base(driver)
        {
        }
        public string CheckPage()
        {
            return driver.FindElement(By.CssSelector(orderSummaryTextSelector)).Text;
        }

    }

}
