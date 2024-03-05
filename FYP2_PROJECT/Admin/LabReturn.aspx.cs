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
    public partial class LabReturn : System.Web.UI.Page
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

                
                GVBind3();
               
            }

        }
        protected void GVBind3()
        {

            try
            {
                using (SqlConnection con = new SqlConnection(strcon))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM RequestsLAB WHERE Status = 'APPROVED'", con);

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows == true)
                    {
                        GridView3.DataSource = dr;
                        GridView3.DataBind();
                        Label3.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception here
                // For example, display an error message to the user
                string errorMessage = "No LAB request Found";
                Label3.Text = errorMessage;
            }

        }
        //LAB
        protected void GridView3_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName != "ItemReturn") return;

                int requestLABID = Convert.ToInt32(e.CommandArgument);
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
                    SqlCommand cmd = new SqlCommand("UPDATE RequestsLAB SET Status = @status, ReturnDate = @returnDate, ReturnVerified = @returnVerified WHERE RequestLABID = @requestLABID", con);
                    cmd.Parameters.AddWithValue("@status", "RECORDED");
                    cmd.Parameters.AddWithValue("@returnDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@returnVerified", userName);
                    cmd.Parameters.AddWithValue("@requestLABID", requestLABID);
                    cmd.ExecuteNonQuery();
                }

                using (SqlConnection con = new SqlConnection(strcon))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE LABTable SET status = @Status WHERE LID = (SELECT labID FROM RequestsLAB WHERE RequestLABID = @requestLABID)", con);
                    cmd.Parameters.AddWithValue("@Status", "AVAILABLE");
                    cmd.Parameters.AddWithValue("@requestLABID", requestLABID);
                    cmd.ExecuteNonQuery();
                    
                }

            GridView3.DataBind();
            GVBind3();

        }
        protected void GridView3_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                //add the thead and tbody section programatically
                e.Row.TableSection = TableRowSection.TableHeader;
            }
        }
    }
}