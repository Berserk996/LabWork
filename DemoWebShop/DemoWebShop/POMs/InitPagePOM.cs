using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace DemoWebShop.POMs
{
    public class InitPagePOM : WebDriver
    {
        private readonly static By _registerLink = By.XPath("//a[@class='ico-register']");
        private readonly static By _logInLink = By.XPath("//a[@class='ico-login']");
        private readonly static By _emailField = By.Id("Email");
        private readonly static By _passwordField = By.Id("Password");
        private readonly static By _addToCartBtn = By.XPath("//input[@class='button-1 add-to-cart-button']");
        private readonly static By _cartBadge = By.XPath("//span[@class='cart-qty']");
        private readonly static By _shoppingCart = By.XPath("//a[@class='ico-cart']");
        private readonly static By _computers = By.CssSelector("a[href='/computers']");
        private readonly static By _desktops = By.CssSelector("a[href='/desktops']");
        private readonly static By _giftCards = By.XPath("//ul//li//a[contains(@href,'/gift-cards')]");
        private readonly static By _jewelry = By.CssSelector("a[href='/jewelry']");
        private readonly static By _apparelAndShoes = By.CssSelector("a[href='/apparel-shoes']");
        private readonly static By _books = By.CssSelector("a[href='/books']");
        private readonly static By _itemAvailability = By.XPath("//span[@class='value']");
        private readonly static By _itemName = By.XPath("//div[@class='product-name']/h1/text()");
        private readonly static By _contuctUsLink = By.XPath("//ul//li//a[contains(@href,'contactus')]");
        private readonly static By _listOfItems = By.CssSelector("div[class='details'] a");
        private readonly static By _noteBooks = By.CssSelector("a[href='/notebooks']");
        private readonly static By _facebookLink = By.CssSelector("a[href='http://www.facebook.com/nopCommerce']");
        private readonly static By _twitterLink = By.CssSelector("a[href='https://twitter.com/nopCommerce']");
        private readonly static By _youtubeLink = By.CssSelector("http://www.youtube.com/user/nopCommerce");


        public bool GetAvailabilityText()
        {
            bool result = true;
            var item = GetDriver().FindElement(_itemAvailability).Text;
            if (item.Contains("Out of stock"))
            {
                return result == false;
            }
            return result;
        }
        public void GetFirstItemsFromListOfItem()
        {
            GetDriver().FindElements(_listOfItems).First().Click();
            //var items = GetDriver().FindElements(_listOfItems);
            //foreach (var item in items)
            //{
            //    if (item.Text.Contains("a"))
            //    {
            //        item.Click();
            //    }
            //}
        }
        public string GetItemName()
        {
            return GetDriver().FindElement(_itemName).Text;
        }
        public void ClickToContuckUs() =>
            GetDriver().FindElement(_contuctUsLink).Click();
        public void ClickOnBooks() =>
           GetDriver().FindElement(_books).Click();
        public void ClickOnJewelry() =>
           GetDriver().FindElement(_jewelry).Click();
        public void ClickOnGiftCards() =>
           GetDriver().FindElement(_giftCards).Click();
        public void ClickOnApparelAndShoes() =>
           GetDriver().FindElement(_apparelAndShoes).Click();
        public void ClickOnNoteBooks()
        {
            Actions builder = new Actions(GetDriver());
            builder.MoveToElement(FindElement(_computers)).Build().Perform();
            builder.MoveToElement(FindElement(_noteBooks)).Click().Build().Perform();
        }
        public string GetCartBudgeNum()
        {
            return GetDriver().FindElement(_cartBadge).Text;
        }
        public InitPagePOM ClickOnItem(string text)
        {
            GetDriver().FindElement(By.XPath($"//h2//a[text()='{text}']")).Click();
            return this;
        }

        public InitPagePOM ClickOnFollowUsLinks(string text)
        {
            GetDriver().FindElement(By.XPath($"//li//a[text()='{text}']")).Click();
            return this;
        }

        public InitPagePOM ClickAddToCart()
        {
            GetDriver().FindElement(_addToCartBtn).Click();
            return this;
        }
        public void ClickRegisterLink() =>
            GetDriver().FindElement(_registerLink).Click();
        public void ClickLogInLink() =>
            GetDriver().FindElement(_registerLink).Click();
        public InitPagePOM ClickToShoppingCart()    
        {
            GetDriver().FindElement(_shoppingCart).Click();
            return this;
        }
        public void ClickToDesktops()
        {
            Actions builder = new Actions(GetDriver());
            builder.MoveToElement(FindElement(_computers)).Build().Perform();
            builder.MoveToElement(FindElement(_desktops)).Click().Build().Perform();
        }
        public void ClickOnFaceBookLink() =>
            GetDriver().FindElement(_facebookLink).Click();
        public void ClickOnTwittekLink() =>
            GetDriver().FindElement(_twitterLink).Click();
        public void ClickOnYouTubeLink() =>
            GetDriver().FindElement(_youtubeLink).Click();

     
        public void ClickBack()
        {
            GetDriver().SwitchTo().Window(GetDriver().WindowHandles[0]);
        }
    }
}
