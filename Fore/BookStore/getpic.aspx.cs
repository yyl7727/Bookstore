using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using MySql.Data.MySqlClient;

public partial class getpic : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Expires = 0;
        Response.Buffer = true;
        Response.Clear();
        int bookid = Convert.ToInt32(Request.Params["xx"]);
        GetPic(bookid);
    }

    public void GetPic(int BookID)
    {
        string str = ConfigurationManager.ConnectionStrings["cnstr"].ToString();
        MySqlConnection conn = new MySqlConnection(str);
        conn.Open();
        string sql = "select Bookpic from Bookinfo where BookID=@BookID";
        MySqlCommand cmd = new MySqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@BookID", BookID);
        MySqlDataReader dr1 = cmd.ExecuteReader();
        dr1.Read();
        if (dr1.HasRows)
        {
            byte[] photo1 = null;
            if (dr1[0] != null)
                photo1 = (byte[])dr1[0];
            Response.ContentType = "image/jpeg";
            Response.BinaryWrite(photo1);
            Response.End();
        }
        dr1.Close();
        conn.Close();
    }
}