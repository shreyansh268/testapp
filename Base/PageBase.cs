using OpenQA.Selenium;

namespace testapp.Base
{
    public class PageBase
    {
        protected static IWebDriver _driver;

        public PageBase(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}