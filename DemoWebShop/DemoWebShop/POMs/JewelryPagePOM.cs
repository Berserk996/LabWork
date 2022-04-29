using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebShop.POMs
{
    public class JewelryPagePOM : WebDriver
    {
        private readonly static By _diamondHeart = By.CssSelector("h2 a[href='/black-white-diamond-heart']");

    }
}
