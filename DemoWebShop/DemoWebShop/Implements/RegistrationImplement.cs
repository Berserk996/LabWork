using DemoWebShop.Helpers;
using DemoWebShop.POMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebShop.Implements
{
    public class RegistrationImplement
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public RegistrationImplement()
        {
            FirstName = UniqueValue.GetUniqueValue(UniqueValue.TypeOfValue.text);
            LastName = UniqueValue.GetUniqueValue(UniqueValue.TypeOfValue.text);
            Email = UniqueValue.GetUniqueValue(UniqueValue.TypeOfValue.text)+"@mail.ru";
            Password = UniqueValue.GetUniqueValue(UniqueValue.TypeOfValue.text) 
                + UniqueValue.GetUniqueValue(UniqueValue.TypeOfValue.nums);          

        }
        public void Registration(string firstName, string lastName, string email, string password, string cnfrmPassword)
        {
            InitPagePOM initPage = new InitPagePOM();
            initPage.ClickRegisterLink();
            RegisterPagePOM register = new RegisterPagePOM();
            register.ClickOnGenderRadioBtn()
                .TypeInFirstNameField(firstName.StartsWith("unique") ? FirstName : firstName)
                .TypeInLastNameField(lastName.StartsWith("unique") ? LastName : lastName)
                .TypeInEmailField(email.StartsWith("unique") ? Email : email)
                .TypeInPasswordField(password.StartsWith("unique") ? Password : password)
                .TypeInConfirmPasswordNameField(cnfrmPassword.StartsWith("unique") ? Password:cnfrmPassword)
                .ClickOnRegisterBtn();
        }
       
        public bool IsRegisterPageIsOpened(string pageName)
        {
            RegisterPagePOM register = new RegisterPagePOM();
            return register.GetTitlePage().ToLower() == pageName.ToLower() ? true : false;
        }


    }
}
