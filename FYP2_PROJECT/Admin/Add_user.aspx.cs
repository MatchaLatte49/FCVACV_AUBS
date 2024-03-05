using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FYP2_PROJECT
{
    public partial class Add_user : System.Web.UI.Page
    {
        
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        string type;
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

            }
        }

        protected void btnAddUser_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                string insertSql = "INSERT INTO UserTable (userName, userPassword, userEmail, userPhone, UserRoles) VALUES (@name, @password,@email,@phone,@roles)";

                using (SqlCommand command = new SqlCommand(insertSql, con))
                {
                    command.Parameters.AddWithValue("@name", TextBox1.Text.Trim());
                    command.Parameters.AddWithValue("@password", TextBox2.Text.Trim());
                    command.Parameters.AddWithValue("@email", TextBox3.Text.Trim());
                    command.Parameters.AddWithValue("@phone", TextBox4.Text.Trim());

                    // Set the value of the type parameter based on the checked radio button
                    if (RadioButton1.Checked)
                    {
                        command.Parameters.AddWithValue("@roles", "ADMIN");
                    }
                    else if (RadioButton2.Checked)
                    {
                        command.Parameters.AddWithValue("@roles", "USER");
                    }
                    else
                    {
                        lblError.Text = "Please select a user type.";
                        lblError.Visible = true;
                        return;
                    }

                    command.ExecuteNonQuery();
                    con.Close();
                    Response.Write("<script>alert('New User Successful Added');</script>");
                    Response.Redirect("~/Admin/ManageUser.aspx");
                }
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/ManageUser.aspx");
        }
    }
}