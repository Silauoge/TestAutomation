using System;
using FinalProject.PAGES;
using NUnit.Framework;

namespace FinalProject.TESTS
{
    class InfoTests : BaseTest
    {
        [Test]
        public static void TestInfo()
        {

            string email = "PARAŠYK MUMS: info@uogauoga.lt";
            string address = "Kalvarijų g. 125-320, I korpusas, LT-08221 Vilnius, Lietuva";

            _infoPage.NavigateToDefaultPage3();
            _infoPage.ScrollDown();
            _infoPage.ClickKontaktai();
            _infoPage.VerifyEmail(email);
            _infoPage.VerifyAddress(address);
        }
    }
}

