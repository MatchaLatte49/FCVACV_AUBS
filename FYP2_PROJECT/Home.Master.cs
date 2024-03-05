using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FYP2_PROJECT
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["logout"] == "true")
            {
                Session.Clear();
                Session.Abandon();
                FormsAuthentication.SignOut();
                Response.Redirect("~/default.aspx");
            }
        }
        protected void LinkBooking_Click(object sender, EventArgs e)
        {

        }

        protected void LinkCheck_Click(object sender, EventArgs e)
        {

        }

        protected void LinkReport_Click(object sender, EventArgs e)
        {

        }

        protected void LinkLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            FormsAuthentication.SignOut();
            Response.Redirect("~/default.aspx");
        }
    }
}