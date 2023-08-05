using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqExamples
{
    public partial class LinqWithComplexTypes : System.Web.UI.Page
    {
        List<Employee> Employees;
        protected void Page_Load(object sender, EventArgs e)
        {
            Employees = (List<Employee>)Application["Employees"];
            if (!IsPostBack)
            {
                ddlJobs.DataSource = (from E in Employees select new { E.Job }).Distinct();
                ddlJobs.DataTextField = "Job";
                ddlJobs.DataValueField = "Job";
                ddlJobs.DataBind();
                ddlJobs.Items.Insert(0, "-Select Job-");
                gvEmp.DataSource = Employees;
                gvEmp.DataBind();

            }
        }

        protected void ddlJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlJobs.SelectedIndex > 0)
            {
                gvEmp.DataSource = from E in Employees where E.Job == ddlJobs.SelectedValue select E;
            }
            else
            {
                gvEmp.DataSource = from E in Employees select E;
            }
            gvEmp.DataBind();

        }
    }
}