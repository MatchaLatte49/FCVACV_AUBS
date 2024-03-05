using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FYP2_PROJECT.User
{
    public partial class BookBK : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        SqlCommand cmd = new SqlCommand();
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
                showImage();
                bindData();
               
            }

        }
   
        
        private void showImage()
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT ImageName FROM scheduleTable WHERE ImageType = 'BK'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ddlImageNames.Items.Add(dr["ImageName"].ToString());
                }
                dr.Close();
            }
        }

        protected void btnShowImage_Click(object sender, EventArgs e)
        {
            string selectedImageName = ddlImageNames.SelectedValue;
            if (!string.IsNullOrEmpty(selectedImageName))
            {
                using (SqlConnection con = new SqlConnection(strcon))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT ImageData FROM scheduleTable WHERE ImageName=@ImageName", con);
                    cmd.Parameters.AddWithValue("@ImageName", selectedImageName);
                    byte[] imageData = (byte[])cmd.ExecuteScalar();
                    if (imageData != null)
                    {
                        imgSelectedImage.ImageUrl = "data:image/jpeg;base64," + Convert.ToBase64String(imageData);
                        imgSelectedImage.Visible = true;
                        labelImage.Visible = false;
                    }
                }
            }
        }
        
        private void bindData()
        {
            SqlConnection con = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("SELECT * FROM BKTable ", con);
            con.Open();
            BKlist.DataSource = cmd.ExecuteReader();
            BKlist.DataTextField = "KeyName";
            BKlist.DataValueField = "KID";
            BKlist.DataBind();
            con.Close();
        }


        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected item from the DropDownList control
                string selectedItem = BKlist.SelectedValue;
                string itemName = BKlist.SelectedItem.Text;
                // Get the start date and end date from the TextBox controls
                DateTime startDate = DateTime.Parse(TextBox1.Text);
                DateTime endDate = DateTime.Parse(TextBox2.Text);

                // Get the user information from the session
                string userName = "";
                string userPhoneNumber = "";
                string userEmail = Session["UserEmail"].ToString();

                // Retrieve the user's information from the database
                using (SqlConnection con = new SqlConnection(strcon))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT userID, userName, userPhone FROM UserTable WHERE UserEmail = @UserEmail", con);
                    cmd.Parameters.AddWithValue("@UserEmail", userEmail);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int userId = Convert.ToInt32(reader["userID"]);
                        userName = reader["userName"].ToString();
                        userPhoneNumber = reader["userPhone"].ToString();

                        // Close the DataReader before executing the next command
                        reader.Close();

                        // Add the borrowing information to the database
                        string status = "PENDING";
                        SqlCommand cmdInsert = new SqlCommand("INSERT INTO RequestsBK ( bkID, bkName,UserID,UserName, UserPhoneNumber, UserEmail, StartDate, EndDate, Status) VALUES ( @Item,@ItemName,@UserId, @name, @PhoneNumber, @Email, @StartDate, @EndDate, @Status)", con);
                        cmdInsert.Parameters.AddWithValue("@Item", selectedItem);
                        cmdInsert.Parameters.AddWithValue("@ItemName", itemName);
                        cmdInsert.Parameters.AddWithValue("@UserId", userId);
                        cmdInsert.Parameters.AddWithValue("@name", userName);
                        cmdInsert.Parameters.AddWithValue("@PhoneNumber", userPhoneNumber);
                        cmdInsert.Parameters.AddWithValue("@Email", userEmail);
                        cmdInsert.Parameters.AddWithValue("@StartDate", startDate);
                        cmdInsert.Parameters.AddWithValue("@EndDate", endDate);
                        cmdInsert.Parameters.AddWithValue("@Status", status);

                        cmdInsert.ExecuteNonQuery();
                        con.Close();

                        // Display a success message
                        LblMessage.Text = "Item borrowed successfully!";
                        Response.Redirect("~/User/MyRequests.aspx");
                    }
                    else
                    {
                        // User not found in the database
                        LblMessage.Text = "User not found.";
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                // Display the error message
                LblMessage.Text = "An error occurred: " + ex.Message;
            }
        }




        /*
        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            // Get the selected item from the DropDownList control
            string selectedItem = BKlist.SelectedValue;

            // Get the start date and end date from the TextBox controls
            DateTime startDate = DateTime.Parse(TextBox1.Text);
            DateTime endDate = DateTime.Parse(TextBox2.Text);

            // Get the user ID from the session
            string userName = "";
            string userPhoneNumber = "";
            string userEmail = "";


            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                string CUID = Session["CUID"].ToString().Substring(3, 4);
                int userId = int.Parse(CUID);

                SqlCommand cmd = new SqlCommand("SELECT userName, userPhone, UserEmail FROM UserTable WHERE UserID = @SessionId", con);
                cmd.Parameters.AddWithValue("@SessionId", userId);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    userName = reader["userName"].ToString();
                    userPhoneNumber = reader["userPhone"].ToString();
                    userEmail = reader["userEmail"].ToString();
                }

                reader.Close();
                con.Close();
            }

            // Add the borrowing information to the database
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                string CUID = Session["CUID"].ToString().Substring(3, 4);
                int userId = int.Parse(CUID);
                string status = "PENDING";
                SqlCommand cmd = new SqlCommand("INSERT INTO RequestsBK (UserID, bkID, UserName, UserPhoneNumber,UserEmail, StartDate, EndDate, Status) VALUES (@UserId, @Item,@name,@PhoneNumber,@Email ,@StartDate, @EndDate, @Status)", con);
                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.Parameters.AddWithValue("@Item", int.Parse(selectedItem));
                cmd.Parameters.AddWithValue("@name", userName);
                cmd.Parameters.AddWithValue("@PhoneNumber", userPhoneNumber);
                cmd.Parameters.AddWithValue("@Email", userEmail);
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);
                cmd.Parameters.AddWithValue("@Status", status);

                cmd.ExecuteNonQuery();
                con.Close();

                // Display a success message
                LblMessage.Text = "Item borrowed successfully!";
                Response.Redirect("/User/MyRequests.aspx");
            }

        }*/
    }
}