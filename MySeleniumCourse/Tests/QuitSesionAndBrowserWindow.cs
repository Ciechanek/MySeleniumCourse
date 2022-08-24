using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MySeleniumCourse.Tests
{
    public class QuitSesionAndBrowserWindow : BaseTest
    {
        [Test]
        public void QuitSessionAndBrowser()
        {
            webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            webDriver.Navigate().GoToUrl("https://pl.wikipedia.org/wiki/Wikipedia:Strona_g%C5%82%C3%B3wna");
            webDriver.Navigate().GoToUrl("https://www.nasa.gov/");
            webDriver.Navigate().Back();
            webDriver.Navigate().Forward();
            Assert.AreEqual("https://www.nasa.gov/", webDriver.Url, "Url of the page should be https://www.nasa.gov/, but is " + webDriver.Url);
            webDriver.Close();
            webDriver.Quit();
        }
    }
}
