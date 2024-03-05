using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FYP2_PROJECT.User
{
    public partial class Setting : System.Web.UI.Page
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

        public void showdata()
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection(strcon);
            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();

            cmd.CommandText = "select * from UserTable where userEmail=@userEmail";
            cmd.Parameters.AddWithValue("@userEmail", Session["userEmail"].ToString());
            cmd.Connection = con;
            sda.SelectCommand = cmd;
            sda.Fill(ds);
            Label1.Text = ds.Tables[0].Rows[0]["userName"].ToString();
        }


        // Button click event to update user details
        protected void btnUpdateDetails_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strcon))
                {
                    con.Open();
                    string userEmail = Session["userEmail"].ToString();

                    string username = TextBoxName.Text;
                    string email = TextBoxEmail.Text;
                    string contact = TextBoxContact.Text;

                    // Update the fields that have been provided
                    string updateQuery = "UPDATE UserTable SET ";
                    List<SqlParameter> parameters = new List<SqlParameter>();
                    if (!string.IsNullOrEmpty(username))
                    {
                        updateQuery += "userName = @username, ";
                        parameters.Add(new SqlParameter("@username", username));
                    }
                    if (!string.IsNullOrEmpty(email))
                    {
                        updateQuery += "userEmail = @newEmail, ";
                        parameters.Add(new SqlParameter("@newEmail", email));
                    }
                    if (!string.IsNullOrEmpty(contact))
                    {
                        updateQuery += "userPhone = @contact, ";
                        parameters.Add(new SqlParameter("@contact", contact));
                    }

                    // Remove the trailing comma and space from the updateQuery string
                    updateQuery = updateQuery.Substring(0, updateQuery.Length - 2);

                    // Add the WHERE clause to update only the current user's record
                    updateQuery += " WHERE userEmail = @userEmail";
                    parameters.Add(new SqlParameter("@userEmail", userEmail));

                    // Execute the update query with the parameters
                    SqlCommand cmd = new SqlCommand(updateQuery, con);
                    cmd.Parameters.AddRange(parameters.ToArray());
                    cmd.ExecuteNonQuery();

                    // Update the session with the new email address if it was changed
                    if (!string.IsNullOrEmpty(email))
                    {
                        Session["userEmail"] = email;
                    }

                    con.Close();
                    ClientScript.RegisterStartupScript(GetType(), "Success", "alert('Profile updated successfully.');", true);
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "An error occurred while retrieving the data from the database.";
                errorMessage += "\nError Message:" + ex.Message;
                ClientScript.RegisterStartupScript(GetType(), "Error", "alert('" + errorMessage + "');", true);
            }
        }

        // Button click event to update password
        protected void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strcon))
                {
                    con.Open();
                    string userEmail = Session["userEmail"].ToString();

                    string oldpassword = TextBoxOldPassword.Text;
                    string newpassword = TextBoxNewPassword.Text;
                    SqlCommand cmd = new SqlCommand("SELECT userPassword FROM UserTable WHERE userEmail = @userEmail", con);
                    cmd.Parameters.AddWithValue("@userEmail", userEmail);
                    string password = (string)cmd.ExecuteScalar();
                    if (password != oldpassword)
                    {
                        ClientScript.RegisterStartupScript(GetType(), "Error", "alert('Old password is incorrect.');", true);
                        return;
                    }
                    cmd = new SqlCommand("UPDATE UserTable SET userPassword = @password WHERE userEmail = @userEmail", con);
                    cmd.Parameters.AddWithValue("@userEmail", userEmail);
                    cmd.Parameters.AddWithValue("@password", newpassword);
                    cmd.ExecuteNonQuery();

                    con.Close();
                    ClientScript.RegisterStartupScript(GetType(), "Success", "alert('Password updated successfully.');", true);
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "An error occurred while retrieving the data from the database.";
                errorMessage += "\nError Message:" + ex.Message;
                ClientScript.RegisterStartupScript(GetType(), "Error", "alert('" + errorMessage + "');", true);
            }
        }
    }
}