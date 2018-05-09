using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bookstore.Bll;
using Bookstore.Model;

namespace Bookstore.Ui
{
    public partial class QueryUser : Form
    {
        string username;
        UserInfo user = new UserInfo();
        
        public QueryUser()
        {
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            username=txt_username.Text.Trim();
            try
            {
                user = Bll_UserInfo.GetUser(username);
                lb_username.Text = user.UserName;
                lb_truename.Text = user.Name;
                lb_email.Text = user.Email;
                lb_address.Text = user.Address;
                lb_regdate.Text = user.Datetime;
            }
            catch
            {
                MessageBox.Show("Query Error!");
            }
        }
    }
}
