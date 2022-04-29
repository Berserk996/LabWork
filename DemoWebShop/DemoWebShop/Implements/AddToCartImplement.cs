using DemoWebShop.Helpers;
using DemoWebShop.POMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebShop.Implements
{
    public class AddToCartImplement
    {
        public string RecipientName { get; set; }
        public AddToCartImplement()
        {
            RecipientName = UniqueValue.GetUniqueValue(UniqueValue.TypeOfValue.text);
        }
        public void AddItemToCart(string itemName)
        {
           
            InitPagePOM init = new InitPagePOM();
            init
                .ClickOnItem(itemName)
                .GetAvailabilityText();
                init.ClickAddToCart();
        }
        public void AddGiftCardToCart(string itemName)
        {
            InitPagePOM init = new InitPagePOM();
            GiftCardsPagePOM card = new GiftCardsPagePOM();
            init.ClickOnItem(itemName)
                .GetAvailabilityText();
            card.TypeInRecipientsNameField(RecipientName)
                .ClickOnAddToCartBtn();
        }
        public void RemoveItemFromCart()
        {
            ShoppingCartPOM cart = new ShoppingCartPOM();
            cart
                .ClickToRemove()
                .ClickToUpdate()
                .ClickToContinueShopping();
        }
        public void TypeInRecipientsName()
        {
            GiftCardsPagePOM giftcard = new GiftCardsPagePOM();
            giftcard
                .TypeInRecipientsNameField(RecipientName);

        }

    }
}
