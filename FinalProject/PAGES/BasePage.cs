using System;
using OpenQA.Selenium;

namespace FinalProject.PAGES
{
    class BasePage
    {
            protected static IWebDriver Driver;

            public BasePage(IWebDriver webDriver)
            {
                 Driver = webDriver;
            }

            public void ScrollDown()
            {
            Thread.Sleep(TimeSpan.FromSeconds(3));
            ((IJavaScriptExecutor)Driver).ExecuteScript("window.scrollTo(0, (document.scrollingElement||document.body).scrollHeight);");
            }

            


            
    }
}


