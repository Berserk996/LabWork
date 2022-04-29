using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace DemoWebShop.Hooks
{
    [Binding]
    public class Hook : WebDriver
    {

        [BeforeScenario]
        public void BeforeScenario()
        {

            GetDriver().Navigate().GoToUrl("http://demowebshop.tricentis.com/");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            GetDriver().Quit();
        }

    }
}
