using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MySeleniumCourse
{
    public class BaseTest
    {
        public WebDriver webDriver;

        [SetUp]
        public void LaunchDriver()
        {
            webDriver = new ChromeDriver();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }

        [TearDown]
        public void QuitDriver()
        {
            webDriver.Quit();
        }
    }
}