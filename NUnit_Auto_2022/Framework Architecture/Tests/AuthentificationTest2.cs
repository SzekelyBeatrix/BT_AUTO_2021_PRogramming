using NuGet.Frameworks;
using NUnit.Framework;
using NUnit_Auto_2022.Framework_Architecture.PageModels.POM;
using NUnit_Auto_2022.Framework_Architecture.Utilities;
using NUnit_Auto_2022.PageModels.POM;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace NUnit_Auto_2022.Framework_Architecture.Tests
{
    class AuthentificationTest2 : BaseTest
    {
        string url = FrameworkConstants2.GetUrl();

        /* [Test, TestCaseSource("GetCredentialsCsv")]
        public static IEnumerable<TestCaseData> GetCredentialsCsv()
         {
             string path = "Framework_Architecture2.TestData\\Credentials.csv";
             using (var reader = new StreamReader(path))
             {
                 var index = 0;
                 while (!reader.EndOfStream)
                 {
                     var line = reader.ReadLine();
                     var values = line.Split(',');
                     if (index > 0)
                     {
                         yield return new TestCaseData(values[0], values[1], values[2], values[3], values[4], values[5], values[6], values[7]);
                     }
                     index++;
                 }
             }
         }
         [Test, TestCaseSource("GetCredentialsDataCsHM")] */
        /* public static IEnumerable<TestCaseData> GetCredentialsDataCsHM()
         {
             foreach (var values in Utils.GetGenericData("Framework_Architecture2.TestData\\Credentials.csv"))
             {
                 yield return new TestCaseData(values);
             }
         }*/

        [Test, TestCaseSource("GetCredentialsDataCsv3")]
        public static IEnumerable<TestCaseData> GetCredentialsDataCsv3()
        {
            var csvData = Utils.GetDataTableFromCsv("Framework_Architecture.TestData2\\Credentials.csv");
            for (int i = 0; i < csvData.Rows.Count; i++)
            {
                yield return new TestCaseData(csvData.Rows[i].ItemArray);
            }
        }

        [Test, TestCaseSource("GetCredentialsDataExcel")]
        public static IEnumerable<TestCaseData> GetCredentialsDataExcel()
        {
            var excelData = Utils.GetDataTableFromExcel("TestData2\\Credentials.xlsx");
            for (int i = 1; i < excelData.Rows.Count; i++)
            {
                yield return new TestCaseData(excelData.Rows[i].ItemArray);
            }
        }

        [Test, TestCaseSource("GetCredentialsDataJson")]
        public static IEnumerable<TestCaseData> GetCredentialsDataJson()
        {
            var credentials = Utils.JsonRead<DataModels.Credentials>("TestData2\\Credentials.json");
            yield return new TestCaseData(credentials.Username, credentials.Password);
        }

        [Test, TestCaseSource("GetCredentialsDataXml")]
        public static IEnumerable<TestCaseData> GetCredentialsDataXml()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(DataModels.Credentials));
            foreach (var file in Utils.GetAllFilesInFolderExt("TestData2\\", "*.xml"))
            {
                Console.WriteLine("Testing with file: " + file);
                using (Stream reader = new FileStream(file, FileMode.Open))
                {
                    var credentials = (DataModels.Credentials)serializer.Deserialize(reader);
                    yield return new TestCaseData(credentials.Username, credentials.Password);
                }
            }


        }

        public void BasicRegistration(string user, string passw, string confPass, string fName, string lName, string mail, string dateOfb, string nation)
        {
            driver.Navigate().GoToUrl(url + "registration");
            PageModels.POM.RegistrationPagePOM rp = new PageModels.POM.RegistrationPagePOM(driver);
            Assert.AreEqual("Registration", rp.CheckPage());
            rp.Registration(user,passw,confPass,fName,lName, mail,dateOfb,nation);
        }
        private static string[] GetUsername = new string[]
        {
            "user1", "user2", "user3", "user4"
        };

        private static string[] GetPassword = new string[]
        {
            "pass1", "pass2", "pass3", "pass4"
        };
        private static string[] GetConfPass = new string[]
        {
            "confpass1", "user2", "user3", "user4"
        };

        private static string[] GetFName = new string[]
        {
            "pass1", "pass2", "pass3", "pass4"
        };
        private static string[] GetLName = new string[]
       {
            "pass1", "pass2", "pass3", "pass4"
       };
        private static string[] GetMail = new string[]
       {
            "pass1", "pass2", "pass3", "pass4"
       };
        private static string[] GetDateOfb = new string[]
      {
            "pass1", "pass2", "pass3", "pass4"
      };
        private static string[] GetNation = new string[]
      {
            "pass1", "pass2", "pass3", "pass4"
      };

 
    }
   
}