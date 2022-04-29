using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.ObjectModel;
using TechTalk.SpecFlow;


namespace DemoWebShop
{
    public class WebDriver : IWebDriver
    {
        private static IWebDriver driver;

        private static WebDriverWait wait;

        public IWebDriver GetDriver()
        {
            if (!ScenarioContext.Current.ContainsKey("driver"))
                driver = CreateWebDriver();

            return driver;
        }
        public WebDriverWait GetWait()
        {
            if (!ScenarioContext.Current.ContainsKey("wait"))
            {
                wait = new WebDriverWait(GetDriver(), TimeSpan.FromSeconds(60));
                ScenarioContext.Current["wait"] = wait;
            }
            return wait;
        }

        public string Url
        {
            get => GetDriver().Url;
            set => GetDriver().Url = value;
        }

        public string Title => GetDriver().Title;

        public string PageSource => GetDriver().PageSource;

        public string CurrentWindowHandle => GetDriver().CurrentWindowHandle;

        public ReadOnlyCollection<string> WindowHandles => GetDriver().WindowHandles;

        public void Close()
        {
            GetDriver().Close();
        }

        public void Dispose()
        {
            GetDriver().Dispose();
        }

        public IWebElement FindElement(By locator)
        {
            try
            {
                return GetDriver().FindElement(WaitClicability(locator));
            }
            catch
            {
                return GetDriver().FindElement(WaitVisability(locator));
            }
        }

        public ReadOnlyCollection<IWebElement> FindElements(By locator)
        {
            try
            {
                return GetDriver().FindElements(WaitClickabilityOfAllElements(locator));
            }
            catch
            {
                return GetDriver().FindElements(WaitVisabilityOfAllElements(locator));
            }
        }

        public IOptions Manage()
        {
            return GetDriver().Manage();
        }

        public INavigation Navigate()
        {
            return GetDriver().Navigate();
        }

        public void Quit()
        {
            GetDriver().Quit();
        }

        public ITargetLocator SwitchTo()
        {
            return GetDriver().SwitchTo();

        }
        private IWebDriver CreateWebDriver()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(15);
            ScenarioContext.Current["driver"] = driver;
            return driver;
        }
        private By WaitVisability(By locator)
        {
            GetWait().Until(ExpectedConditions.ElementIsVisible(locator));
            return locator;
        }
        private By WaitVisabilityOfAllElements(By locator)
        {
            GetWait().Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(locator));
            return locator;
        }
        private By WaitClicability(By locator)
        {
            GetWait().Until(ExpectedConditions.ElementToBeClickable(locator));
            return locator;
        }
        private By WaitClickabilityOfAllElements(By locator)
        {
            GetWait().Until(ExpectedConditions.ElementToBeClickable(locator));
            return locator;
        }
    }
}
