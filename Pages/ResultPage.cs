using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using testapp.Interface;

namespace testapp.Pages
{
    public class ResultPage : IPage
    {
        #region elements

        [FindsBy(How = How.CssSelector, Using = ".badge.badge-info")]
        private IWebElement TemperatureValue;

        #endregion elements

        public ResultPage(IWebDriver driver)
        {
        }

        public bool IsPageLoaded()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get temperature value from result page
        /// </summary>
        /// <returns>String value</returns>
        public string GetTemperatureValue()
        {
            return TemperatureValue.Text;
        }
    }
}