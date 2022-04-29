using DemoWebShop.Implements;
using DemoWebShop.POMs;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace DemoWebShop.Steps
{
    [Binding]
    public class AddItemToCartSteps
    {
        [Given(@"Current was user authorized")]
        public void GivenCurrentUserAuthorized(Table table)
        {
            AuthoriztionImplement implement = new AuthoriztionImplement();
            implement.Authorization(table.Rows[0][0], table.Rows[0][1]);
            //Assert.IsTrue(new LogInPagePOM().GetAccName().Contains(userEmail));
        }

        [When(@"I add item to cart with data")]
        public void WhenIAddItemToCartWithData(Table table) 
        {
            AddToCartImplement implement = new AddToCartImplement();
            implement.AddItemToCart(table.Rows[0][0]);           
        }

        [Then(@"Item '(.*)' in cart")]
        public void ThenItemInCart(string text)
        {
            new InitPagePOM().ClickToShoppingCart();
            ShoppingCartPOM cart = new ShoppingCartPOM();
            Assert.IsTrue(cart.IsItemInCart(text));
        }
    }
}
