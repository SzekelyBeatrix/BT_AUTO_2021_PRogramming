using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.Framework_Architecture.Utilities
{
    public class FrameworkConstants
    {

        public const string protocol = "http";
        public const string hostname = "86.121.249.150";
        public const string port = "4999";
        public const string path = "/#/";

        public static string GetUrl()
        {
            return String.Format("{0}://{1}:{2}{3}", protocol, hostname, port, path);
        }
    }
}
