using System;
using FinalProject.PAGES;
using NUnit.Framework;
using OpenQA.Selenium;

namespace FinalProject.TESTS
{
    class PrenumerataTests : BaseTest
    {


        [Test]
        public static void TestVerifySubscription()
        {
            
            string text = "×\nDėkojame! Laukite mūsų naujienų.";

            _prenumerataPage.NavigateToDefaultPage4();
            _prenumerataPage.ScrollDown();
            _prenumerataPage.EnterEmailAddress("ququ@mailsac.com");
            _prenumerataPage.PressSubscribeButton();
            _prenumerataPage.VerifyResult(text);
        }
    }
}

