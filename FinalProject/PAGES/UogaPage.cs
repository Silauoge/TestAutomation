using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace FinalProject.PAGES
{
        class UogaPage : BasePage
        {

        private IWebElement _chooseToolbarElement=> Driver.FindElement(By.CssSelector("#pages_mega_menu > ul > li:nth-child(3) > div > span"));

        private IWebElement _chooseMenuElement => Driver.FindElement(By.CssSelector("#pages_mega_menu > ul > li:nth-child(3) > div > div > div > div > div > div.panel-col-1.panel-col-width-2 > div > div > div:nth-child(1) > ul > li:nth-child(5) > span > a"));

        private IWebElement _verifyResult => Driver.FindElement(By.CssSelector("#products_column > div.product_listing > div:nth-child(4) > div > div > a > span.product_name"));

        public UogaPage(IWebDriver webDriver) : base(webDriver) { }

            private const string PageAddress = "https://uogauoga.lt/";

            public void NavigateToDefaultPage()
            {
                    Driver.Url = PageAddress;

            }

            public void ClickVeidui()
            {

            _chooseToolbarElement.Click();

            }

            public void ClickVeidoKremai()
            {

            _chooseMenuElement.Click();

            }

            public void VerifyResult(string expectedResult)
            {

            Assert.That(_verifyResult.Text, Is.EqualTo(expectedResult), "Answer is wrong!");

            }
        }
    
}


