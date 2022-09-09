using System;
using FinalProject.PAGES;
using NUnit.Framework;

namespace FinalProject.TESTS
{
    class UogosKrepselisTests : BaseTest
    {
        [Test]
        public static void TestCart()
        {

            string text = "Naktinis kremas";

            _uogosKrepselisPage.NavigateToDefaultPage2();
            _uogosKrepselisPage.ClickConsent();
            _uogosKrepselisPage.ClickProduct();
            _uogosKrepselisPage.VerifyProduktasKrepselyje(text);
        }
    }
}

