using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DemoWebShop.POMs
{
    public class RegisterPagePOM : WebDriver
    {
        private readonly static By _pageTitle = By.XPath("//h1[text()='Register']");
        private readonly static By _genderRadioBtn = By.Id("gender-male");
        private readonly static By _firstnameField = By.Id("FirstName");
        private readonly static By _lastnameField = By.Id("LastName");
        private readonly static By _emailField = By.Id("Email");
        private readonly static By _passwordField = By.Id("Password");
        private readonly static By _confirmPasswordField = By.Id("ConfirmPassword");
        private readonly static By _registerBtn = By.Id("register-button");   
        private readonly static By _errorMessageExtAcc = By.XPath("//*[text() = 'The specified email already exists']");
        private readonly static By _errorMessages = By.XPath("//span[@class='field-validation-error']");
        private readonly static By _result = By.XPath("//div[@class='result']");
        private readonly static By _continueBtn = By.XPath("//input[@class='button-1 register-continue-button']");
        

        public string GetRegisterResult()
        {
            return GetDriver().FindElement(_result).Text;
        }
        public string GetErrorMessages()
        {
            return GetDriver().FindElement(_errorMessages).Text;
        }
        public string GetErrorMessageExistingAcc()
        {
           return  GetDriver().FindElement(_errorMessageExtAcc).Text;
        }
        public string GetTitlePage()
        {
            return GetDriver().FindElement(_pageTitle).Text;
        }
        public RegisterPagePOM ClickOnGenderRadioBtn()
        {
            GetDriver().FindElement(_genderRadioBtn).Click();
            return this;
        }
        public RegisterPagePOM TypeInFirstNameField(string text)
        {
            GetDriver().FindElement(_firstnameField).SendKeys(text);
            return this;
        }
        public RegisterPagePOM TypeInLastNameField(string text)
        {
            GetDriver().FindElement(_lastnameField).SendKeys(text);
            return this;
        }
        public RegisterPagePOM TypeInEmailField(string text)
        {
            GetDriver().FindElement(_emailField).SendKeys(text);
            return this;
        }
        public RegisterPagePOM TypeInPasswordField(string text)
        {
            GetDriver().FindElement(_passwordField).SendKeys(text);
            return this;
        }
        public RegisterPagePOM TypeInConfirmPasswordNameField(string text)
        {
            GetDriver().FindElement(_confirmPasswordField).SendKeys(text);
            return this;
        }
        public RegisterPagePOM ClickOnRegisterBtn()
        {
            GetDriver().FindElement(_registerBtn).Click();
            return this;
        }
        public RegisterPagePOM ClickOnContinueBtn()
        {
            GetDriver().FindElement(_continueBtn).Click();
            return this;
        }
    }
}
