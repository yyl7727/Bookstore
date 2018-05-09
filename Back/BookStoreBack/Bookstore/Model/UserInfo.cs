using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookstore.Model
{
    /// <summary>
    /// 用户信息实体类
    /// </summary>
    public class UserInfo
    {   
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 真实姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 注册时间
        /// </summary>
        public string Datetime { get; set; }
    }
}
