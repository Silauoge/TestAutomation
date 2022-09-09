using System;
using FinalProject.PAGES;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FinalProject.TESTS
{
        class BaseTest
        {

            protected static IWebDriver Driver;

            public static UogaPage _uogaPage;
            public static UogosKrepselisPage _uogosKrepselisPage;
            public static InfoPage _infoPage;
            public static PrenumerataPage _prenumerataPage;

            [OneTimeSetUp]
            public static void Setup()
            {
                Driver = new ChromeDriver();
                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                Driver.Manage().Window.Maximize();

                _uogaPage = new UogaPage(Driver);
                _uogosKrepselisPage = new UogosKrepselisPage(Driver);
                _infoPage = new InfoPage(Driver);
                _prenumerataPage = new PrenumerataPage(Driver);

        }

            [OneTimeTearDown]
            public static void TearDown()
            {
                Driver.Close();
            }

        }
    
}

