using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using testapp.Interface;

namespace testapp.Pages
{
    public class HomePage: IPage
    {
        #region elements

        [FindsBy(How = How.CssSelector, Using = "#desktop-menu input[name='q']")]
        private IWebElement SearchBox;

        #endregion elements

        public HomePage(IWebDriver driver)
        {
        }

        /// <summary>
        /// Check if home page is loaded
        /// </summary>
        /// <returns>True if element displayed</returns>
        public bool IsPageLoaded()
        {
            return SearchBox.Displayed;
        }

        /// <summary>
        /// Search for city weather
        /// </summary>
        /// <param name="cityName">Name of city to search</param>
        public void SearchCity(string cityName)
        {
            SearchBox.SendKeys(cityName);
            SearchBox.SendKeys(Keys.Enter);
        }
    }
}