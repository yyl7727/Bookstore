using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bookstore.Model;
using Bookstore.Bll;

namespace Bookstore.Ui
{
    public partial class AddUser : Form
    {
        UserInfo user = new UserInfo();

        public AddUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user.UserName = txt_username.Text.Trim();
            user.Password = txt_repwd.Text.Trim();
            user.Email = txt_email.Text.Trim();
            user.Name = txt_truename.Text.Trim();
            user.Address = txt_address.Text.Trim();
            user.Datetime = DateTime.Now.ToString();
            try
            {
                int i=Bll_UserInfo.Add_User(user);
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
                MessageBox.Show("Added Error,Try again!");
            }
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }
    }
}
