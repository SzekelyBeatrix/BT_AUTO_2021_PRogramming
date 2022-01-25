using NuGet.Frameworks;
using NUnit_Auto_2022.PageModels.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.Tests
{
    class AuthTest
    {
        IWebDriver driver;

        string url = FrameworkConstants.GetUrl();

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void BasicAuth()
        {
            driver.Navigate().GoToUrl(url + "login");
            LoginPage lp = new LoginPage(driver);
            Assert.AreEqual("Authentication", lp.CheckPage());
            lp.Login("user1", "pass1");
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
