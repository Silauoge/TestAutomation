using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace FinalProject.PAGES
{
    class UogosKrepselisPage : BasePage
    {

        private IWebElement _addItemToCart => Driver.FindElement(By.CssSelector("#products_column > div.product_listing > div:nth-child(4) > div > span"));

        private IWebElement _cookieConsent => Driver.FindElement(By.CssSelector("span.btn:nth-child(2)"));

        private IWebElement _verifyResultCart => Driver.FindElement(By.CssSelector("#cart_items > div > div.data-wrp > div.title > a > span.product_name"));

        public UogosKrepselisPage(IWebDriver webDriver) : base(webDriver) { }

        private const string PageAddress2 = "https://uogauoga.lt/katalogas/veidui/veido-kremai/";

        public void NavigateToDefaultPage2()
        {
                Driver.Url = PageAddress2;
        }

        public void ClickConsent()
        {
            _cookieConsent.Click();

        }

        public void ClickProduct()
        {

            _addItemToCart.Click();
            Thread.Sleep(TimeSpan.FromSeconds(3));

        }

        public void VerifyProduktasKrepselyje(string expectedResult2)
        {

            Assert.That(_verifyResultCart.Text, Is.EqualTo(expectedResult2), "Answer is wrong!");

        }
    }

}


