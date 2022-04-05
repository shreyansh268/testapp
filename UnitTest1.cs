using NUnit.Framework;
using SeleniumExtras.PageObjects;
using testapp.Base;
using testapp.Pages;

namespace testapp
{
    public class Tests : TestBase
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

        [TearDown]
        public void TearDown()
        {
        }
    }
}