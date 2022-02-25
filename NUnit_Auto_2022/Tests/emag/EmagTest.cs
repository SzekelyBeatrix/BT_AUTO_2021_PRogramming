using NUnit.Framework;
using NUnit_Auto_2022.PageModels.POM;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.Tests.emag
{
    class EmagTest : BaseTest
    {
        [Test]
        public void Test01()
        {
            _driver.Navigate().GoToUrl("https://emag.ro");
        }
    }
}
