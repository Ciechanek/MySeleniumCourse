using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using System;
using OpenQA.Selenium.Interactions;

namespace MySeleniumCourse.Tests
{
    public class ChildrenSiblingTests : BaseTest
    {
        [Test]
        public void TestsOFChildrenAndSiblings()
        {
            webDriver.Navigate().GoToUrl("https://fakestore.testelka.pl/");
            webDriver.FindElement(By.CssSelector("a[class='woocommerce-store-notice__dismiss-link']")).Click();
            webDriver.FindElement(By.CssSelector("li[class*='post-393']>a[href*='add-to-cart']")).Click();
            Thread.Sleep(2000);
            webDriver.Navigate().GoToUrl("https://fakestore.testelka.pl/product-category/windsurfing/");
            webDriver.FindElement(By.CssSelector("header.woocommerce-products-header+div select"));
            webDriver.FindElement(By.CssSelector("a[title='Zobacz zawartość koszyka']")).Click();
            webDriver.FindElement(By.CssSelector(".cart-contents>span.woocommerce-Price-amount"));
        }
    }
}
