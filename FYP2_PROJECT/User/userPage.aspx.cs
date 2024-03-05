using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace FYP2_PROJECT
{
    
    public partial class WebForm3 : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userEmail"] == null)
            {
                Response.Redirect("/default.aspx");
            }
            else
            {
                SqlConnection con = new SqlConnection(strcon);
                con.Open();
                showdata();
                
            }
        }
        protected void LinkLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            FormsAuthentication.SignOut();
            Response.Redirect("~/default.aspx");
        }
        public void showdata()
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection(strcon);
            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();

            cmd.CommandText = "select * from UserTable where userEmail='" + Session["userEmail"] + "' ";
            cmd.Connection = con;
            sda.SelectCommand= cmd;
            sda.Fill(ds);
            Label1.Text = ds.Tables[0].Rows[0]["userName"].ToString();
        }
    }
}