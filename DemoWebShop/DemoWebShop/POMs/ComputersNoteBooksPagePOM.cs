using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebShop.POMs
{
    public class ComputersNoteBooksPagePOM:WebDriver
    {
        private readonly static By _notebooks = By.CssSelector("h2 a[href='/notebooks']");

    }
}
