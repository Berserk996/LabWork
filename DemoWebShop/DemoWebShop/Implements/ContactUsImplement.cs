using DemoWebShop.Helpers;
using DemoWebShop.POMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebShop.Implements
{
    public class ContactUsImplement
    {
        public string RandomMessage { get; set; }

        public ContactUsImplement()
        {
            RandomMessage = UniqueValue.GetUniqueValue(UniqueValue.TypeOfValue.text);
        }
        public void SendRandomMessage()
        {
            InitPagePOM initPage = new InitPagePOM();
            initPage.ClickToContuckUs();
            ContactUsPagePOM contact = new ContactUsPagePOM();
            contact
                .TypeInEnquiryField(RandomMessage)
                .ClickToSubmit();
        }
        public bool IsContactUsPageIsOpened(string pageName)
        {
            ContactUsPagePOM contact = new ContactUsPagePOM();
            return contact.GetTitlePage().ToLower() == pageName.ToLower() ? true : false;
        }
    }
}
