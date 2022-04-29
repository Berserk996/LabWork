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
    public class AuthorizationSteps
    {
        [Given(@"move on '(.*)' page")]
        public void GivenMoveOnPage(string pageTitle)
        {
            new LogInPagePOM().ClickToLogInBtn();
            Assert.IsTrue(new AuthoriztionImplement().IsLogInPageOpened(pageTitle.ToLower()));
        }

        [When(@"I enter the folowing details to authorize")]
        public void WhenIEnterTheFolowingDetailsToAuthorize(Table table) =>
            new AuthoriztionImplement().Authorization(table.Rows[0][0], table.Rows[0][1]);


        [Then(@"authorize with '(.*)' passes successfully")]
        public void ThenAuthorizePassesSuccessfully(string userEmail) =>
          Assert.IsTrue(new AuthoriztionImplement().IsUserAuthorized(userEmail));



        [Then(@"Error message with '(.*)' and '(.*)' text is displayed")]
        public void ThenErrorMessageWithAndTextIsDisplayed(string message1, string message2)
        {
            LogInPagePOM log = new LogInPagePOM();
            Assert.IsTrue(log.GetErrorMessages().Contains(message1));
            Assert.IsTrue(log.GetErrorMessages().Contains(message2));
        }


    }
}
