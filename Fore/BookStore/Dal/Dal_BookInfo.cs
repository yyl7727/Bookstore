using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using MySql.Data.MySqlClient;
using Helper;
using System.Data;

namespace Dal
{
    public static class Dal_BookInfo
    {
        /// <summary>
        /// 添加书本
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int Add_Book(BookInfo book)
        {
            string sql = "insert into BookInfo(BookName,BookAddress,BookPrice,BookDate,BookPeople,BookPic) values(@a,@b,@c,@d,@e,@f)";

            MySqlParameter[] par = new MySqlParameter[]
            {
                new MySqlParameter ("@a",book.BookName),
                new MySqlParameter ("@b",book.BookAddress),
                new MySqlParameter ("@c",book.BookPrice),
                new MySqlParameter ("@d",book.BookDate),
                new MySqlParameter ("@e",book.BookPeople),
                new MySqlParameter ("@f",book.BookPic)
            };
            return MysqlHelper.ExecuteNonQuery(sql, CommandType.Text, par);
        }

        /// <summary>
        /// 删除书本
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static int Delete_Book(int id)
        {
            string sql = @"delete from BookInfo where BookID=@a";
            MySqlParameter[] par = new MySqlParameter[]
            {
                new MySqlParameter("@a",id),
            };
            return MysqlHelper.ExecuteNonQuery(sql, CommandType.Text, par);
        }

        /// <summary>
        /// 根据书名查找书
        /// </summary>
        /// <param name="bookname"></param>
        /// <returns></returns>
        public static BookInfo GetBook(string bookname)
        {
            BookInfo book = new BookInfo();
            string sql = "select * from BookInfo where BookName=@bookname";
            MySqlParameter[] par = new MySqlParameter[]
            {
                new MySqlParameter("@bookname",bookname)
            };
            MySqlDataReader sdr = MysqlHelper.ExecuteReader(sql, CommandType.Text, par);
            if (sdr.Read())
            {
                book.BookName = sdr["BookName"].ToString();
                book.BookPeople = sdr["BookPeople"].ToString();
                book.BookAddress = sdr["BookAddress"].ToString();
                book.BookDate = sdr["BookDate"].ToString();
                book.BookID = Convert.ToInt32(sdr["BookID"]);
                book.BookPrice = sdr["BookPrice"].ToString();
                book.BookPic = (byte[])sdr["BookPic"];
            }
            return book;
        }
    }
}
