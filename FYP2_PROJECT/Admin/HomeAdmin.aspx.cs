using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FYP2_PROJECT
{
    public partial class WebForm2 : System.Web.UI.Page
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
                //request
                CalculateTotalRows();
                //return
                CalculateTotalRows2();
                Load_Username();

            }
        }

        

        private void Load_Username()
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection(strcon);
            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();

            cmd.CommandText = "select * from UserTable where userEmail='" + Session["userEmail"] + "' ";
            cmd.Connection = con;
            sda.SelectCommand = cmd;
            sda.Fill(ds);
            lblUsername.Text = ds.Tables[0].Rows[0]["userName"].ToString();
        }

        protected void CalculateTotalRows()
        {
            int totalRowCount = 0;

            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();

                // Query RequestsLCD table
                string queryLCD = "SELECT COUNT(*) FROM RequestsLCD WHERE Status = 'PENDING'";
                SqlCommand commandLCD = new SqlCommand(queryLCD, con);
                int countLCD = (int)commandLCD.ExecuteScalar();
                

                // Query RequestsAccs table
                string queryAccs = "SELECT COUNT(*) FROM RequestsAccs WHERE Status = 'PENDING'";
                SqlCommand commandAccs = new SqlCommand(queryAccs, con);
                int countAccs = (int)commandAccs.ExecuteScalar();
                

                // Query RequestsLAB table
                string queryLAB = "SELECT COUNT(*) FROM RequestsLAB WHERE Status = 'PENDING'";
                SqlCommand commandLAB = new SqlCommand(queryLAB, con);
                int countLAB = (int)commandLAB.ExecuteScalar();
                

                // Query RequestsBK table
                string queryBK = "SELECT COUNT(*) FROM RequestsBK WHERE Status = 'PENDING'";
                SqlCommand commandBK = new SqlCommand(queryBK, con);
                int countBK = (int)commandBK.ExecuteScalar();
                

                totalRowCount = countLCD + countAccs + countBK + countLAB;

                // Update the label control with the total count
                lbltotal.Text = totalRowCount.ToString();
                if (totalRowCount > 0)
                {
                    lbltotal.Visible = true;
                }
                else
                {
                    lbltotal.Visible = false;
                }

                con.Close();

            }

          
           
            
        }


        protected void CalculateTotalRows2()
        {
            int totalRowCount = 0;

            using (SqlConnection con = new SqlConnection(strcon))
            {
                con.Open();

                // Query RequestsLCD table
                string queryLCD = "SELECT COUNT(*) FROM RequestsLCD WHERE Status = 'APPROVED'";
                SqlCommand commandLCD = new SqlCommand(queryLCD, con);
                int countLCD = (int)commandLCD.ExecuteScalar();


                // Query RequestsAccs table
                string queryAccs = "SELECT COUNT(*) FROM RequestsAccs WHERE Status = 'APPROVED'";
                SqlCommand commandAccs = new SqlCommand(queryAccs, con);
                int countAccs = (int)commandAccs.ExecuteScalar();


                // Query RequestsLAB table
                string queryLAB = "SELECT COUNT(*) FROM RequestsLAB WHERE Status = 'APPROVED'";
                SqlCommand commandLAB = new SqlCommand(queryLAB, con);
                int countLAB = (int)commandLAB.ExecuteScalar();


                // Query RequestsBK table
                string queryBK = "SELECT COUNT(*) FROM RequestsBK WHERE Status = 'APPROVED'";
                SqlCommand commandBK = new SqlCommand(queryBK, con);
                int countBK = (int)commandBK.ExecuteScalar();


                totalRowCount = countLCD + countAccs + countBK + countLAB;

                // Update the label control with the total count
                lbltotal2.Text = totalRowCount.ToString();
                if (totalRowCount > 0)
                {
                    lbltotal2.Visible = true;
                }
                else
                {
                    lbltotal2.Visible = false;
                }

                con.Close();

            }




        }
    }
}