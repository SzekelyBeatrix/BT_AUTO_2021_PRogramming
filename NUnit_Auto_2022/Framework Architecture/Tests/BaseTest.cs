using NUnit.Framework;
using NUnit_Auto_2022.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.Framework_Architecture.Tests
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
