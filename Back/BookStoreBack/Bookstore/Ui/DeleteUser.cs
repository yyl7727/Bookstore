using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bookstore.Bll;

namespace Bookstore.Ui
{
    public partial class DeleteUser : Form
    {
        string username;

        public DeleteUser()
        {
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            username = txt_username.Text.Trim();
            try
            {
                int i = Bll_UserInfo.Delete_User(username);
                if (i > 0)
                {
                    MessageBox.Show("Deleted Successfully");
                }
                else
                {
                    MessageBox.Show("Deleted Failed");
                }
            }
            catch
            {
                MessageBox.Show("Deleted Error,Try again!");
            }
        }
    }
}
