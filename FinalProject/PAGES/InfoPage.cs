using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace FinalProject.PAGES
{
    class InfoPage : BasePage
    {

        private IWebElement _clickKontaktai => Driver.FindElement(By.CssSelector("#pages_footer_menu > div:nth-child(1) > div > ul > li:nth-child(1) > a"));

        private IWebElement _verifyEmail => Driver.FindElement(By.CssSelector("#pages_detailed > div > div.page_editor_template.editor_type_text.clearfix > p:nth-child(1)"));

        private IWebElement _verifyAddress => Driver.FindElement(By.CssSelector("#pages_detailed > div > div.page_editor_template.editor_type_text.clearfix > p:nth-child(5)"));

        public InfoPage(IWebDriver webDriver) : base(webDriver) { }

        private const string PageAddress3 = "https://uogauoga.lt/";

        public void NavigateToDefaultPage3()
        {
            Driver.Url = PageAddress3;

        }


        public void ClickKontaktai()
        {

            _clickKontaktai.Click();

        }

        public void VerifyEmail (string expectedEmail)
        {

            Assert.That(_verifyEmail.Text, Is.EqualTo(expectedEmail), "Answer is wrong!");

        }
        public void VerifyAddress (string expectedAddress)
        {

            Assert.That(_verifyAddress.Text, Is.EqualTo(expectedAddress), "Answer is wrong!");

        }

    }

}




