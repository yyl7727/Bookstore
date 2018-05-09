using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Helper
{
    public static class MysqlHelper
    {
        static string connStr = ConfigurationManager.ConnectionStrings["cnstr"].ConnectionString;
        /// <summary>
        /// 执行数据库的增删改操作，返回命令影响的行数
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="type"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql, CommandType type, MySqlParameter[] p)
        {
            int n;
            using (MySqlConnection cn = new MySqlConnection(connStr))
            {
                try
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, cn);
                    cmd.CommandType = type;
                    if (p != null)
                        cmd.Parameters.AddRange(p);
                    n = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    cn.Close();
                    throw ex;
                }
            }
            return n;
        }
        /// <summary>
        /// 执行数据库的查询操作，返回DateReader
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="type"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static MySqlDataReader ExecuteReader(string sql, CommandType type, MySqlParameter[] p)
        {
            MySqlDataReader dr;
            MySqlConnection cn = new MySqlConnection(connStr);
            try
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, cn);
                cmd.CommandType = type;
                if (p != null)
                    cmd.Parameters.AddRange(p);
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                cn.Close();
                throw ex;
            }
            return dr;
        }
        /// <summary>
        /// 执行数据库的查询操作，返回结果首行首列的Object对象
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="type"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql, CommandType type, MySqlParameter[] p)
        {
            object o;
            using (MySqlConnection cn = new MySqlConnection(connStr))
            {
                try
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, cn);
                    cmd.CommandType = type;
                    if (p != null)
                        cmd.Parameters.AddRange(p);
                    o = cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    cn.Close();
                    throw ex;
                }
            }
            return o;
        }
    }
}
