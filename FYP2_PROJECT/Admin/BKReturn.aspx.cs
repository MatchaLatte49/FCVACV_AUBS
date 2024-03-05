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
    public partial class BKReturn : System.Web.UI.Page
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


                GVBind4();

            }

        }
        protected void GVBind4()
        {

            try
            {
                using (SqlConnection con = new SqlConnection(strcon))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM RequestsBK WHERE Status = 'APPROVED'", con);

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows == true)
                    {
                        GridView4.DataSource = dr;
                        GridView4.DataBind();
                        Label4.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception here
                // For example, display an error message to the user
                string errorMessage = "No request has been made.";
                Label4.Text = errorMessage;

            }

        }
        protected void GridView4_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName != "ItemReturn") return;

            int requestBKID = Convert.ToInt32(e.CommandArgument);
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
                SqlCommand cmd = new SqlCommand("UPDATE RequestsBK SET Status = @status, ReturnDate = @returnDate, ReturnVerified = @returnVerified WHERE RequestBKID = @requestBKID", con);
                cmd.Parameters.AddWithValue("@status", "RECORDED");
                cmd.Parameters.AddWithValue("@returnDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@returnVerified", userName);
                cmd.Parameters.AddWithValue("@requestBKID", requestBKID);
                cmd.ExecuteNonQuery();
            }

            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE BKTable SET status = @Status WHERE KID = (SELECT bkID FROM RequestsBK WHERE RequestBKID = @requestBKID)", con);
                cmd.Parameters.AddWithValue("@Status", "AVAILABLE");
                cmd.Parameters.AddWithValue("@requestBKID", requestBKID);
                cmd.ExecuteNonQuery();


            }

            GridView4.DataBind();
            GVBind4();

        }
        protected void GridView4_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                //add the thead and tbody section programatically
                e.Row.TableSection = TableRowSection.TableHeader;
            }
        }

    }
}