using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebShop.POMs
{
    public class ApparelAndShoesPagePOM:WebDriver
    {
        private readonly static By _shorts = By.CssSelector("h2 a[href='/v-blue-juniors-cuffed-denim-short-with-rhinestones']");

    }
}
