using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkTest
{
    class CookieTests
    {
        IWebDriver driver;

        const string protocol = "http";
        const string hostname = "86.121.249.150";
        const string port = "4999";
        const string path = "/#/cookie";

        string url = protocol + "://" + hostname + ":" + port + path;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void TestCookie()
        {
            driver.Navigate().GoToUrl(url);

            var cookies = driver.Manage().Cookies;
            Console.WriteLine("The site contains {0} cookies", cookies.AllCookies.Count);
            foreach (Cookie c in cookies.AllCookies)
            {
                Console.WriteLine("I am getting the cookies from the browser:", c.Name, c.Value);
            }

            var setCookie = driver.FindElement(By.Id("set-cookie"));
            var removeCookie = driver.FindElement(By.Id("delete-cookie"));
            var cookieValue = driver.FindElement(By.Id("cookie-value"));

            setCookie.Click();
            var ck = cookies.GetCookieNamed("gibberish");
            Assert.AreEqual(cookieValue, cookieValue.Text);
            Console.WriteLine("Cookie value {1}");

            removeCookie.Click();

            cookies.DeleteAllCookies();
            Console.WriteLine("The site contains {0} cookies", cookies.AllCookies.Count);
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}
