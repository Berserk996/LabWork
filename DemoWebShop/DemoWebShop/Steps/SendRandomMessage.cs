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
    public class SendRandomMessage
    {
        public string RandomMessage { get; set; }

        [Given(@"Current user authorized")]
        public void GivenIEnterTheFolowingDetailsToAuthorize(Table table)
        {
            AuthoriztionImplement implement = new AuthoriztionImplement();
            implement.Authorization(table.Rows[0][0], table.Rows[0][1]);
        }


        [When(@"'(.*)' page is opened")]
        public void GivenPageIsOpened(string pageName)
        {

            InitPagePOM init = new InitPagePOM();
                init.ClickToContuckUs();
            Assert.IsTrue(new ContactUsImplement().IsContactUsPageIsOpened(pageName.ToLower()));
        }

        [Then(@"I add random data")]
        public void ThenIAddRandomData()
        {
            ContactUsImplement implement = new ContactUsImplement();
            implement.SendRandomMessage();
            RandomMessage = implement.RandomMessage;
        }

        [Then(@"'(.*)' result is displayed")]
        public void ThenResultIsDisplayed(string result)
        {
            Assert.AreEqual(new ContactUsPagePOM().GetResultText(),result);
        }



    }
}
