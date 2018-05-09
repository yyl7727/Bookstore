using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Dal;

namespace Bll
{
    public static class Bll_BookInfo
    {
        /// <summary>
        /// 添加书本
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public static int Add_Book(BookInfo book)
        {
            return Dal_BookInfo.Add_Book(book);
        }

        /// <summary>
        /// 删除书本
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int Delete_Book(int id)
        {
            return Dal_BookInfo.Delete_Book(id);
        }

        /// <summary>
        /// 根据书名查找书
        /// </summary>
        /// <param name="bookname"></param>
        /// <returns></returns>
        public static BookInfo GetBook(string bookname)
        {
            return Dal_BookInfo.GetBook(bookname);
        }
    }
}
