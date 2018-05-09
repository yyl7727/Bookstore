using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 书信息实体类
    /// </summary>
    public class BookInfo
    {
        /// <summary>
        /// 书ID
        /// </summary>
        public int BookID { get; set; }

        /// <summary>
        /// 书名
        /// </summary>
        public string BookName { get; set; }

        /// <summary>
        /// 出版社
        /// </summary>
        public string BookAddress { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public string BookPrice { get; set; }

        /// <summary>
        /// 出版日期
        /// </summary>
        public string BookDate { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        public string BookPeople { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        public byte[] BookPic { get; set; }
    }
}
