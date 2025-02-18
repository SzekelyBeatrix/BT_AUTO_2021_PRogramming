﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022
{
    class SeleniumTests
    {
       // string path = "C:Desktop\\_driver";
        IWebDriver driver;
        const string protocol = "https";
        const string hostname = "magazinulcolectionarului.ro/";
        const string path = "/";

        string url = protocol + "://" + hostname + path;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            //_driver = new FirefoxDriver();
           // _driver = new EdgeDriver();
            
        }

        [Test]
        public void Test01()
        {


            //_driver.Url = "https://google.com"; 
           driver.Url = url; //am declarat mai sus calea
           driver.Navigate();

            // _driver.Navigate().GoToUrl("https://google.com");

            driver.Navigate().Back();

            driver.Navigate().Forward();

            driver.Navigate().Refresh();
        }
        [Test]
        public void Test02()
        {
            driver.Url = "https://learn.digitalstack.ro/login/index.php";
            driver.Navigate();
        }

        [Test]
        public void Test03()
        {
            driver.Url = url;
            driver.Navigate();

            IWebElement body = driver.FindElement(By.ClassName("modal-header"));
            body.Click();

            /*IWebElement cookieAccept1 = _driver.FindElement(By.CssSelector(""));
            cookieAccept1.Click();

            IWebElement cookieAccept2 = _driver.FindElement(By.XPath(""));
            cookieAccept2.Click();*/

            IWebElement eaglemoss = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[2]/nav/div/ul/li[1]/a/span[2]"));
            eaglemoss.Click();

            var addToCart = driver.FindElements(By.XPath("//*[@id='amasty-shopby-product-list']/div[2]/ol/li"));
            foreach(IWebElement el in addToCart)
            {
                var text = el.FindElement(By.XPath("//span"));
                Console.WriteLine(text.Text);
            }
        }
        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }



    }
}
