using System;
using NUnit.Framework;

namespace ND3CheckBox.Tests
{
    class CheckBoxTests : BaseTests
    {
        [Test]
        public static void TestVerifyCommands()
        {

            string text = "commands";

            _checkBoxPage.NavigateToDefaultPage();
            _checkBoxPage.ClickPlusButton();
            _checkBoxPage.ClickCheckBoxButton();
            _checkBoxPage.VerifyResult(text);

        }


        [Test]
        public static void TestVerifyDesktopAndDownloads()
        {

            string text1 = "desktop";
            string text2 = "notes";
            string text3 = "commands";
            string text4 = "downloads";
            string text5 = "wordFile";
            string text6 = "excelFile";

            _checkBoxPage.NavigateToDefaultPage();
            _checkBoxPage.ClickPlusButton();
            _checkBoxPage.ClickCheckBoxButtonDesktopAndDownloads();
            _checkBoxPage.VerifyResultDD(text1, text2, text3, text4, text5, text6);

        }

        [Test]
        public static void TestVerifyNotesAndGeneral()
        {


            string text1 = "notes";
            string text2 = "general";


            _checkBoxPage.NavigateToDefaultPage();
            _checkBoxPage.ClickPlusButton();
            _checkBoxPage.ClickCheckBoxButtonNotesAndGeneral();
            _checkBoxPage.VerifyResultNotesAndGeneral(text1, text2);

        }
    }
}