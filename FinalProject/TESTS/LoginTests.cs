using System;
using FinalProject.PAGES;
using NUnit.Framework;
using OpenQA.Selenium;

namespace FinalProject.TESTS
{
    class LoginTests : BaseTest
    {

        [Test]
        public static void TestVerifyLogin()
        {

            string text = "×\nNeteisingi prisijungimo duomenys.";

            _loginPage.NavigateToDefaultPage5();
            _loginPage.LoginMenuClick();
            _loginPage.EmailAdr("ququ@mailsac.com");
            _loginPage.Password("ququ123");
            _loginPage.SubmitButtonClick();
            _loginPage.VerifyLogin(text);
        }
    }
}
