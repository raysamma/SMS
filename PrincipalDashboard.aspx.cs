using System;
using System.Web.UI;

namespace SMS
{
    public partial class PrincipalDashboard : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Optional: Add any logic that should run on page load
        }

        protected void btnAddTeacher_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddTeacher.aspx");
        }

        protected void btnViewReports_Click(object sender, EventArgs e)
        {
            Response.Redirect("Reports.aspx");
        }

        protected void btnManageClasses_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageClasses.aspx");
        }
    }
}
