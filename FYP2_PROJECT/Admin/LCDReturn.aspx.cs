using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FYP2_PROJECT.Admin
{
    public partial class LCDReturn : System.Web.UI.Page
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
                GVBind();
                
            }

        }


        protected void GVBind()
        {

            try
            {
                using (SqlConnection con = new SqlConnection(strcon))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM RequestsLCD WHERE Status = 'APPROVED'", con);

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows == true)
                    {
                        GridView1.DataSource = dr;
                        GridView1.DataBind();
                        Label1.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception here
                // For example, display an error message to the user
                string errorMessage = "No LCD request Found";
                Label1.Text = errorMessage;
            }

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName != "ItemReturn") return;

            int requestLCDID = Convert.ToInt32(e.CommandArgument);
            string userEmail = Session["userEmail"].ToString();
            string userName = "";

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

            // Update requestTable
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE RequestsLCD SET Status = @status, ReturnDate = @returnDate, ReturnVerified = @returnVerified WHERE RequestLCDID = @requestLCDID", con);
                cmd.Parameters.AddWithValue("@status", "RECORDED");
                cmd.Parameters.AddWithValue("@returnDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@returnVerified", userName);
                cmd.Parameters.AddWithValue("@requestLCDID", requestLCDID);
                cmd.ExecuteNonQuery();
            }

            // Update LCDTable
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE LCDTable SET status = @status WHERE LCDID = (SELECT lcdID FROM RequestsLCD WHERE RequestLCDID = @requestLCDID)", con);
                cmd.Parameters.AddWithValue("@status", "AVAILABLE");
                cmd.Parameters.AddWithValue("@requestLCDID", requestLCDID);
                cmd.ExecuteNonQuery();
            }

            GridView1.DataBind();
            GVBind();
        }
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                //add the thead and tbody section programatically
                e.Row.TableSection = TableRowSection.TableHeader;
            }
        }
    }
}