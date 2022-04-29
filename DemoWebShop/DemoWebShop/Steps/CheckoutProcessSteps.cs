using DemoWebShop.Implements;
using DemoWebShop.POMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace DemoWebShop.Steps
{
    [Binding]
    public class CheckoutProcessSteps
    {
        public string RecipientName { get; set; }

        [Given(@"Current already user authorized")]
        public void GivenCurrentAlreadyUserAuthorized(Table table)
        {
            AuthoriztionImplement implement = new AuthoriztionImplement();
            implement.Authorization(table.Rows[0][0], table.Rows[0][1]);
        }
        [When(@"I add items to cart with data")]
        public void WhenIAddItemsToCartWithData(Table table)
        {
            InitPagePOM init = new InitPagePOM();
            AddToCartImplement implement = new AddToCartImplement();
            init.ClickOnGiftCards();
            implement.AddGiftCardToCart(table.Rows[0][0]);
            init.ClickOnBooks();
            implement.AddItemToCart(table.Rows[1][0]);
            init.ClickOnNoteBooks();
            implement.AddItemToCart(table.Rows[2][0]);
            init.ClickOnApparelAndShoes();
            implement.AddItemToCart(table.Rows[3][0]);
            init.ClickOnJewelry();
            implement.AddItemToCart(table.Rows[4][0]);
                
        }
        [Then(@"I do checkout process with current data")]
        public void ThenIDoCheckoutProcessWithCurrentData()
        {
            
        }


    }
}
