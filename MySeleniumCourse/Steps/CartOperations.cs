using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySeleniumCourse.Steps
{
    public class CartOperations
    {
        public void SelectCartIcon(WebDriver driver)
        {
            driver.FindElement(By.CssSelector("span.woocommerce-Price-amount")).Click();
        }

        public void FindPriceOfFuerteventura(WebDriver driver)
        {
            driver.FindElement(By.XPath(".//a[@data-product_id='393']/../..//span[@class='woocommerce-Price-amount amount']"));
        }

        public void FindTotalPriceOfCart(WebDriver driver)
        {
            driver.FindElement(By.XPath(".//div[@class='cart_totals ']//span[@class='woocommerce-Price-amount amount']"));
        }
    }
}