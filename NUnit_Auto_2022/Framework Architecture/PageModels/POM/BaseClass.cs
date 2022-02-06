using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.Framework_Architecture.PageModels.POM
{
    class BaseClass
    {
        public class BasePage
        {
            public IWebDriver driver;

            public BasePage(IWebDriver driver)
            {
                this.driver = driver;
            }


        }
    }
}
