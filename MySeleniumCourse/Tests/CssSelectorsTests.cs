using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySeleniumCourse.Tests
{
    public class CssSelectorsTests : BaseTest
    {
        [Test]
        public void TestOfCssSelectors()
        {
            webDriver.Navigate().GoToUrl("https://fakestore.testelka.pl/moje-konto/");
            webDriver.FindElement(By.CssSelector("[class='woocommerce-Input woocommerce-Input--text input-text'][name='username']"));
            webDriver.FindElement(By.CssSelector("[class='woocommerce-Input woocommerce-Input--text input-text'][name='password']")); //haslo logowania
            webDriver.FindElement(By.CssSelector("input[class='woocommerce-form__input woocommerce-form__input-checkbox']")); //checkbox zapamietaj mnie
            webDriver.FindElement(By.CssSelector("button[name='login']"));
            webDriver.FindElement(By.CssSelector("a[href='https://fakestore.testelka.pl/moje-konto/zapomniane-haslo/']"));
            webDriver.FindElement(By.CssSelector("#reg_email"));
            webDriver.FindElement(By.CssSelector("#reg_password"));
            webDriver.FindElement(By.CssSelector("button[class='woocommerce-Button woocommerce-button button woocommerce-form-register__submit']"));
            webDriver.FindElement(By.CssSelector("a[href='https://fakestore.testelka.pl/product-category/windsurfing/']"));
        }
    }
}