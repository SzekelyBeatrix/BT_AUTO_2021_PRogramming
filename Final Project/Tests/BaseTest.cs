using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project.Tests
{
    class BaseTest
    {

        public IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = Browser.GetDriver(WebBrowsers.Chrome);
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }

    }
}
