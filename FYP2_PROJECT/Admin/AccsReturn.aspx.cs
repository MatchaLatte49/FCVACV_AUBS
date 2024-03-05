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
    public partial class AccsReturn : System.Web.UI.Page
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

        // GVBind For Accessories Retunr
        protected void GVBind()
        {

            try
            {
                using (SqlConnection con = new SqlConnection(strcon))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM RequestsAccs WHERE Status = 'APPROVED'", con);

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows == true)
                    {
                        GridView2.DataSource = dr;
                        GridView2.DataBind();
                        Label2.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception here
                // For example, display an error message to the user
                string errorMessage = "No Accsessories request Found";
                Label2.Text = errorMessage;
            }

        }
        //Accessories
        protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            // Update item status in itemTable and requestTable
            if (e.CommandName != "ItemReturn") return;

            int requestAccsID = Convert.ToInt32(e.CommandArgument);
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
                SqlCommand cmd = new SqlCommand("UPDATE RequestsAccs SET Status = @status, ReturnDate = @returnDate, ReturnVerified = @returnVerified WHERE RequestAccsID = @requestAccsID", con);
                cmd.Parameters.AddWithValue("@status", "RECORDED");
                cmd.Parameters.AddWithValue("@returnDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@returnVerified", userName);
                cmd.Parameters.AddWithValue("@requestAccsID", requestAccsID);
                cmd.ExecuteNonQuery();
            }

            using (SqlConnection con = new SqlConnection(strcon))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE AccessoriesTable SET status = @Status WHERE ID = (SELECT AccsID FROM RequestsAccs WHERE RequestAccsID = @requestAccsID)", con);
                    cmd.Parameters.AddWithValue("@Status", "AVAILABLE");
                    cmd.Parameters.AddWithValue("@requestAccsID", requestAccsID);
                    cmd.ExecuteNonQuery();  
                }

            GridView2.DataBind();
            GVBind();
        }
        protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                //add the thead and tbody section programatically
                e.Row.TableSection = TableRowSection.TableHeader;
            }
        }
    }
}