using System;
using OpenQA.Selenium;

namespace ND3CheckBox.Pages
{
    class BasePage
    {
        protected static IWebDriver Driver;

        public BasePage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

    }

}