using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebShop.POMs
{
    public class LogInPagePOM : WebDriver
    {
        private readonly static By _pageTitle = By.XPath("//h1[text()='Welcome, Please Sign In!']");
        private readonly static By _emailField = By.Id("Email");
        private readonly static By _passwordField = By.Id("Password");
        private readonly static By _logInBtn = By.XPath("//a[@class='ico-login']");
        private readonly static By _expAcc = By.XPath("//a[text()='vasya_pupkin@1221mail.ru']");
        private readonly static By _logInBtn2 = By.XPath("//input[@class='button-1 login-button']");
        private readonly static By _errorMessages = By.XPath("//div[@class='validation-summary-errors']");
        public LogInPagePOM ClickToLogInBtn()
        {
            GetDriver().FindElement(_logInBtn).Click();
            return this;
        }
        public string GetTitlePage()
        {
            return GetDriver().FindElement(_pageTitle).Text;
        }
        public LogInPagePOM TypeInEmailField(string text)
        {
            GetDriver().FindElement(_emailField).SendKeys(text);
            return this;
        }
        public LogInPagePOM TypeInPasswordField(string text)
        {
            GetDriver().FindElement(_passwordField).SendKeys(text);
            return this;
        }
        public LogInPagePOM ClickToLogInBtn2()
        {
            GetDriver().FindElement(_logInBtn2).Click();
            return this;
        }
        public string GetAccName()
        {
            return GetDriver().FindElement(_expAcc).Text;
        }
        public string GetErrorMessages()
        {
            return GetDriver().FindElement(_errorMessages).Text;
        }
        
    }
}
