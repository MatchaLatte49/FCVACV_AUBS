using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace FYP2_PROJECT.Admin
{
    public partial class ManageRequest : System.Web.UI.Page
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
            // Calculate total number of rows in the RequestsLCD table with Status 'PENDING'
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM RequestsLCD WHERE Status = 'PENDING'";
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
            // Calculate total number of rows in the RequestsLCD table with Status 'PENDING'
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM RequestsAccs WHERE Status = 'PENDING'";
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
            // Calculate total number of rows in the RequestsLCD table with Status 'PENDING'
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM RequestsLAB WHERE Status = 'PENDING'";
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
            // Calculate total number of rows in the RequestsLCD table with Status 'PENDING'
            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM RequestsBK WHERE Status = 'PENDING'";
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