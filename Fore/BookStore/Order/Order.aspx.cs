using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bll;
using Model;
using System.IO;


public partial class Order_Order : System.Web.UI.Page
{
    BookInfo book = new BookInfo();
    protected void Page_Load(object sender, EventArgs e)
    {
        book = Bll_BookInfo.GetBook(Session["BookName"].ToString());
        lb_price.Text = book.BookPrice;
        lb_num.Text = "1";
        lb_allprice.Text = lb_price.Text;
        lb_ppprice.Text = lb_price.Text;
        lb_truepay.Text = lb_ppprice.Text;
        linkbtn.Text = book.BookName;
    }

    protected void btn_buy_Click(object sender, ImageClickEventArgs e)
    {
        string uid;
        BookOrder b = new BookOrder();
        b.BookID = book.BookID.ToString();
        b.BookName = book.BookName;
        b.BookNum = "1";
        b.BookPrice = lb_truepay.Text;
        b.DateTime = DateTime.Now.ToString();
        if (string.IsNullOrEmpty(Session["U_ID"].ToString()))
        {
            uid = null;
        }
        else
        {
            uid = Session["U_ID"].ToString();
        }
        b.UserName = uid;
        b.OrderID = DateTime.Now.ToString("yyyyMMddHHmmssff");
        Bll_BookOrder.Add_Book(b);
    }
}