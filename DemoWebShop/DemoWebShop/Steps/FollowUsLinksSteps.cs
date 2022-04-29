using DemoWebShop.Implements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace DemoWebShop.Steps
{
    [Binding]
    public class FollowUsLinksSteps
    {
        [Given(@"Current  was user authorized")]
        public void GivenCurrentWasUserAuthorized(Table table)
        {
            AuthoriztionImplement implement = new AuthoriztionImplement();
            implement.Authorization(table.Rows[0][0], table.Rows[0][1]);
        }
        [When(@"I click on links")]
        public void WhenIClickOnLinks(Table table)
        {
            FollowUsLinksImplement implement = new FollowUsLinksImplement();
            implement.ClickOnLinks(table.Rows[0][0]);
            Thread.Sleep(2000);
            implement.ClickOnLinks(table.Rows[1][0]);
            Thread.Sleep(2000);
            implement.ClickOnLinks(table.Rows[2][0]);
        }
        [Then(@"Pages are opening")]
        public void ThenPagesAreOpening()
        {
            ScenarioContext.Current.Pending();
        }


    }
}
