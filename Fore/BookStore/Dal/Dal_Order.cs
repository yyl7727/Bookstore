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
    public static class Dal_Order
    {
        /// <summary>
        /// 增加订单
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int Add_Book(BookOrder book)
        {
            string sql = "insert into BookOrder(OrderID,BookName,BookID,BookPrice,UserName,DateTime,BookNum) values(@a,@b,@c,@d,@e,@f,@g)";

            MySqlParameter[] par = new MySqlParameter[]
            {
                new MySqlParameter ("@a",book.OrderID),
                new MySqlParameter ("@b",book.BookName),
                new MySqlParameter ("@c",book.BookID),
                new MySqlParameter ("@d",book.BookPrice),
                new MySqlParameter ("@e",book.UserName),
                new MySqlParameter ("@f",book.DateTime),
                new MySqlParameter ("@g",book.BookNum)
            };
            return MysqlHelper.ExecuteNonQuery(sql, CommandType.Text, par);
        }
    }
}
