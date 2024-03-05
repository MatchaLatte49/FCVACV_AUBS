using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FYP2_PROJECT.Admin
{
    public partial class ManageSchedule : System.Web.UI.Page
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
                loadImage();
            }

        }

        protected void loadImage()
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM scheduleTable", con);
                SqlDataReader rd = cmd.ExecuteReader();
                GridView1.DataSource = rd;
                GridView1.DataBind();


            }


            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (fileUpload.HasFile)
            {
                byte[] imageData = fileUpload.FileBytes;
                string selectedItem = ddlItems.SelectedValue;
                string imageName = TxtName.Text;
                string query = "INSERT INTO scheduleTable (ImageName,ImageType, ImageData) VALUES (@imageName, @ImageType, @imageData)";
                using (SqlConnection con = new SqlConnection(strcon))
                {
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@imageName", imageName);
                    command.Parameters.AddWithValue("@imageType", selectedItem);
                    command.Parameters.AddWithValue("@imageData", imageData);
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();

                }

                // Reload the GridView to display the new image
                loadImage();
            }
            else
            {
                Label1.Text = "Please Insert your Image";
                Label1.ForeColor = Color.Red;
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            loadImage();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            loadImage();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            // Get the ID of the row being updated
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);

            // Get the image data from the file upload control
            FileUpload fileUpload = (FileUpload)GridView1.Rows[e.RowIndex].FindControl("fileUploadEdit");
            byte[] imageData = fileUpload.FileBytes;

            // Update the image data in the database
            string query = "UPDATE scheduleTable SET ImageData = @imageData WHERE id = @id";
            using (SqlConnection con = new SqlConnection(strcon))
            {
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@imageData", imageData);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
            }

            // Set the status message
            //Label1.Text = "Image updated successfully.";
            //Label1.ForeColor = Color.Green;

            // Cancel the edit mode and rebind the data to the GridView
            Response.Write("<Script>alert('data has updated')</script>");
            GridView1.EditIndex = -1;
            loadImage();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int ID = Convert.ToInt16(GridView1.DataKeys[e.RowIndex].Value.ToString());
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM scheduleTable where id='" + ID + "'", con);
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    Response.Write("<script>alert('Data has been deleted')</script>");
                    GridView1.EditIndex = -1;

                    loadImage();
                }
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
        

    }
}