using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FYP2_PROJECT.Admin
{
    public partial class LCDRequest : System.Web.UI.Page
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

            }

            if (!IsPostBack)
            {

                GVbind();

            }
        }

        protected void GVbind()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strcon))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM RequestsLCD WHERE Status = 'PENDING' ", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows == true)
                    {
                        GridView1.DataSource = dr;
                        GridView1.DataBind();
                        lbl1.Visible= false;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception here
                // For example, display an error message to the user
                string errorMessage = "An error occurred while retrieving the data from the database.";
                errorMessage += "\nError Message:" + ex.Message;
                ClientScript.RegisterStartupScript(GetType(), "Error", "alert('" + errorMessage + "');", true);
            }
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                //add the thead and tbody section programatically
                e.Row.TableSection = TableRowSection.TableHeader;
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Approve")

            {
                string userEmail = Session["userEmail"].ToString();
                string userName = "";
                int reqID = Convert.ToInt32(e.CommandArgument);

                // Get username from userEmail
                using (SqlConnection con = new SqlConnection(strcon))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT UserName FROM UserTable WHERE UserEmail = @userEmail", con);
                    cmd.Parameters.AddWithValue("@userEmail", userEmail);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        userName = reader["UserName"].ToString();
                    }
                    reader.Close();
                }

                using (SqlConnection con = new SqlConnection(strcon))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE RequestsLCD SET Status = @Status, takenVerified = @takenVerified WHERE RequestLCDID = @ReqID", con);
                    cmd.Parameters.AddWithValue("@Status", "APPROVED");
                    cmd.Parameters.AddWithValue("@ReqID", reqID);
                    cmd.Parameters.AddWithValue("@takenVerified", userName);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("UPDATE LCDTable SET status = @Status WHERE lcdID = (SELECT lcdID FROM RequestsLCD WHERE RequestLCDID = @ReqID)", con);
                    cmd.Parameters.AddWithValue("@Status", "BORROWED");
                    cmd.Parameters.AddWithValue("@ReqID", reqID);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    GridView1.DataBind();
                    GVbind();
                }
            }
            else if (e.CommandName == "Reject")
            {
                int reqID = Convert.ToInt32(e.CommandArgument);
                using (SqlConnection con = new SqlConnection(strcon))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE RequestsLCD SET Status = @Status WHERE RequestLCDID = @ReqID", con);
                    cmd.Parameters.AddWithValue("@Status", "REJECTED");
                    cmd.Parameters.AddWithValue("@ReqID", reqID);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    GridView1.DataBind();
                    GVbind();
                }
            }
        }


    }
}