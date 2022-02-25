using NUnit.Framework;
using NUnit_Auto_2022.PageModels.POM;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.Tests
{
    class EcomTestSite : BaseTest
    {

        [Test]
        public void LoginTest()
        {
            _driver.Navigate().GoToUrl("https://www.abdcomputer.ro/");
            LandingPage lp = new LandingPage(_driver);
            Assert.AreEqual("Produse IT Renew, Refurbish, Noi & SH", lp.CheckPage());
            lp.LoginNavigate();

        }

        [Test]
        public void RegisterUnchecked()
        {
            _driver.Navigate().GoToUrl("https://www.abdcomputer.ro/");
            LandingPage lp = new LandingPage(_driver);
            lp.LoginNavigate();
            RegisterPage rp = new RegisterPage(_driver);
            Assert.AreEqual("Sunt client nou", rp.CheckPage());
            rp.AcceptCookies();
            rp.Register("aaaa", "bbbb", "077777770", "aaaa@aaaa.com", "Abc123$");
        }

    }
}
