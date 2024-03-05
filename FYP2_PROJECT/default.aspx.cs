using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FYP2_PROJECT
{
    public partial class LoginEmail : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str, Email, Password;
            SqlCommand com;
            SqlDataAdapter sqlda;
            DataTable dt;
            int RowCount;

            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    str = " select * from UserTable";
                    com = new SqlCommand(str);
                    sqlda = new SqlDataAdapter(com.CommandText, con);
                    dt = new DataTable();
                    sqlda.Fill(dt);
                    RowCount = dt.Rows.Count;
                    for (int i = 0; i < RowCount; i++)
                    {
                        Email = dt.Rows[i]["userEmail"].ToString();
                        Password = dt.Rows[i]["userPassword"].ToString();
                        if (Email == TextStyle1.Text.Trim() && Password == TextStyle2.Text.Trim())
                        {
                            Session["userEmail"] = Email;
                            if (dt.Rows[i]["UserRoles"].ToString() == "ADMIN")
                                Response.Redirect("~/Admin/HomeAdmin.aspx");
                            else if (dt.Rows[i]["UserRoles"].ToString() == "USER")
                                Response.Redirect("~/User/userPage.aspx");
                            // Exit the loop when a match is found
                            break;
                        }
                    }
                    // If the loop completes without a match, display an error message
                    Response.Write("<script>alert('Invalid ID');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}