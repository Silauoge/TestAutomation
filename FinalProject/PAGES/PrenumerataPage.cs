using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace FinalProject.PAGES
{
    class PrenumerataPage : BasePage
    {

        private IWebElement _enterEmail => Driver.FindElement(By.CssSelector("#newsletter_form > input.form-control"));

        private IWebElement _pressSubscribe => Driver.FindElement(By.CssSelector("#newsletter_form > button"));

        private IWebElement _verifySubscription => Driver.FindElement(By.CssSelector("#subscribersForm > div"));

        public PrenumerataPage(IWebDriver webDriver) : base(webDriver) { }

        private const string PageAddress4 = "https://uogauoga.lt/";

        public void NavigateToDefaultPage4()
        {
            Driver.Url = PageAddress4;
        }

        public void EnterEmailAddress(string email)
        {
            _enterEmail.Click();
            _enterEmail.Clear();
            _enterEmail.SendKeys(email);
        }

        public void PressSubscribeButton()
        {

            _pressSubscribe.Click();
        }

        public void VerifyResult(string expectedResult)
        {

            Assert.That(_verifySubscription.Text, Is.EqualTo(expectedResult), "Answer is wrong!");

        }
    }

}



