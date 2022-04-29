using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebShop.POMs
{
    public class ShoppingCartPOM:WebDriver
    {
        private readonly static By _pageTitle = By.XPath("//div[@class='page-title']");
        private readonly static By _removeCheckBox = By.XPath("//input[@name='removefromcart']");
        private readonly static By _updateBtn = By.XPath("//input[@name='updatecart']");
        private readonly static By _ContinueBtn = By.XPath("//input[@name='continueshopping']");
        private readonly static By _listOfItems = By.CssSelector("td[class='product']");
        private readonly static By _checkoutBtn = By.Id("checkout");
        private readonly static By _agreeCheckBox = By.Id("termsofservice");
        public bool IsItemInCart(string text)
        {
            var items = GetDriver().FindElements(_listOfItems);
            foreach (var item in items)
            {
                if (item.Text.Contains(text))
                {
                    return true;
                }
            }
            return false;
        }
        public string GetTitlePage()
        {
            return GetDriver().FindElement(_pageTitle).Text;
        }

        public ShoppingCartPOM ClickToRemove()
        {
            GetDriver().FindElement(_removeCheckBox).Click();
            return this;
        }
        public ShoppingCartPOM ClickToUpdate()
        {
            GetDriver().FindElement(_updateBtn).Click();
            return this;
        }
        public ShoppingCartPOM ClickToContinueShopping()
        {
            GetDriver().FindElement(_ContinueBtn).Click();
            return this;
        }
        public ShoppingCartPOM ClickOnAgreeCheckBox()
        {
            GetDriver().FindElement(_agreeCheckBox).Click();
            return this;
        }
        public ShoppingCartPOM ClickOnCheckoutBtn()
        {
            GetDriver().FindElement(_checkoutBtn).Click();
            return this;
        }
    }
}
