
using NUnit_Auto_2022.PageModels.POM;
using NUnit_Auto_2022.PageModels.PageFactory;
using NUnit_Auto_2022.PageModels.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace NUnit_Auto_2022.Tests
{
    class AuthTest :BaseTest
    {

        string url = FrameworkConstants.GetUrl();

        //not recomended
        private static IEnumerable<TestCaseData> GetCredentialsData()
        {
            yield return new TestCaseData("user1", "pass1");
            yield return new TestCaseData("user2", "pass2");
            yield return new TestCaseData("user3", "pass3");
            yield return new TestCaseData("user4", "pass4");
        }

        //recomended
        private static IEnumerable<TestCaseData>GetCredentialsDataCsv()
        {
            string path = "TestData\\credentials.csv";
            using (var reader = new StreamReader(path))
            {
                var index = 0;
                while(!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    if (index > 0)
                    {
                        yield return new TestCaseData(values[0], values[1]);
                    }
                    index++;
                }
            }
        }

        //reutilizabil
        private static IEnumerable<TestCaseData> GetCredentialsDataCsv2()
        {
            foreach (var values in Utils.GetGenericData("TestData\\credentials.csv"))
            {
                yield return new TestCaseData(values);
            }


            //var path = "TestData\\credentials.csv";

            /*var lines = File.ReadAllLines(path).Select(a => a.Split(',')).Skip(1);
            foreach (var values in lines.ToArray())
            {
                yield return new TestCaseData(values[0], values[1]);
            }*/
        }

        // Test auth with Page Object model
        [Test, TestCaseSource("GetCredentialsDataCsv2")]
        //[TestCase("user1","pass1")]
        //[TestCase("user2","pass2")]
        //[TestCase("user3","pass3")]
        //[TestCase("user44","pass4")]
        public void BasicAuth(string username, string password)
        {
            driver.Navigate().GoToUrl(url + "login");
            // This is beacuse we have 2 classes named LoginPage one on POM other on PageFactory
            // In real life framework you will have just one type of desigm pattern (POM/PF)
            PageModels.POM.LoginPage lp = new PageModels.POM.LoginPage(driver);
            Assert.AreEqual("Authentication", lp.CheckPage());
            lp.Login(username, password);
        }

        private static string[] GetUsername = new string[]
        {
            "user1","user2","user3","user4"
        };
        private static string[] GetPassword = new string[]
        {
            "pass1","pass2","pass3","pass4",
        };

        // Test auth with Page factory
        [Test]
        public void BasicAuthPf([ValueSource("GetUsername")]string username,[ValueSource("GetPassword")]string password)
        {
           driver.Navigate().GoToUrl(url + "login");
           PageModels.PageFactory.LoginPage lp = new PageModels.PageFactory.LoginPage(driver);
           Assert.AreEqual("Authentication", lp.CheckPage());
           lp.Login(username, password);
        }
      
    }
}
