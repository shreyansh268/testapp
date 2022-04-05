using NUnit.Framework;
using SeleniumExtras.PageObjects;
using testapp.Api;
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
        public void SearchWeather()
        {
            var homePage = new HomePage(_driver);
            PageFactory.InitElements(_driver, homePage);
            homePage.SearchCity("Ujjain");

            var resultPage = new ResultPage(_driver);
            PageFactory.InitElements(_driver, resultPage);
            var uiTemp = resultPage.GetTemperatureValue();
            Assert.That(uiTemp, Is.Not.Null, "Unable to get temperature value");

            var tempApi = WeatherApi.GetTemperature("Ujjain");

            Assert.That(uiTemp, Is.InRange(tempApi - 1.0, tempApi + 1.0), "Temperature values in not range +/-1");
        }

        [TearDown]
        public void TearDown()
        {
        }
    }
}