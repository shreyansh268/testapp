using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace testapp.Base
{
    public class TestBase
    {
        protected IWebDriver _driver;
        private ExtentReports _extentReports;

        public TestBase()
        {
            Init();
            InitReport();
        }

        [SetUp]
        public void CreateReport()
        {
            var testMethod = TestContext.CurrentContext.Test.MethodName;
            _extentReports.CreateTest(testMethod);
        }

        /// <summary>
        /// Initialize test html report
        /// </summary>
        private void InitReport()
        {
            var reportPath = Environment.CurrentDirectory + @"\Report\TestReport.html";
            var htmlReport = new ExtentHtmlReporter(reportPath);
            _extentReports = new ExtentReports();
            _extentReports.AttachReporter(htmlReport);
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
            if (_extentReports != null)
            {
                _extentReports.Flush();
            }
        }
    }
}