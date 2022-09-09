using System;
using ND3CheckBox.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ND3CheckBox.Tests
{
    class BaseTests
    {
        protected static IWebDriver Driver;

        public static CheckBoxPage _checkBoxPage;

        [OneTimeSetUp]
        public static void Setup()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Manage().Window.Maximize();

            _checkBoxPage = new CheckBoxPage(Driver);
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            Driver.Close();
        }

    }


}