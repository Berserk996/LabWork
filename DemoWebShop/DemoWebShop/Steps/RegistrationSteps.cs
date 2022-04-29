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
    public class RegistrationSteps
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        [Given(@"'(.*)' page is open")]
        public void GivenPageIsOpen(string pageTitle)
        {         
            new InitPagePOM().ClickRegisterLink();           
            Assert.IsTrue(new RegistrationImplement().IsRegisterPageIsOpened(pageTitle.ToLower()));
        }

        [When(@"I enter the folowing details to register")]
        public void WhenIEnterTheFolowingDetailsToRegister(Table table)
        {
            RegistrationImplement implement = new RegistrationImplement();
            implement.Registration(table.Rows[0][0], table.Rows[0][1], table.Rows[0][2], table.Rows[0][3], table.Rows[0][4]);
            FirstName = implement.FirstName;
            LastName = implement.LastName;
            Email = implement.Email;
            Password = implement.Password;
        }

        [Then(@"'(.*)' is displayed")]
        public void ThenIsDisplayed(string result)
        {
            RegisterPagePOM register = new RegisterPagePOM();
            Assert.AreEqual(register.GetRegisterResult(), result);
            register.ClickOnContinueBtn();

        }


        [Then(@"Error message with '(.*)' text throws")]
        public void ThenErrorMessageWithTextThrows(string expErrorMessage)
        {
            RegisterPagePOM register = new RegisterPagePOM();
            Assert.IsTrue(register.GetErrorMessageExistingAcc().Contains(expErrorMessage));
        }
        [Then(@"Error message with '(.*)' text is displaed")]
        public void ThenErrorMessageWithTextIsDisplaed(string expErrorMessages)
        {
            RegisterPagePOM register = new RegisterPagePOM();
            Assert.IsTrue(register.GetErrorMessages().Contains(expErrorMessages));
        }

    }
}
