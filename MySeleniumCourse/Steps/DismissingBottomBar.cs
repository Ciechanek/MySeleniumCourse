using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySeleniumCourse.Steps
{
    public class DismissingBottomBar
    {
        public void CloseBottomBar(WebDriver driver)
        {
            driver.FindElement(By.CssSelector("a[class='woocommerce-store-notice__dismiss-link']")).Click();
        }
    }
}
