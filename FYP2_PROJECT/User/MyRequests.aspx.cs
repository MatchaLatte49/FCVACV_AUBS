using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FYP2_PROJECT.User
{
    public partial class MyRequests : System.Web.UI.Page
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
                GVBind2();
                GVBind3();
                GVBind4();
            }

        }


        protected void GVBind()
        {

            try
            {
                using (SqlConnection con = new SqlConnection(strcon))
                {
                    con.Open();
                    string userEmail = Session["userEmail"].ToString();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM RequestsLCD WHERE userEmail = @email AND Status = 'PENDING'", con);
                    cmd.Parameters.AddWithValue("@email", userEmail);
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

      

        protected void GVBind2()
        {

            try
            {
                using (SqlConnection con = new SqlConnection(strcon))
                {
                    con.Open();
                    string userEmail = Session["userEmail"].ToString();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM RequestsAccs WHERE userEmail = @email AND Status = 'PENDING'", con);
                    cmd.Parameters.AddWithValue("@email", userEmail);
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

        protected void GVBind3()
        {

            try
            {
                using (SqlConnection con = new SqlConnection(strcon))
                {
                    con.Open();
                    string userEmail = Session["userEmail"].ToString();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM RequestsLAB WHERE userEmail = @email AND Status = 'PENDING'", con);
                    cmd.Parameters.AddWithValue("@email", userEmail);
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

        protected void GVBind4()
        {

            try
            {
                using (SqlConnection con = new SqlConnection(strcon))
                {
                    con.Open();
                    string userEmail = Session["userEmail"].ToString();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM RequestsBK WHERE userEmail = @email AND Status = 'PENDING'", con);
                    cmd.Parameters.AddWithValue("@email", userEmail);
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

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName != "Cancel") return;
            int requestLCDID = Convert.ToInt32(e.CommandArgument);

            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM RequestsLCD WHERE RequestLCDID = @requestLCDID", con);
                cmd.Parameters.AddWithValue("@requestLCDID", requestLCDID);
                cmd.ExecuteNonQuery();
            }
            GridView1.DataBind();
            GVBind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            // do nothing
        }

        protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName != "Cancel") return;
            int RequestAccsID = Convert.ToInt32(e.CommandArgument);

            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM RequestsAccs WHERE RequestAccsID = @requestAccsID", con);
                cmd.Parameters.AddWithValue("@requestAccsID", RequestAccsID);
                cmd.ExecuteNonQuery();
            }
            GridView2.DataBind();
            GVBind2();
        }

        protected void GridView2_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            // do nothing
        }

        protected void GridView3_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName != "Cancel") return;
            int RequestLABID = Convert.ToInt32(e.CommandArgument);

            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM RequestsLAB WHERE RequestLABID = @requestLABID", con);
                cmd.Parameters.AddWithValue("@requestLABID", RequestLABID);
                cmd.ExecuteNonQuery();
            }
            GridView3.DataBind();
            GVBind3();
        }

        protected void GridView3_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            // do nothing
        }

        protected void GridView4_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName != "Cancel") return;
            int RequestBKID = Convert.ToInt32(e.CommandArgument);

            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM RequestsBK WHERE RequestBKID = @requestBKID", con);
                cmd.Parameters.AddWithValue("@requestBKID", RequestBKID);
                cmd.ExecuteNonQuery();
            }
            GridView4.DataBind();
            GVBind4();
        }

        protected void GridView4_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            // do nothing
        }





        /*
        protected void GVBind()
        {
            
            try
            {
                using (SqlConnection con = new SqlConnection(strcon))
                {
                    con.Open();
                    string CUID = Session["CUID"].ToString().Substring(3, 4);
                    int userId = int.Parse(CUID);
                    SqlCommand cmd = new SqlCommand("SELECT * FROM RequestsLCD WHERE UserID = @UserId AND Status = 'PENDING'", con);
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows == true)
                    {
                        GridView1.DataSource = dr;
                        GridView1.DataBind();
                        Label1.Visible= false;
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

        protected void GVBind2()
        {

            try
            {
                using (SqlConnection con = new SqlConnection(strcon))
                {
                    con.Open();
                    string CUID = Session["CUID"].ToString().Substring(3, 4);
                    int userId = int.Parse(CUID);
                    SqlCommand cmd = new SqlCommand("SELECT * FROM RequestsAccs WHERE UserID = @UserId AND Status = 'PENDING'", con);
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows == true)
                    {
                        GridView2.DataSource = dr;
                        GridView2.DataBind();
                        Label2.Visible= false;
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

        protected void GVBind3()
        {

            try
            {
                using (SqlConnection con = new SqlConnection(strcon))
                {
                    con.Open();
                    string CUID = Session["CUID"].ToString().Substring(3, 4);
                    int userId = int.Parse(CUID);
                    SqlCommand cmd = new SqlCommand("SELECT * FROM RequestsLAB WHERE UserID = @UserId AND Status = 'PENDING'", con);
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows == true)
                    {
                        GridView3.DataSource = dr;
                        GridView3.DataBind();
                        Label3.Visible= false;
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

        protected void GVBind4()
        {

            try
            {
                using (SqlConnection con = new SqlConnection(strcon))
                {
                    con.Open();
                    string CUID = Session["CUID"].ToString().Substring(3, 4);
                    int userId = int.Parse(CUID);
                    SqlCommand cmd = new SqlCommand("SELECT * FROM RequestsBK WHERE UserID = @UserId AND Status = 'PENDING'", con);
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows == true)
                    {
                        GridView4.DataSource = dr;
                        GridView4.DataBind();
                        Label4.Visible= false;
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

        }*/



    }
}