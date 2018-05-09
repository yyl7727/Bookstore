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
using Bookstore.Bll;

namespace Bookstore.Ui
{
    public partial class AddBook : Form
    {
        BookInfo book = new BookInfo();

        public AddBook()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 将图片转化为2进制保存
        /// </summary>
        /// <param name="op"></param>
        /// <returns></returns>
        public byte[] GetPictureByte(OpenFileDialog op)
        {
            string path = op.FileName.ToString();
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            //通过FileStream对象实例化BinaryReader对象
            BinaryReader br = new BinaryReader(fs);
            //通过BinaryReader类对象的ReadBytes()方法将FileStream类对象转化为二进制数组
            byte[] imgBytesIn = br.ReadBytes(Convert.ToInt32(fs.Length));
            //将图片二进制数组返回
            return imgBytesIn;
        }

        /// <summary>
        /// 添加封面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picbox_cover_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                this.picbox_cover.Image = Image.FromFile(op.FileName);
                book.BookPic = GetPictureByte(op);
            }
            this.picbox_cover.ImageLocation = op.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                book.BookName = txt_name.Text.Trim();
                book.BookPeople = txt_author.Text.Trim();
                book.BookAddress = txt_publish.Text.Trim();
                book.BookPrice = comboBox1.Text + txt_price.Text.Trim();
                book.BookDate = dtp.Text.ToString();
                int i=Bll_BookInfo.Add_Book(book);
                if (i > 0)
                {
                    MessageBox.Show("Added Successfully");
                }
                else
                {
                    MessageBox.Show("Added Failed");
                }
            }
            catch
            {
                MessageBox.Show("Add Error!");
            }
        }



    }
}
