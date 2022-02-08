using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NUnit_Auto_2022
{
    public class Utils
    {
        public static IWebElement WaitForElement(IWebDriver driver, int seconds, By locator)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));

        }
        public static IWebElement WaitForFluentElement(IWebDriver driver, int seconds, By locator)
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver)
            {
                Timeout = TimeSpan.FromSeconds(seconds),
                PollingInterval = TimeSpan.FromMilliseconds(100),
                Message = "Sorry !! The element in the page cannot be found!"
            };
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            return fluentWait.Until(x => x.FindElement(locator));
        }
        public static void PrintCookies(ICookieJar cookies)
        {

            foreach (Cookie c in cookies.AllCookies)
            {
                Console.WriteLine("Cookie name{0} = cookie value{1}", c.Name, c.Value);
            }
        }
        /// <summary>
        /// The method creates a screenshot based on the current date and save it into a folder defined
        /// </summary>
        /// <param name="driver">The Webdriver instance / browser from which the screenshot will be taken</param>
        /// <param name="path">The path where the screenshot will besaved</param>
        /// <param name="fileName">The base file</param>
        /// <param name="format"></param>
        public static void TakeScreenshotWithDate(IWebDriver driver, string path, string fileName, ScreenshotImageFormat format)

        {
            DirectoryInfo validation = new DirectoryInfo(path);//daca nu exista folderul, il creeaza
            if (!validation.Exists)
            {
                validation.Create();
            }

            string currentDate = DateTime.Now.ToString();
            StringBuilder sb = new StringBuilder(currentDate);
            sb.Replace(":", "_");
            sb.Replace(".", "_");
            sb.Replace("", "_");
            string finalfilePath = String.Format("{0}\\{1}_{2}.{3}", path, fileName, sb.ToString(), format);
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(path + "\\" + fileName, format);
            
            
        }

        public static void ExecuteJsScript(IWebDriver driver, string script)
        {
            var jsExecutor = (IJavaScriptExecutor)driver;
            var result = jsExecutor.ExecuteScript(script);
            if (result != null)
            {
                Console.WriteLine(result.ToString());
            }
        }
    
        /// <summary>
        /// Converts a config file that has lines like keyvalue into a Dictionary with key and value
        /// </summary>
        /// <param name="configFilePath">The path of the config file</param>
        /// <returns>A dictionary with akey value pair of type string and string representing the lines</returns>
        public static Dictionary<string,string> ReadConfig(string configFilePath)
        {
            var configData = new Dictionary<string, string>();
            foreach(var line in File.ReadAllLines(configFilePath))
            {
                string[] values = line.Split('=');
                configData.Add(values[0].Trim(),values[1].Trim());
            }
            return configData;
        }

        public static string[] GetGenericData(string path)
        {
            var lines = File.ReadAllLines(path).Select(a => a.Split(',')).Skip(1);
            foreach (var values in lines.ToArray())
            {
                return values;
            }
            return null;
        }

    }
}