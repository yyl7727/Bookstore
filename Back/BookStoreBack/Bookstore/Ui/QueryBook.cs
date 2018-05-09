using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Bookstore.Model;

namespace Bookstore.Ui
{
    public partial class QueryBook : Form
    {
        string bookname;
        BookInfo bookinfo = new BookInfo();

        public QueryBook()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 将二进制数据转换为图片
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public Image GetPicture(object o)
        {
            byte[] imageByte = (byte[])o;
            //将图片字节数组加载入到缓冲流
            MemoryStream imageStream = new MemoryStream(imageByte);
            //从缓冲流生成图片
            Image imageResulet = Image.FromStream(imageStream, true);
            //pictureBox是一个显示图片或者视频的C#控件

            return imageResulet;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bookname = txt_search.Text.Trim();
                bookinfo = Bll.Bll_BookInfo.GetBook(bookname);
                txt_author.Text = bookinfo.BookPeople;
                txt_name.Text = bookinfo.BookName;
                txt_price.Text = bookinfo.BookPrice;
                txt_publish.Text = bookinfo.BookAddress;
                picbox_cover.Image = GetPicture(bookinfo.BookPic);

            }
            catch
            {
                MessageBox.Show("Query Error");
            }
        }

        private void QueryBook_Load(object sender, EventArgs e)
        {

        }
    }
}
