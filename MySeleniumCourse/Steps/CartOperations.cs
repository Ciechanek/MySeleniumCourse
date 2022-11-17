using OpenQA.Selenium;
using System;
using System.Collections.Generic;
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
    }
}
