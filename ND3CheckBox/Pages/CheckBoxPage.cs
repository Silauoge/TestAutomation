using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace ND3CheckBox.Pages
{
    class CheckBoxPage : BasePage
    {


        private IWebElement _expandAll => Driver.FindElement(By.CssSelector("#tree-node > div > button.rct-option.rct-option-expand-all > svg"));

        private IWebElement _checkBoxCommands => Driver.FindElement(By.CssSelector("#tree-node > ol > li > ol > li:nth-child(1) > ol > li:nth-child(2) > span > label > span.rct-checkbox > svg"));
        private IWebElement _checkBoxDesktop => Driver.FindElement(By.CssSelector("#tree-node > ol > li > ol > li:nth-child(1) > span > label > span.rct-checkbox > svg"));
        private IWebElement _checkBoxDownloads => Driver.FindElement(By.CssSelector("#tree-node > ol > li > ol > li:nth-child(3) > span > label > span.rct-checkbox > svg"));
        private IWebElement _checkBoxNotes => Driver.FindElement(By.CssSelector("#tree-node > ol > li > ol > li:nth-child(1) > ol > li:nth-child(1) > span > label > span.rct-checkbox > svg"));
        private IWebElement _checkBoxGeneral => Driver.FindElement(By.CssSelector("#tree-node > ol > li > ol > li:nth-child(2) > ol > li:nth-child(2) > ol > li:nth-child(4) > span > label > span.rct-checkbox > svg"));

        private IWebElement _verifyResult => Driver.FindElement(By.CssSelector("#result > span.text-success"));

        private IWebElement _verifyResult1 => Driver.FindElement(By.CssSelector("#result > span:nth-child(2)"));
        private IWebElement _verifyResult2 => Driver.FindElement(By.CssSelector("#result > span:nth-child(3)"));
        private IWebElement _verifyResult3 => Driver.FindElement(By.CssSelector("#result > span:nth-child(4)"));
        private IWebElement _verifyResult4 => Driver.FindElement(By.CssSelector("#result > span:nth-child(5)"));
        private IWebElement _verifyResult5 => Driver.FindElement(By.CssSelector("#result > span:nth-child(6)"));
        private IWebElement _verifyResult6 => Driver.FindElement(By.CssSelector("#result > span:nth-child(7)"));


        public CheckBoxPage(IWebDriver webDriver) : base(webDriver) { }

        private const string PageAddress = "https://demoqa.com/checkbox";

        public void NavigateToDefaultPage()

        {
            if (Driver.Url != PageAddress)
            {
                Driver.Url = PageAddress;
            }
            else
            {
                Driver.Url = PageAddress;
            }
        }

        public void ClickPlusButton()
        {
            _expandAll.Click();
        }

        public void ClickCheckBoxButton()
        {
            _checkBoxCommands.Click();
        }

        public void ClickCheckBoxButtonDesktopAndDownloads()

        {
            _checkBoxDesktop.Click();
            ((IJavaScriptExecutor)Driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 50)");
            _checkBoxDownloads.Click();
        }


        public void ClickCheckBoxButtonNotesAndGeneral()
        {
        _checkBoxNotes.Click();
        _checkBoxGeneral.Click();
        }


        public void VerifyResult(string expectedResult)
        {
            Assert.That(_verifyResult.Text, Is.EqualTo($"{expectedResult}"), "Selected result is wrong!");
        }

        public void VerifyResultDD(string expectedResult1, string expectedResult2, string expectedResult3, string expectedResult4, string expectedResult5, string expectedResult6)
        {
            Assert.That(_verifyResult1.Text, Is.EqualTo($"{expectedResult1}"), "Selected result is wrong!");
            Assert.That(_verifyResult2.Text, Is.EqualTo($"{expectedResult2}"), "Selected result is wrong!");
            Assert.That(_verifyResult3.Text, Is.EqualTo($"{expectedResult3}"), "Selected result is wrong!");
            Assert.That(_verifyResult4.Text, Is.EqualTo($"{expectedResult4}"), "Selected result is wrong!");
            Assert.That(_verifyResult5.Text, Is.EqualTo($"{expectedResult5}"), "Selected result is wrong!");
            Assert.That(_verifyResult6.Text, Is.EqualTo($"{expectedResult6}"), "Selected result is wrong!");
        }

        public void VerifyResultNotesAndGeneral(string expectNotes, string expectGeneral)
        {
            Assert.That(_verifyResult1.Text, Is.EqualTo($"{expectNotes}"), "Selected result is wrong!");
            Assert.That(_verifyResult2.Text, Is.EqualTo($"{expectGeneral}"), "Selected result is wrong!");
        }
    }
}

