using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FYP2_PROJECT
{
    public partial class AdminDashboard : System.Web.UI.MasterPage
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

        protected void LinkLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            FormsAuthentication.SignOut();
            Response.Redirect("~/default.aspx");
        }

        protected void LinkHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/HomeAdmin.aspx");
        }

        protected void LinkManageUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/ManageUser.aspx");
        }

        protected void LinkInventory_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/Inventory.aspx");
            
        }

        protected void LinkReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/ViewRecord.aspx");
            
        }

        protected void LinkRequest_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/ManageRequest.aspx");
        }

        protected void LinkSchedule_Click (object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/ManageSchedule.aspx");
        }

        protected void LinkManageReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/ManageReturn.aspx");
        }
    }
}