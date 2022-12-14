using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MySeleniumCourse.Steps;
using System.Threading;

namespace MySeleniumCourse.Tests
{
    public class XPathTests : BaseTest
    {
        private AddingItemsToCart addingItemsToCart = new AddingItemsToCart();
        private DismissingBottomBar dismissingBottomBar = new DismissingBottomBar();
        private CartOperations cartOperations = new CartOperations();
        private PaymentOperations paymentOperations = new PaymentOperations();

        [Test]
        public void TestsOfXPaths()
        {
            webDriver.Navigate().GoToUrl("https://fakestore.testelka.pl");
            dismissingBottomBar.CloseBottomBar(webDriver);
            addingItemsToCart.AddToCartSotaventaLimnos(webDriver);
            Thread.Sleep(2000);
            cartOperations.SelectCartIcon(webDriver);
            paymentOperations.SelectCheckoutButton(webDriver);
            paymentOperations.FindFirstProductNameOnCheckout(webDriver);
        }

        [Test]
        public void TestOfXPathRelations()
        {
            webDriver.Navigate().GoToUrl("https://fakestore.testelka.pl");
            dismissingBottomBar.CloseBottomBar(webDriver);
            addingItemsToCart.AddToCartSotaventaLimnos(webDriver);
            addingItemsToCart.WaitToShowCartButtonUnderLimnosIsShown(webDriver);
            cartOperations.SelectCartIcon(webDriver);
            cartOperations.FindPriceOfFuerteventura(webDriver);
            cartOperations.FindTotalPriceOfCart(webDriver);
        }
    }
}