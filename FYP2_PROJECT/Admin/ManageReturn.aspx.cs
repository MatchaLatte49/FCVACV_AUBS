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
    public partial class ManageReturn : System.Web.UI.Page
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

                notiLCD();
                notiAccs();
                notiBK();
                notiLAB();

            }

        }

        protected void notiLCD()
        {
          
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM RequestsLCD WHERE Status = 'APPROVED'";
                SqlCommand command = new SqlCommand(query, con);
                int count = (int)command.ExecuteScalar();
                con.Close();

                // Update the label control with the count
                lblLCD.Text = count.ToString();
                if (count > 0)
                {
                    lblLCD.Visible = true;
                }
                else
                {
                    lblLCD.Visible = false;
                }
            }
        }

        protected void notiAccs()
        {
           
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM RequestsAccs WHERE Status = 'APPROVED'";
                SqlCommand command = new SqlCommand(query, con);
                int count = (int)command.ExecuteScalar();
                con.Close();

                // Update the label control with the count
                lblAccs.Text = count.ToString();
                if (count > 0)
                {
                    lblAccs.Visible = true;
                }
                else
                {
                    lblAccs.Visible = false;
                }
            }
        }

        protected void notiLAB()
        {
           
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM RequestsLAB WHERE Status = 'APPROVED'";
                SqlCommand command = new SqlCommand(query, con);
                int count = (int)command.ExecuteScalar();
                con.Close();

                // Update the label control with the count
                lblLAB.Text = count.ToString();
                if (count > 0)
                {
                    lblLAB.Visible = true;
                }
                else
                {
                    lblLAB.Visible = false;
                }
            }
        }

        protected void notiBK()
        {
            
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM RequestsBK WHERE Status = 'APPROVED'";
                SqlCommand command = new SqlCommand(query, con);
                int count = (int)command.ExecuteScalar();
                con.Close();

                // Update the label control with the count
                lblBK.Text = count.ToString();
                if (count > 0)
                {
                    lblBK.Visible = true;
                }
                else
                {
                    lblBK.Visible = false;
                }
            }
        }


    }
}