using DemoWebShop.Implements;
using DemoWebShop.POMs;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace DemoWebShop.Steps
{

    [Binding]
    public class CompireListSteps
    {

        [Given(@"Default user authorized")]
        public void GivenDefaultUserAuthorized(Table table)=>
            new AuthoriztionImplement().Authorization(table.Rows[0][0], table.Rows[0][1]);

        [Given(@"Sort by name Z to A completed at '(.*)' page")]
        public void GivenSortByNameZToACompletedAtPage(string pageName)
        {
            new InitPagePOM().ClickToDesktops();
            DesktopsPagePOM desk = new DesktopsPagePOM();
            Assert.IsTrue(desk.IsDesktopsPageOpened(pageName));
            desk.ClickToSortList()
                .GetItemPriceTextFromDesktops();


        }

        [When(@"I select first computer in list")]
        public void WhenISelectFirstComputerInList()
        {
            DesktopsPagePOM desk = new DesktopsPagePOM();
            desk
                .GetFirstItemsFromListOfItem()
                .ClickToAddToCompList();
        }


        [Then(@"Prices of items are equal")]
        public void PricesOfItemsAreEqual()
        {
            DesktopsPagePOM desk = new DesktopsPagePOM();
            CompareListPagePOM comp = new CompareListPagePOM();
            Assert.AreEqual(desk.ItemPrice,comp.ItemPrice);
        }

    }
}
