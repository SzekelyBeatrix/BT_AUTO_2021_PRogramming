using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.Framework_Architecture.Utilities
{
    public class FrameworkConstants2
    {
        /* static Dictionary<string, string> configData = Utils.ReadConfig("config.properties");
         static string protocol = configData["protocol"];
         static string hostname = configData["hostname"];
         static string port = configData["port"];
         static string path = configData["path"];*/

        const string protocol = "http";
        const string hostname = "86.121.249.150";
        const string port = "4999";
        const string path = "/#/registration";

        public static string GetUrl()
        {
            return String.Format("{0}://{1}:{2}{3}", protocol, hostname, port, path);
        }
    }
}
