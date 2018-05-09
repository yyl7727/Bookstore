using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Dal;

namespace Bll
{
    public static class Bll_UserInfo
    {
        /// <summary>
        /// 判断是否存在该用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static int ExistsUsers(UserInfo user)
        {
            return Dal_UserInfo.ExistsUsers(user);
        }

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static int Add_User(UserInfo user)
        {
            return Dal_UserInfo.Add_User(user);
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static int Delete_User(string username)
        {
            return Dal_UserInfo.Delete_User(username);
        }

        /// <summary>
        /// 查询用户
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static UserInfo GetUser(string username)
        {
            return Dal_UserInfo.GetUser(username);
        }
    }
}
