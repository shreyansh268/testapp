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

        public bool IsPageLoaded()
        {
            return SearchBox.Displayed;
        }
    }
}