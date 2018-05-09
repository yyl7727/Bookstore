using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bll;
using Model;
using Dal;

public partial class Index : System.Web.UI.Page
{

    UserInfo userinfo = new UserInfo();
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_regist_Click(object sender, EventArgs e)
    {
        try 
        {
            userinfo.UserName = Username.Text.Trim();
            userinfo.Name = Truename.Text.Trim();
            userinfo.Password = password_confirmation.Text.Trim();
            userinfo.Email = email.Text.Trim();
            userinfo.Address = address.Text.Trim();
            userinfo.Datetime = DateTime.Now.ToString();
            int i = Bll_UserInfo.Add_User(userinfo);
            if (i > 0)
            {
                Response.Write(" <script>function window.onload() {alert( 'Regist Sucessfully' ); } </script> ");
            }
            else
            {
                Response.Write(" <script>function window.onload() {alert( 'Regist Failed' ); } </script> ");
            }
        }
        catch(Exception xx)
        {
            Response.Write(" <script>function window.onload() {alert( '"+xx.ToString()+"' ); } </script> ");
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            userinfo.UserName = txt_email.Text.Trim();
            userinfo.Password = txt_pwd.Text.Trim();
            int a = Bll_UserInfo.ExistsUsers(userinfo);
            if (a == 1)
            {
                Session["U_ID"] = userinfo.UserName;
                Response.Redirect("Index.aspx");
                Response.Write(" <script>function window.onload() {alert( 'Login Sucessfully' ); } </script> ");
            }
        }
        catch
        {

        }
    }
    protected void btn_stone_Click(object sender, EventArgs e)
    {
        BookInfo b = new BookInfo();
        b = Bll_BookInfo.GetBook("Harry Potter and the Philosopher's Stone");
        Session["BookName"] = b.BookName;
        Session["BookID"] = b.BookID;
        Response.Redirect("Order/Order.aspx?BookID=" + b.BookID + "");
    }
    protected void btn_azkaban_Click(object sender, EventArgs e)
    {
        BookInfo b = new BookInfo();
        b = Bll_BookInfo.GetBook("Harry Potter and the Prisoner of Azkaban");
        Session["BookName"] = b.BookName;
        Session["BookID"] = b.BookID;
        Response.Redirect("Order/Order.aspx?xx=" + b.BookID + "");
    }
    protected void btn_fire_Click(object sender, EventArgs e)
    {
        BookInfo b = new BookInfo();
        b = Bll_BookInfo.GetBook("Harry Potter and the Goblet of Fire");
        Session["BookName"] = b.BookName;
        Session["BookID"] = b.BookID;
        Response.Redirect("Order/Order.aspx?xx=" + b.BookID + "");
    }
    protected void btn_buystone_Click(object sender, EventArgs e)
    {
        BookInfo b = new BookInfo();
        b = Bll_BookInfo.GetBook("Harry Potter and the Philosopher's Stone");
        Session["BookName"] = b.BookName;
        Session["BookID"] = b.BookID;
        Response.Redirect("Order/Order.aspx?BookID=" + b.BookID + "");
    }
    protected void btn_buyazkaban_Click(object sender, EventArgs e)
    {
        BookInfo b = new BookInfo();
        b = Bll_BookInfo.GetBook("Harry Potter and the Prisoner of Azkaban");
        Session["BookName"] = b.BookName;
        Session["BookID"] = b.BookID;
        Response.Redirect("Order/Order.aspx?xx=" + b.BookID + "");
    }
    protected void btn_buyfire_Click(object sender, EventArgs e)
    {
        BookInfo b = new BookInfo();
        b = Bll_BookInfo.GetBook("Harry Potter and the Goblet of Fire");
        Session["BookName"] = b.BookName;
        Session["BookID"] = b.BookID;
        Response.Redirect("Order/Order.aspx?xx=" + b.BookID + "");
    }
    protected void btn_buysecrets_Click(object sender, EventArgs e)
    {
        BookInfo b = new BookInfo();
        b = Bll_BookInfo.GetBook("Harry Potter and the Chamber of Secrets");
        Session["BookName"] = b.BookName;
        Session["BookID"] = b.BookID;
        Response.Redirect("Order/Order.aspx?xx=" + b.BookID + "");
    }
}