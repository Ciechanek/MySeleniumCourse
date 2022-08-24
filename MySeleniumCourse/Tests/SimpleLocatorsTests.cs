using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace MySeleniumCourse.Tests
{
    public class SimpleLocatorsTests : BaseTest
    {
        [Test]
        public void LocatingSimpleLocators()
        {
            webDriver.Navigate().GoToUrl("http://fakestore.testelka.pl/moje-konto/");
            webDriver.FindElement(By.ClassName("entry-title"));
            webDriver.FindElement(By.Id("username"));
            webDriver.FindElement(By.Name("password"));
            webDriver.FindElement(By.ClassName("woocommerce-form__input-checkbox"));
            webDriver.FindElement(By.Name("login"));
            webDriver.FindElement(By.PartialLinkText("Nie pam"));
        }
    }
}
