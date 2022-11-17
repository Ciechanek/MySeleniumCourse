using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySeleniumCourse;
using OpenQA.Selenium;

namespace MySeleniumCourse.Steps
{
    public class AddingItemsToCart
    {
        public void AddToCartSotaventaLimnos(WebDriver driver)
        {
            driver.FindElement(By.CssSelector("li[class*='post-393']>a[href*='add-to-cart']")).Click();
            driver.FindElement(By.CssSelector("li[class*='post-391']>a[href*='add-to-cart']")).Click();
        }
    }
}
