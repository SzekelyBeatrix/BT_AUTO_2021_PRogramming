using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022
{
    class SeleniumTests
    {
        string path = "C:\\Drivers";
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            IWebDriver driver = new ChromeDriver(@path);
        }

        [Test]
        public void Test01()
        {
           
           
           driver.Url = "https://google.com";
           driver.Navigate();

            
        }
        [Test]
        public void Test02()
        {
            driver.Url = "https://learn.digitalstack.ro/login/index.php";
            driver.Navigate();
        }
        [TearDown]
        public void Teardown()
        {
            driver.Close();
        }
    }
}
