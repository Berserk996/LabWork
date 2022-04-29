using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebShop.POMs
{
    public class CompareListPagePOM : WebDriver
    {
        private readonly static By _itemPrice = By.CssSelector("tr[class='product-price'] td[class='a-center']");
        private readonly static By _pageTitle = By.XPath("//div[@class='page-title']");

        public string ItemPrice { get; set; }
        public string GetTitlePage()
        {
            return GetDriver().FindElement(_pageTitle).Text;
        }
        public void GetItemPriceFromCompareList()
        {
            ItemPrice = GetDriver().FindElement(_itemPrice).Text;
        }


    }
}
