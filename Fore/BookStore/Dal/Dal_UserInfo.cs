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
    public static class Dal_UserInfo
    {
        /// <summary>
        /// 判断是否存在该用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static int ExistsUsers(UserInfo user)
        {
            string sqlTest = "select count(*) from UserInfo where UserName=@usersname and Password=@userspwd";
            MySqlParameter[] par = new MySqlParameter[2]
            {
                new MySqlParameter("@usersname",user.UserName),
                new MySqlParameter ("@userspwd",user.Password)
            };

            object obj = MysqlHelper.ExecuteScalar(sqlTest, CommandType.Text, par);
            return int.Parse(obj.ToString());
        }

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int Add_User(UserInfo user)
        {
            string sql = "insert into UserInfo(UserName,Name,Password,Email,Address,Datetime) values(@a,@b,@c,@d,@e,@f)";

            MySqlParameter[] par = new MySqlParameter[]
            {
                new MySqlParameter ("@a",user.UserName),
                new MySqlParameter ("@b",user.Name),
                new MySqlParameter ("@c",user.Password),
                new MySqlParameter ("@d",user.Email),
                new MySqlParameter ("@e",user.Address),
                new MySqlParameter ("@f",user.Datetime)
            };
            return MysqlHelper.ExecuteNonQuery(sql, CommandType.Text, par);
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static int Delete_User(string username)
        {
            string sql = @"delete from UserInfo where UserName=@a";
            MySqlParameter[] par = new MySqlParameter[]
            {
                new MySqlParameter("@a",username),
            };
            return MysqlHelper.ExecuteNonQuery(sql, CommandType.Text, par);
        }

        /// <summary>
        /// 根据用户名查找用户
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static UserInfo GetUser(string username)
        {
            UserInfo user = new UserInfo();
            string sql = "select * from UserInfo where UserName=@username";
            MySqlParameter[] par = new MySqlParameter[]
            {
                new MySqlParameter("@username",username)
            };
            MySqlDataReader sdr = MysqlHelper.ExecuteReader(sql, CommandType.Text, par);
            if (sdr.Read())
            {
                user.UserName = sdr["UserName"].ToString();
                user.Name = sdr["Name"].ToString();
                user.Password = sdr["Password"].ToString();
                user.Email = sdr["Email"].ToString();
                user.Address = sdr["Address"].ToString();
                user.Datetime = sdr["Datetime"].ToString();
            }
            return user;
        }
    }
}
