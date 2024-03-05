using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace FYP2_PROJECT
{

    public partial class WebForm4 : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        SqlConnection con;
        DataSet ds;
        SqlCommand cmd;

        public WebForm4()
        {
            con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ToString();
            ds = new DataSet();
            cmd = new SqlCommand();
        }

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


            if (!Page.IsPostBack)
            {
                bindgridview();
            }


        }

        private void bindgridview()
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM UserTable", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    GridView1.DataSource = dr;
                    GridView1.DataBind();


                }

            }
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {

            //check if the row is the header row
            if (e.Row.RowType == DataControlRowType.Header)
            {
                //add the thead and tbody section programatically
                e.Row.TableSection = TableRowSection.TableHeader;
            }
        }



        protected void LinkAddUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/Add_user.aspx");
        }

        protected void LinkRemove_Click(object sender, EventArgs e)
        {
            LinkButton Ink = sender as LinkButton;
            GridViewRow gridrow = Ink.NamingContainer as GridViewRow;
            int UserID = Convert.ToInt16(GridView1.DataKeys[gridrow.RowIndex].Value.ToString());
            con.Open();
            cmd.CommandText = "delete from [UserTable] where userID= " + UserID;
            cmd.Connection= con;
            int a = cmd.ExecuteNonQuery();
            con.Close();
            if (a > 0)
            {
                Response.Write("<script>alert('Data has been deleted')</script>");
                bindgridview();
            }

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            bindgridview();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            string name = ((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
            string password = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text;
            string email = ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text;
            string phone = ((TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0]).Text;
            string roles = ((TextBox)GridView1.Rows[e.RowIndex].Cells[5].Controls[0]).Text;
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE UserTable SET userName='" + name + "',userPassword='" + password + "' ,userEmail='" + email + "',userPhone='" + phone + "',UserRoles='" + roles + "' where userID='" + id + "'", con);
                int t = cmd.ExecuteNonQuery();
                if (t > 0)
                {
                    Response.Write("<Script>alert('data has updated')</script>");
                    GridView1.EditIndex = -1;
                    bindgridview();

                }
            }
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            bindgridview();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int ID = Convert.ToInt16(GridView1.DataKeys[e.RowIndex].Value.ToString());
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM UserTable where userID='" + ID + "'",con);
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    Response.Write("<script>alert('Data has been deleted')</script>");
                    GridView1.EditIndex = -1;

                    bindgridview();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void LinkAddItem_Click(object sender, EventArgs e)
        {

        }
    }
}