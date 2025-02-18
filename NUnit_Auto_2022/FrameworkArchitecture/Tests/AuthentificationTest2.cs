﻿using NuGet.Frameworks;
using NUnit.Framework;
using NUnit_Auto_2022.FrameworkArchitecture.PageModels.POM;
using NUnit_Auto_2022.FrameworkArchitecture.Utilities;
using NUnit_Auto_2022.PageModels.POM;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace NUnit_Auto_2022.FrameworkArchitecture.Tests
{
    class AuthentificationTest2 : BaseTest
    {
        string url = FrameworkConstants2.GetUrl();

        [Test, TestCaseSource("GetCredentialsDataCsv")]
        public static IEnumerable<TestCaseData> GetCredentialsDataCsv()
        {
            var csvData = Utils.GetDataTableFromCsv("FrameworkArchitecture\\TestData2\\Credentials2.csv");
            for (int i = 0; i < csvData.Rows.Count; i++)
            {
                yield return new TestCaseData(csvData.Rows[i].ItemArray);
            }
        }
        
       [Test, TestCaseSource("GetDataExcel")]
        public static IEnumerable<TestCaseData> GetDataExcel()
        {
            var excelData = Utils.GetDataTableFromExcel("TestData2\\Credentials.xlsx");
            for (int i = 1; i < excelData.Rows.Count; i++)
            {
                yield return new TestCaseData(excelData.Rows[i].ItemArray);
            }
        }

        [Test, TestCaseSource("GetDataJson")]
        public static IEnumerable<TestCaseData> GetDataJson()
        {
            var Credentials = Utils.JsonRead<DataModels.Credentials2>("TestData2\\Credentials.json");
            yield return new TestCaseData(Credentials.Username, Credentials.Password, Credentials.ConfirmPassword, Credentials.FirstName, Credentials.LastName, Credentials.Email, Credentials.Dob, Credentials.Nationality);
        }

        [Test, TestCaseSource("GetDataXml")]
        public static IEnumerable<TestCaseData> GetDataXml()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(DataModels.Credentials2));
            foreach (var file in Utils.GetAllFilesInFolderExt("TestData2\\", "*.xml"))
            {
                Console.WriteLine("Testing with file: " + file);
                using (Stream reader = new FileStream(file, FileMode.Open))
                {
                    var credentials = (DataModels.Credentials2)serializer.Deserialize(reader);
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