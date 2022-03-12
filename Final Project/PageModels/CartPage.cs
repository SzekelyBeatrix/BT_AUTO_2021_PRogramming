using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project.PageModels
{
    class CartPage : BasePage
    {
        const string emptyCartText = "#tt-pageContent > div.container-indent.nomargin.tt-empty-cart-js > div > h1"; //css
        const string continueShopSelector = "#tt-pageContent > div.container-indent.nomargin.tt-empty-cart-js > div > a"; //css
        const string shoppingCarttext = "#updateform > h1"; //css
        const string clearShopSelector = "#updateform > div.tt-shopcart-table-02 > div > div.col-right > a"; //css
        const string shippingCartText = "#updateform > div.tt-shopcart-col > div.row > div:nth-child(1) > div > h4"; //css
        const string shippingCountryText = "#updateform > div.tt-shopcart-col > div.row > div:nth-child(1) > div > div > div:nth-child(1) > label"; //css
        const string shippingCountryInputSelector = "address_country";//id
        const string shippingStateText = "#address_province_container > label";
        const string shippingStateInputSelector = "address_province"; //id
        const string shippingZipText = "#updateform > div.tt-shopcart-col > div.row > div:nth-child(1) > div > div > div:nth-child(3) > label";
        const string shippingZipInputSelector = "address_zip"; //id
        const string shippingZipErrorText = "shipping-rates-feedback"; //id
        const string calculateShippingButtonSelector = "#updateform > div.tt-shopcart-col > div.row > div:nth-child(1) > div > div > button";
        const string grandTotalText = "grandtotal"; //id
        const string termsInputElem = "#updateform > div.tt-shopcart-col > div.row > div:nth-child(3) > div > div > label > span.check";//css
        //prima oara sa dea click pe buttonul cart din pagina
        public CartPage(IWebDriver driver) : base(driver)
        {

        }
    }
}
