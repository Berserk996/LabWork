using DemoWebShop.POMs;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebShop.Implements
{
    public class AuthoriztionImplement
    {
        public void Authorization(string email, string password)
        {
            LogInPagePOM logIn = new LogInPagePOM();
            logIn
                .ClickToLogInBtn()
                .TypeInEmailField(email)
                .TypeInPasswordField(password)
                .ClickToLogInBtn2();
        }

        public bool IsLogInPageOpened(string pagename)
        {
            LogInPagePOM logIn = new LogInPagePOM();
            return logIn.GetTitlePage().ToLower() == pagename.ToLower() ? true : false;
        }
        public bool IsUserAuthorized(string value)
        {
            return new LogInPagePOM().GetAccName().Contains(value);
        }
    }
}
