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
        /// <returns>Numberical value of temperature result</returns>
        public decimal GetTemperatureValue()
        {
            var temp = TemperatureValue.Text;
            var v = temp.Remove(temp.IndexOf("°С"));
            return Convert.ToDecimal(v);
        }
    }
}