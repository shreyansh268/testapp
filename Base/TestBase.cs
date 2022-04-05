using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace testapp.Base
{
    public class TestBase
    {
        private IWebDriver _driver;

        public TestBase()
        {
            Init();
        }

        /// <summary>
        /// Open chrome browser and navigate to url
        /// </summary>
        private void Init()
        {
            InitChromeDriverManager();
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://openweathermap.org/");
            _driver.Manage().Window.Maximize();
        }

        /// <summary>
        /// Set up chrome driver using webdriver manager utility
        /// </summary>
        private static void InitChromeDriverManager()
        {
            var config = new ChromeConfig();
            var matchingVersion = config.GetMatchingBrowserVersion();
            new DriverManager().SetUpDriver(config, matchingVersion);
        }

        [TearDown]
        public void DriverQuit()
        {
            if (_driver != null)
            {
                _driver.Quit();
            }
        }
    }
}