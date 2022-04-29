using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebShop.POMs
{
    public class ContactUsPagePOM:WebDriver 
    {
        private readonly static By _pageTitle = By.XPath("//div[@class='page-title']");
        private readonly static By _enquiry = By.Id("Enquiry");
        private readonly static By _submit = By.Name("send-email");
        private readonly static By _result = By.XPath("//div[@class='result']");

        public string GetResultText()
        {
            return GetDriver().FindElement(_result).Text;
        }
        public string GetTitlePage()
        {
            return GetDriver().FindElement(_pageTitle).Text;
        }
        public ContactUsPagePOM TypeInEnquiryField(string text)
        {
            GetDriver().FindElement(_enquiry).SendKeys(text);
            return this;
        }
        public ContactUsPagePOM ClickToSubmit()
        {
            GetDriver().FindElement(_submit).Click();
            return this;
        }

    }
}
