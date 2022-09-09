using System;
using FinalProject.PAGES;
using NUnit.Framework;

namespace FinalProject.TESTS
{
    class UogaTests : BaseTest
    {
        [Test]
        public static void TestVerifyResult()
        {

            string text = "Naktinis kremas";

            _uogaPage.NavigateToDefaultPage();
            _uogaPage.ClickVeidui();
            _uogaPage.ClickVeidoKremai();
            _uogaPage.VerifyResult(text);
        }
    }
}


