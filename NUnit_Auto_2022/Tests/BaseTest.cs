using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit_Auto_2022.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace NUnit_Auto_2022.PageModels.POM
{
    class BaseTest
    {
        ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();
        public IWebDriver _driver;
        public static ExtentReports _extent;
        public ExtentTest _test;
        public string testName;
        public static string conDetails;

        [OneTimeSetUp]
        protected void ExtentStart() //reutilizabil
        {
            //path to the location to the test that are running
            var path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            var actualPath = path.Substring(0, path.LastIndexOf("bin")); //get bin folder
            var projectPath = new Uri(actualPath).LocalPath;
            Directory.CreateDirectory(projectPath.ToString() + "Reports"); //a creat folderul
            DateTime time = DateTime.Now;// ca sa putem diferentia rezultatele
            var reportPath = projectPath + "Reports\\report.html" + time.ToString("h_mm_ss")+ ".html";
            var htmlReporter = new ExtentHtmlReporter(reportPath);
            _extent = new ExtentReports();
            _extent.AttachReporter(htmlReporter);
            _extent.AddSystemInfo("Host Name", Environment.MachineName);
            _extent.AddSystemInfo("Environment", "Test ENV");
            _extent.AddSystemInfo("Username","Beatrix SZ");
            htmlReporter.LoadConfig(projectPath + "report-config.xml");
        }

        // Before each test
        [SetUp]
        public void Setup()
        {
            // Instatiate the browser using the Browser Factory class created in Utilities
            _driver = Browser.GetDriver(WebBrowsers.Chrome);

            DataModels.DbConnString connString = Utils.JsonRead<DataModels.DbConnString>("appsetings.json");
            driver.Value = Browser.GetDriver();
            _driver = driver.Value;
        }

        // After each test
        [TearDown]
        public void Teardown()
        {
            var currentStatus = TestContext.CurrentContext.Result.Outcome.Status; //current test status (PASS/FAIL/incoclusived...etc)
            bool passed = TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Passed;
            var currentStackTrace = TestContext.CurrentContext.Result.StackTrace;
            var stackTrace = string.IsNullOrEmpty(currentStackTrace) ? "" : currentStackTrace;
            Status logstatus = Status.Pass;
            String filename, screenshotPath;
            DateTime time = DateTime.Now;
            filename = "SShot_" + time.ToString("HH_mm_ss") + testName + ".png";
            switch(currentStatus)
            {
                case NUnit.Framework.Interfaces.TestStatus.Failed:
                    {
                        logstatus = Status.Fail;
                        var screenshotEntity = Utils.CaptureScreenshot(_driver, filename);
                        _test.Log(Status.Fail, "Fail");
                        _test.Fail("Test failed: ", screenshotEntity);
                       // _test.Log (Status.Fail, _test.AddScreenCaptureFromPath("Screenshots\\ + filename"))
                        break;
                     }
                case NUnit.Framework.Interfaces.TestStatus.Passed:
                    {
                        logstatus = Status.Pass;
                        _test.Log(Status.Pass, "Pass");
                        _test.Pass("Test passed: ", Utils.CaptureScreenshot(_driver, filename));
                         break;
                    }
                case NUnit.Framework.Interfaces.TestStatus.Inconclusive:
                    {
                        logstatus = Status.Warning;
                        _test.Log(Status.Warning, "Test is inconclusive");
                        break;
                    }
                case NUnit.Framework.Interfaces.TestStatus.Skipped:
                    {
                        logstatus = Status.Skip;
                        _test.Log(Status.Skip, "Test is skipped");
                        break;
                    }
                default:
                    {
                        logstatus = Status.Error;
                        _test.Log(Status.Error, "The test had errors while running");
                        break;
                    }
                    _test.Log(logstatus, "Test" + testName + "was" + logstatus + "\n" + stackTrace);
            }

            _driver.Quit();

            //cea de sub este aceeasi cu ce avem sus in one liner var stracTrace = 
            /*if (string.IsNullOrEmpty(currentStackTrace))
            {
                stackTrace = "";
            }
            else
            {
                stackTrace = currentStackTrace;
            }*/



        }
        [OneTimeTearDown]
        public void AllTearDown()
        {
            //writes/saves report.html on the disk
            _extent.Flush();
        }
    }
}
