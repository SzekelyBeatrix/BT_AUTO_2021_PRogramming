using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.Utilities
{
    public class Browser
    {
        public static IWebDriver GetDriver(WebBrowsers browserType, string HttpProxy, bool IsAutoDetect)
        {
            switch (browserType)
            {
                case WebBrowsers.Chrome:
                    {
                        //Chrome options, Instantiate Chrome driver
                        var options = new ChromeOptions();
                        // Options for the driver based on flags from FrameworkConstants
                        if (FrameworkConstants.startMaximized)
                        {
                            options.AddArgument("--start-maximized"); //- porneste direct maximized
                                                                      //options.AddArgument("headless"); - nu vedem in Browser
                        }
                        if (FrameworkConstants.startHeadless)
                        {
                            options.AddArgument("headless");
                        }
                        if (FrameworkConstants.ignoreCertErr)
                        {
                            options.AddArgument("ignore-certificate-errors");
                        }

                        // Proxy definition
                        var proxy = new Proxy
                        {
                            HttpProxy = FrameworkConstants.browserProxy,
                           IsAutoDetect = false
                        };
                        if (FrameworkConstants.useProxy)
                        {
                            options.Proxy = proxy;
                        }

                        // Intiatiate chrome driver with options
                        return new ChromeDriver(options);
                    }

                case WebBrowsers.Firefox:
                    {
                        // Defining the firefox options based on the flags in the Framework constants
                        var firefoxOptions = new FirefoxOptions();
                        List<string> optionList = new List<string>();

                       if  (FrameworkConstants.startHeadless)
                        {
                            optionList.Add("--headless");
                        }
                       if (FrameworkConstants.ignoreCertErr)
                        {
                            optionList.Add("--ignore-certificate-errors");
                        }
                            firefoxOptions.AddArguments(optionList);
                        FirefoxProfile fProfile = new FirefoxProfile();

                        // Adding extension if the option is enabled in FrameworkCOnstants
                        if (FrameworkConstants.startWithExtension)
                        {
                            fProfile.AddExtension(FrameworkConstants.GetExtensionName(browserType));
                        }
                        firefoxOptions.Profile = fProfile;
                        // Instantiate Frefix driver with options
                        return new FirefoxDriver(firefoxOptions);
                    }
                case WebBrowsers.Edge:
                    {
                        // Adding edge options based on the flags in the FrameWorkConstants
                        var edgeOptions = new EdgeOptions();
                        //edgeOptions.AddExtension("C:\\Users\\DELL\\Downloads\\extension_4_42_0_0.crx");
                        //edgeOptions.AddArguments("args", "['--start-maximized','--headless']");
                        if (FrameworkConstants.startMaximized)
                        {
                            edgeOptions.AddArgument("--start-maximized");
                        }
                        if (FrameworkConstants.startHeadless)
                        {
                            edgeOptions.AddArgument("headless");
                        }
                        if (FrameworkConstants.startWithExtension)
                        {
                            edgeOptions.AddArgument(FrameworkConstants.GetExtensionName(browserType));
                        }

                        // Instatiate Edge driver with options defined
                        return new EdgeDriver(edgeOptions);
                    }
                default:
                    {
                        // If the driver specified is not implemented
                        throw new BrowserTypeException(browserType.ToString());
                    }
            }

            
        }

        internal static IWebDriver GetDriver(WebBrowsers chrome)
        {
            throw new NotImplementedException();
        }
    }
    // Browser Enum with the suported browser types
    public enum WebBrowsers
    {
        Chrome,
        Firefox,
        Edge
    }
}
