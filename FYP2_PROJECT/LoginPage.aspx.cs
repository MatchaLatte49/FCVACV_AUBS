using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace FYP2_PROJECT
{
    

    public partial class LoginPage : System.Web.UI.Page
    {
       string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //user and admin login
        protected void Btn1_Click(object sender, EventArgs e)
        {
            
            string str, UserID, UserPASSWORD;
            SqlCommand com;
            SqlDataAdapter sqlda;
            DataTable dt;
            int RowCount;

            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    str = " select * from UserTABLE";
                    com = new SqlCommand(str);
                    sqlda = new SqlDataAdapter(com.CommandText, con);
                    dt = new DataTable();
                    sqlda.Fill(dt);
                    RowCount = dt.Rows.Count;
                    for (int i = 0; i < RowCount; i++)
                    {
                        UserID = dt.Rows[i]["UserID"].ToString();
                        UserPASSWORD = dt.Rows[i]["UserPASSWORD"].ToString();
                        if (UserID == TextStyle1.Text.Trim() && UserPASSWORD == TextStyle2.Text.Trim())
                        {
                            Session["UserID"] = UserID;
                            if (dt.Rows[i]["UserROLES"].ToString() == "Admin")
                                Response.Redirect("Admin/AdminHome.aspx");
                            else if (dt.Rows[i]["UserROLES"].ToString() == "Lecturer")
                                Response.Redirect("Admin/UserRegistration.aspx");
                           
                        }
                        else
                        {
                            Response.Write("<script>alert('Invalid ID');</script>");
                        }
                        

                    }
                    

                    


        }



    }
            catch(Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }

                

                /** SqlCommand cmd = new SqlCommand(" select * from UserTABLE where UserNAME='"+TextStyle1.Text.Trim()+"' " +
                     "AND UserPASSWORD= '" + TextStyle2.Text.Trim() + "'", con);
                
                SqlDataReader dr = cmd.ExecuteReader();**/

                






               /** if(dr.HasRows ) 
                {
                    while(dr.Read())
                    {
                        Response.Write("<script>alert('Login successfull');</script>");
                        Session["Admin_ID"] = dr.GetValue(1).ToString();
                    }
                    Response.Redirect("Admin/AdminHome.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Invalid ID');</script>");
                }

            }

            catch(Exception ex)
            {
                Response.Write("<script>alert('"+ex.Message+"');</script>");
            }

            **/
        }
    }
}