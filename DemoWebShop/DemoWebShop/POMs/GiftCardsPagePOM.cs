using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebShop.POMs
{
    public class GiftCardsPagePOM : WebDriver
    {
        private readonly static By _giftCard = By.CssSelector("h2 a[href='/100-physical-gift-card']");
        private readonly static By _recipientsName = By.XPath("//input[@class='recipient-name']");
        private readonly static By _addToCartBtn = By.XPath("//input[@class='button-1 add-to-cart-button']");

        public GiftCardsPagePOM ClickOnGiftCard()
        {
            GetDriver().FindElement(_giftCard).Click();
            return this;
        }
        public GiftCardsPagePOM TypeInRecipientsNameField(string text)
        {
            GetDriver().FindElement(_recipientsName).SendKeys(text);
            return this;
        }
        public GiftCardsPagePOM ClickOnAddToCartBtn()
        {
            GetDriver().FindElement(_addToCartBtn).Click();
            return this;
        }
    }
}
