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
    public partial class DeleteBook : Form
    {
        int id;

        public DeleteBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(txt_id.Text.Trim());
                int i = Bll_BookInfo.Delete_Book(id);
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
                MessageBox.Show("Deleted Error!");
            }
        }
    }
}
