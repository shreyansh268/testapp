using NUnit.Framework;
using SeleniumExtras.PageObjects;
using testapp.Base;
using testapp.Pages;

namespace testapp
{
    [TestFixture]
    public class WeatherAppTests : TestBase
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestPageLoad()
        {
            var homePage = new HomePage(_driver);
            PageFactory.InitElements(_driver, homePage);
            Assert.That(homePage.IsPageLoaded(), Is.True, "Home page is not loaded");
        }

        [Test]
        public void SearchWeather()
        {
            var homePage = new HomePage(_driver);
            PageFactory.InitElements(_driver, homePage);
            homePage.SearchCity("Ujjain");

            var resultPage = new ResultPage(_driver);
            PageFactory.InitElements(_driver, resultPage);
            Assert.That(resultPage.GetTemperatureValue(), Is.Not.Empty, "unable to get temperature value");
        }

        [TearDown]
        public void TearDown()
        {
        }
    }
}