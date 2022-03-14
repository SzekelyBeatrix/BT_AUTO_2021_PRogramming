using NUnit.Framework;
using NUnit_Auto_2022.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project.Tests
{
    class BaseTest
    {

        public IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            driver.Value = Browser.GetDriver();
            _driver = driver.Value;
        }

        [TearDown]
        public void Teardown()
        {
            _driver.Quit();
        }

    }
}
