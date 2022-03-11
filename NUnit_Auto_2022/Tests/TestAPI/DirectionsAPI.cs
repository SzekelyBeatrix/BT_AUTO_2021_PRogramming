using Newtonsoft.Json.Linq;
using NUnit.Framework;
using NUnit_Auto_2022.PageModels.APIModels;
using NUnit_Auto_2022.Utilities;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace NUnit_Auto_2022.FrameworkArchitecture.Tests.TestAPI
{
    class DirectionsAPI
    {
        RestClient client = new RestClient();

        //string url = "http://www.mapquestapi.com/directions/v2/route?key=hBsAkgDCTuPV2azxfTtUOyNLRPVSXWnr&from=Mangalia&to=Bucharest";

        private string GetUrl(string queryParams)
        {
            return String.Format("{0}{1}", FrameworkConstants.GetApiUrl(), queryParams);
        }

        private static IEnumerable<TestCaseData> GetRequestData()
        {
            var paramsList = Utils.ConvertCsvToDictionary("TestDataAPI\\directionsData.csv");
            var resultsList = Utils.ConvertCsvToDictionary("TestDataAPI\\directionsValidations.csv");

            if (paramsList.Count == resultsList.Count)
            {
                for (int i = 0; i < paramsList.Count; i++)
                {
                    yield return new TestCaseData(paramsList[i], resultsList[i]);
                }
            }
            else
            {
                Console.WriteLine("There is a test data / test validation count consistency");
            }
        }

        private MapQuestRequestModel GetPostData(Dictionary<string, string> kvp)
        {
            MapQuestOptionsModel mapOptions = new MapQuestOptionsModel
            {
                unit = kvp["unit"],
                avoids = new List<string>(),
                avoidTimedConditions = false,
                doReverseGeocode = true,
                drivingStyle = 2,
                enhancedNarrative = false,
                generalize = 0,
                highwayEfficiency = 21.0f,
                locale = "en_US",
                routeType = "fastes",
                shapeFormat = "raw",
                timeType = 1
            };
            MapQuestRequestModel request = new MapQuestRequestModel
            {
                locations = new List<string>
                {
                    kvp ["to"],
                    kvp["from"]
                },
                options = mapOptions
            };
            return request;
        }

        // POST Request to server
        [Test, TestCaseSource("GetRequestData")]
        public void Test02(Dictionary<string, string> queryParams, Dictionary<string, string> results)
        {

            Dictionary<string, string> postQueryParams = new Dictionary<string, string>();
            postQueryParams.Add("outFormat", queryParams["outFormat"]);
            string url = GetUrl(Utils.ConvertDictionaryToQuery(postQueryParams));
            string jsonBody = System.Text.Json.JsonSerializer.Serialize(GetPostData(queryParams));
            var request = new RestRequest(url, Method.Post);
            request.AddParameter("application/json;charset=utf-8", jsonBody, ParameterType.RequestBody);
            request.RequestFormat = DataFormat.Json;
            var response = client.PostAsync(request);
            //Console.WriteLine(response.Result.Content);
            // Same validations / assertion code as for the Test01 (Get method)
        }


        [Test, TestCaseSource("GetRequestData")]
        public void Test01(Dictionary<string, string> queryParams, Dictionary<string, string> results)
        {

            string url = GetUrl(Utils.ConvertDictionaryToQuery(queryParams));
            //Console.WriteLine(Utils.ConvertDictionaryToQuery(queryParams));
            var request = new RestRequest(url, Method.Get);
            var response = client.GetAsync(request);
            var responseContent = response.Result.Content;
            Console.WriteLine(url);
            string outFormat = queryParams["outformat"];
            switch (outFormat)
            {
                case "json":
                    {
                        var json = JObject.Parse(responseContent);

                        Assert.AreEqual(results["distance"], json.SelectToken("$..route.distance").ToString().Replace(",", "."));
                        Assert.AreEqual(results["formattedTime"], json.SelectToken("$..route.formattedTime").ToString().Replace(",", "."));

                        break;
                    }
                case "xml":
                    {
                        XmlDocument doc = new XmlDocument();
                        doc.LoadXml(responseContent);
                        Console.WriteLine(responseContent);
                        XmlNode distance = doc.SelectSingleNode("/response/route/distance");
                        XmlNode formattedTime = doc.SelectSingleNode("/response/route/distance");
                        Assert.AreEqual(results["distance"], distance.InnerText);
                        Assert.AreEqual(results["formattedTime"], formattedTime.InnerText);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Outformat should be xml or json");
                        break;
                    }
            }






        }




    }

}

