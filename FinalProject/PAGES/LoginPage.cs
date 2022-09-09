using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace FinalProject.PAGES
{
    class LoginPage : BasePage
    {

        private IWebElement _clickProfile => Driver.FindElement(By.CssSelector("#profile_menu > a > i"));

        private IWebElement _enterEmailAdr => Driver.FindElement(By.CssSelector("#loginForm > div:nth-child(2) > input"));

        private IWebElement _enterPassword => Driver.FindElement(By.CssSelector("#loginForm > div:nth-child(3) > input"));

        private IWebElement _clickSubmit => Driver.FindElement(By.CssSelector("#loginForm > button"));

        private IWebElement _verifyLogin => Driver.FindElement(By.CssSelector("#customersLogin > div > div.alert.alert-danger.alert-dismissible"));

        public LoginPage(IWebDriver webDriver) : base(webDriver) { }

        private const string PageAddress5 = "https://uogauoga.lt/";

        public void NavigateToDefaultPage5()
        {
            Driver.Url = PageAddress5;

        }

        public void LoginMenuClick()
        {

            _clickProfile.Click();

        }

        public void EmailAdr(string emailAdr)
        {
            _enterEmailAdr.Click();
            _enterEmailAdr.Clear();
            _enterEmailAdr.SendKeys(emailAdr);

        }

        public void Password(string password)
        {
            _enterPassword.Click();
            _enterPassword.Clear();
            _enterPassword.SendKeys(password);

        }

        public void SubmitButtonClick()
        {
            _clickSubmit.Click();

        }

        public void VerifyLogin(string expectedLogin)
        {

            Assert.That(_verifyLogin.Text, Is.EqualTo(expectedLogin), "Answer is wrong!");

        }
    }

}
