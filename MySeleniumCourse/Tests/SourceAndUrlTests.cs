using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MySeleniumCourse.Tests
{
    public class SourceAndUrlTests : BaseTest
    {
        [Test]
        public void GetSourceAndTitleOfThePageTest()
        {
            webDriver.Navigate().GoToUrl("https://www.saucedemo.com/");
            Assert.AreEqual("https://www.saucedemo.com/", webDriver.Url, "Url of the page should be https://www.saucedemo.com/, but is " + webDriver.Url);
            Assert.That(webDriver.Title, Is.EqualTo("Swag Labs"), "Title of the page is invalid");
            //testline
        }
    }
}
