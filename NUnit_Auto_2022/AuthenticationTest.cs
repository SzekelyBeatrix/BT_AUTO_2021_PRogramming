using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace NUnit_Auto_2022
{
    class AuthenticationTest
    {
        IWebDriver driver;

        const string protocol = "http";
        const string hostname = "86.121.249.150";
        const string port = "4999";
        const string path = "/#/";

        string url = protocol + "://" + hostname + ":" + port + path;

        [SetUp]

        public void SetUp()
        {
            //Chrome options
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized"); //- porneste direct maximized
            //options.AddArgument("headless"); - nu vedem in Browser
            options.AddArgument("ignore-certificate-errors");

            var proxy = new Proxy();
            proxy.HttpProxy = "127.0.0.1:8080";
            proxy.IsAutoDetect = false;
            //options.Proxy = proxy;
            //options.AddExtension("C:\\Users\\DELL\\Downloads\\extension_4_42_0_0.crx");

            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize(); //- porneste mic si apoi apasa butonul de maximised - mai ok de folosit

            //Firefox Options
            var firefoxOptions = new FirefoxOptions();
            string[] optionList =
                {
                //"--headless",
                "--ignore-certificate-errors",
                "--no-sandbox", 
                "--disable-gpu"
            };
            firefoxOptions.AddArguments(optionList);
            FirefoxProfile fProfile = new FirefoxProfile();
            fProfile.AddExtension("C:\\Users\\DELL\\Downloads\\metamask-10.8.1-an+fx.xpi");
            firefoxOptions.Profile = fProfile;

            // este ca si la Chrome, doar ca acuma e Firefox
            driver = new FirefoxDriver(firefoxOptions);
            driver.Manage().Window.Maximize();

            //Edge options

            var edgeOptions = new EdgeOptions();
            //edgeOptions.AddExtension("C:\\Users\\DELL\\Downloads\\extension_4_42_0_0.crx");
            edgeOptions.AddArguments("args", "['--start-maximized','--headless']");
            //edgeOptions.AddArguments("headless");

            driver = new EdgeDriver(edgeOptions);
            driver.Manage().Window.Maximize();

        }
        [TestCase("dinosaur", "dinosaurpassword","","")]
        [TestCase("dinosaur","", "","Password is requierd!")]
        [TestCase("", "", "Username is requierd", "Password is requierd!")]
        [TestCase("", "dinopass", "Username is requierd!", "")]

        [Test]
        public void Test01(string user, string pass, string userErr, string passErr)
        {

            Console.WriteLine(url);
            driver.Navigate().GoToUrl(url);

            var pageText = driver.FindElement(By.CssSelector("#root > div > div.content > div > div:nth-child(1) > div > div > h1 > small"));
            Assert.AreEqual("Home", pageText.Text);

            var loginLink = driver.FindElement(By.CssSelector("#root > div > div.sidebar > a:nth-child(2)"));
            loginLink.Click();
            Console.WriteLine(loginLink.GetAttribute("href"));

            pageText = driver.FindElement(By.CssSelector("#root > div > div.content > div > div:nth-child(1) > div > div > h1 > small"));
            Assert.AreEqual("Authentication", pageText.Text);

            var username = driver.FindElement(By.Id("input-login-username"));
            var password = driver.FindElement(By.Id("input-login-password"));
            var submit = driver.FindElement(By.CssSelector("#login-form > div:nth-child(3) > div.text-left.col-lg > button"));

            var usernameError = driver.FindElement(By.CssSelector("#login-form > div:nth-child(1) > div > div > div.text-left.invalid-feedback"));
            var passwordError = driver.FindElement(By.CssSelector("#login-form > div.form-group.row.row-cols-lg-true > div > div > div.text-left.invalid-feedback"));



            username.Clear();
            username.SendKeys(user);

            password.Clear();
            password.SendKeys(pass);

            submit.Submit();

            Assert.AreEqual(userErr, usernameError.Text);
            Assert.AreEqual(passErr, passwordError.Text);
        }
        [Test]

        public void Test02()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            string url = protocol + "://" + hostname + ":8081/lazy.html";
            driver.Navigate().GoToUrl(url);

            var button1 = driver.FindElement(By.Id("btn1"));
            button1.Click();
        }

        //Waituri Implicit= instant/timeout si Explecit= asteapta un moment exact, cat are nevoie - recomandat sa fie utilizat
        //nu pune ambele, alege unul dintre waituri
        //Implicint vf toate elementele din pagina, Explicit= un element ex Terms and conditions
        
        //explicit wait test - la nivelul elemntului
        [Test]
        public void Test03()
        {
            string url = protocol + "://" + hostname + ":8081/lazy.html";
            driver.Navigate().GoToUrl(url);

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            //var button1 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("btn1")));
            var button1 = Utils.WaitForElement(driver, 20, By.Id("btn1"));
            button1.Click();
        }
        [Test]
        public void Test04()
        {
            string url = protocol + "://" + hostname + ":8081/lazy.html";
            driver.Navigate().GoToUrl(url);

            var button2 = Utils.WaitForElement(driver, 15, By.Id("btn2"));
            for(int i = 0; i < 100; i++)
            {
                button2.Click();
            }
            Thread.Sleep(20000); //pausing test execution for 20 seconds!!! Please avoid

        }
        [Test]
       public void Test05()
        {
            string url = protocol + "://" + hostname + ":8081/lazy.html";
            driver.Navigate().GoToUrl(url);

            /*DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(20);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(100);
            fluentWait.Message = "Sorry !! The element in the page can not be found!!";
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            var element = fluentWait.Until(x => x.FindElement(By.Id("btn2")));
            element.Click();*/
            var element = Utils.WaitForElement(driver, 20, By.Id(""));
            element.Click();

        }

        [Test]
        public void Test06()
        {
            driver.Navigate().GoToUrl("https://magazinulcolectionarului.ro/");

            var cookies = driver.Manage().Cookies;
            Console.WriteLine("The site contains {0} cookies", cookies.AllCookies.Count);
            Utils.PrintCookies(cookies);

            Cookie myCookie = new Cookie("myCookie", "vineoaiapapalupu");
            cookies.AddCookie(myCookie);
            Utils.PrintCookies(cookies);

            var ck = cookies.GetCookieNamed("PHPSESSID");
            Console.WriteLine("Cookie name {0} and value {1}", ck.Name, ck.Value);

            cookies.DeleteAllCookies();
            Console.WriteLine("The site contains {0} cookies", cookies.AllCookies.Count);



            var ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("D:\\Bea\\Btransformers\\ScreenshotHM.png", ScreenshotImageFormat.Png);

            Utils.TakeScreenshotWithDate(driver, "D:\\Bea\\Btransformers\\ScreenshotHM.png", "screenshot1.png", ScreenshotImageFormat.Png);
        }

        [Test]
        public void Test07()
        {
            driver.Navigate().GoToUrl("http://86.121.249.150:4999/#/alert");
            var alertButton = driver.FindElement(By.Id("alert-trigger"));
            var confirmButton = driver.FindElement(By.Id("confirm-trigger"));
            var promptButton = driver.FindElement(By.Id("prompt-trigger"));

            alertButton.Click();
            IAlert alert = driver.SwitchTo().Alert();
            Console.WriteLine(alert.Text);
            alert.Accept();

            confirmButton.Click();
            alert = driver.SwitchTo().Alert();
            Console.WriteLine(alert.Text);
            alert.Dismiss();

            promptButton.Click();
            alert = driver.SwitchTo().Alert();
            Console.WriteLine(alert.Text);
            alert.SendKeys("Beatrix");
            alert.Accept();

        }

        [Test]
        public void Test08()
        {
            driver.Navigate().GoToUrl(url + "hover");
            
            var hoverButton = driver.FindElement(By.CssSelector("#root > div > div.content > div > div.container-table.text-center.container > div > button"));
            //var hoverButton = driver.FindElement(By.ClassName("btn btn-outline-info"));


            Actions actions = new Actions(driver);
            actions.MoveToElement(hoverButton).Build().Perform();
            //actions.MoveToElement(hoverButton).Click().Release();
            //IAction action = actions.Build();
            //action.Perform();

            var catSelect = driver.FindElement(By.Id("Cat"));
            catSelect.Click();

            var resultText = driver.FindElement(By.Id("result"));
            Assert.AreEqual("You last clicked the Cat", resultText);

            var allItems = driver.FindElement(By.ClassName("clickable"));
            /*foreach (var item in allItems)
            {
                var text = item.Text;
                var resultTxt = driver.FindElement(By.Id("result"));
                Assert.AreEqual(String.Format("You last clicked me!", text), resultTxt);
            }*/


        }

        [Test]
        public void Test09()
        {
            driver.Navigate().GoToUrl(url + "stale");

            for (int i = 0; i <100; i++)
            {
                var button = driver.FindElement(By.Id("stale-button"));
                button.Click();
            }

            Utils.ExecuteJsScript(driver, "return document.title");
            Utils.ExecuteJsScript(driver, "alertreturn document.title");

        }

        [Test]

        public void Test10()
        {
            driver.Navigate().GoToUrl(url);
            var body = driver.FindElement(By.TagName("body"));
            body.SendKeys(Keys.Control);
            body.SendKeys("t");

            foreach(var handle in driver.WindowHandles)
            {
                driver.SwitchTo().Window(handle);
                Console.WriteLine(handle);
            }
        }

        [Test]
        public void Test11()
        {
            driver.Navigate().GoToUrl("https://www.vexio.ro/account/login/#login");

            var iframe = driver.FindElement(By.TagName("iframe"));

            driver.SwitchTo().Frame(iframe);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
