using DemoWebShop.POMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoWebShop.Implements
{
    public class FollowUsLinksImplement
    {
        public void ClickOnLinks(string link)
        {
            InitPagePOM init = new InitPagePOM();
            init.ClickOnFollowUsLinks(link);
            Thread.Sleep(2000);
            init.ClickBack();
        }
        //public bool IsFacebookPageIsOpened(string pageName)
        //{
        //    InitPagePOM init = new InitPagePOM();
        //    return init.GetFacebookTitlePage().ToLower() == pageName.ToLower() ? true : false;
            
        //}
    }
}
