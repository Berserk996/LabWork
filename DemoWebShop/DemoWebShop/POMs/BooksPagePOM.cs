using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebShop.POMs
{
    public class BooksPagePOM : WebDriver
    {
        private readonly static By _book = By.CssSelector("h2 a[href='/computing-and-internet']");

    }
}
