using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;

namespace ND2Narsykles;

public class Tests3
{

    private static IWebDriver _chromeDriver;
    private static IWebDriver _firefoxDriver;
    private static IWebDriver _safariDriver;

    [OneTimeSetUp]
    public static void Setup()
    {
        _chromeDriver = new ChromeDriver();
        _firefoxDriver = new FirefoxDriver();
        _safariDriver = new SafariDriver();

        IWebDriver[] drivers = { _chromeDriver, _firefoxDriver, _safariDriver };

        for (int i = 0; i < drivers.Length; i++)
        {
            drivers[i].Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            drivers[i].Manage().Window.Maximize();
            drivers[i].Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
        }
    }

    [TestCase("safari", "Safari 15.6 on macOS (Catalina)", TestName = "Safari 15.6")]
    [TestCase("chrome", "Chrome 104 on macOS (Catalina)", TestName = "Chrome 104")]
    [TestCase("firefox", "Firefox 104 on macOS (Catalina)", TestName = "Firefox 104")]
    public static void TestBrowser(string browserType, string expectedResult)
    {
        IWebDriver driver;

        if (browserType == "safari")
        {
            driver = _safariDriver;
        }
        else if (browserType == "chrome")
        {
            driver = _chromeDriver;
        }
        else if (browserType == "firefox")
        {
            driver = _firefoxDriver;
        }
        else {
            return;
        }
    

        IWebElement result = driver.FindElement(By.ClassName("simple-major"));
        Assert.That(result.Text, Is.EqualTo(expectedResult), "Answer is wrong");
    }

    [OneTimeTearDown]
    public void OneTimeTearDown() {
        IWebDriver[] drivers = { _chromeDriver, _firefoxDriver, _safariDriver };

        for (int i = 0; i < drivers.Length; i++)
        {
            drivers[i].Close();
        }
    }
}
