using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bookstore.Model;
using Bookstore.Ui;

namespace Bookstore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser adduser = new AddUser();
            adduser.ShowDialog();
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteUser deleteuser = new DeleteUser();
            deleteuser.ShowDialog();
        }

        /// <summary>
        /// 查询用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void queryUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryUser queryuser = new QueryUser();
            queryuser.ShowDialog();
        }

        /// <summary>
        /// 添加书本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBook addbook = new AddBook();
            addbook.ShowDialog();
        }

        /// <summary>
        /// 删除书本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteBook deletebook = new DeleteBook();
            deletebook.ShowDialog();
        }

        /// <summary>
        /// 查找书本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void queryBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryBook querybook = new QueryBook();
            querybook.ShowDialog();
        }
    }
}
