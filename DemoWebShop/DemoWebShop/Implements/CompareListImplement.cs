using DemoWebShop.POMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebShop.Implements
{
    public class CompareListImplement
    {
        public bool IsCompareProductsPageOpened(string pagename)
        {
            CompareListPagePOM compare = new CompareListPagePOM();
            return compare.GetTitlePage().ToLower() == pagename.ToLower() ? true : false;
        }
    }
}
