using NUnit.Framework;
using NUnit_Auto_2022.Utilities;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NUnit_Auto_2022.FrameworkArchitecture.Tests.TestAPI
{
    class DirectionsAPI
    {
        RestClient client = new RestClient();
 
        string to = "Mangalia";
        string from = "Bucharest";
        //string url = "http://www.mapquestapi.com/directions/v2/route?key=hBsAkgDCTuPV2azxfTtUOyNLRPVSXWnr&from=Mangalia&to=Bucharest";

        private string GetUrl(string queryParams)
        {
            return String.Format("{0}&to={1}&from={2}", FrameworkConstants.GetApiUrl(),to, from );
        }

        private static IEnumerable<TestCaseData> GetRequestData()
        {
            string path = "NUnit_Auto_2022\\ApiTestData\\directionsData.csv"; //citim din fisier
            var lines = File.ReadAllLines(path).Select(a => a.Split(',')); //luam linie cu linie, spargem prin ,
            string[] header = lines.ElementAt(0).ToArray(); //prima linie este header(denumire)
            for (int i = 1; i <lines.Count(); i++)
            {
                var currentValues = lines.ElementAt(i).ToArray();
                Dictionary<string, string> queryParams = new Dictionary<string, string>();
                for (int j = 0; j < currentValues.Count(); j++)
                {
                    queryParams.Add(header[j], currentValues[j]);
                }
                yield return new TestCaseData(queryParams);
            }

        }

        [Test, TestCaseSource("GetRequestData")]
        public void Test01(Dictionary<string,string> queryParams)
        {
            /*Dictionary<string, string> queryParams = new Dictionary<string, string>();
            queryParams.Add("to", to);
            queryParams.Add("from", from);
            queryParams.Add("outformat", "json");
            queryParams.Add("unit", "k");*/
            string url = GetUrl(Utils.ConvertDictionaryToQuery(queryParams));
            //Console.WriteLine(Utils.ConvertDictionaryToQuery(queryParams));
            var request = new RestRequest(url, Method.Get);
            var response = client.GetAsync(request);
            var responseContent = response.Result.Content;
            //Console.WriteLine(responseContent);

            
            
           
        }
    }
}
