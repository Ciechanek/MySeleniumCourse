using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySeleniumCourse.Steps
{
    public class PaymentOperations
    {
        public void SelectCheckoutButton(WebDriver driver)
        {
            driver.FindElement(By.CssSelector("a.checkout-button")).Click();
        }

        public void FindFirstProductNameOnCheckout(WebDriver driver)
        {
            //driver.FindElement(By.XPath(".//table[@class='shop_table']//td[@class='product-name']"));
            driver.FindElement(By.XPath(".//table[contains(@class, 'shop_table')]//td[contains(@class, 'product-name')]"));
        }
    }
}
