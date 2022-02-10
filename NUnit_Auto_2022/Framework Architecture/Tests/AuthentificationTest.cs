using NuGet.Frameworks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NUnit_Auto_2022.Framework_Architecture.Tests
{
    class AuthentificationTest : BaseTest
    {
        //string url = FrameworkConstants.GetUrl();

        private static IEnumerable<TestCaseData> GetCredentialsDataCsv()
        {
            string path = "TestData\\credentials.csv";
            using (var reader = new StreamReader(path))
            {
                var index = 0;
                while (!reader.EndOfStream)
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
        }
    }
}