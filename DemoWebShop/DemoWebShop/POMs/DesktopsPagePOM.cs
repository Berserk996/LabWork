using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebShop.POMs
{
    public class DesktopsPagePOM : WebDriver
    {
        private readonly static By _pageTitle = By.XPath("//div[@class='page-title']");
        private readonly static By _sortList = By.XPath("//select[@id='products-orderby']/option[contains(text(),'Name: Z to A')]");
        private readonly static By _addToCompireListBtn = By.XPath("//input[@class='button-2 add-to-compare-list-button']");
        private readonly static By _compireListLink = By.XPath("//div[@class='column customer-service']/ul/li/a[contains(@href,'compareproducts')]");
        private readonly static By _listOfItems = By.CssSelector("div[class='details'] a");
        private readonly static By _itemPrice = By.CssSelector("span[class='price actual-price']");

        public  string  ItemPrice { get; set; }
        public DesktopsPagePOM GetFirstItemsFromListOfItem()
        {
           GetDriver().FindElements(_listOfItems).First().Click();
            return this;
        }
       
        public DesktopsPagePOM GetItemPriceTextFromDesktops()
        {
            ItemPrice = GetDriver().FindElements(_itemPrice).First().Text;
            return this;
        }
        public string GetTitlePage()
        {
            return GetDriver().FindElement(_pageTitle).Text;
        }
        public DesktopsPagePOM ClickToSortList()
        {
            GetDriver().FindElement(_sortList).Click();
            return this;
        }
        public bool IsDesktopsPageOpened(string pagename)
        {
            DesktopsPagePOM desktops = new DesktopsPagePOM();
            return desktops.GetTitlePage().ToLower() == pagename.ToLower() ? true : false;
        }
        public void ClickToAddToCompList() =>
            GetDriver().FindElement(_addToCompireListBtn).Click();
        public void ClickToCompireListLink() =>
            GetDriver().FindElement(_compireListLink).Click();
    }
}
