using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace Bll
{
    public static class Bll_BookOrder
    {
        public static int Add_Book(BookOrder book)
        {
            return Dal.Dal_Order.Add_Book(book);
        }
    }
}
