using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DepartmentDetailsLayer;

namespace DepartmentASP
{
    public partial class Department : System.Web.UI.Page
    {
        DepartmentDetails dept_det = new DepartmentDetails();
        protected void Page_Load(object sender, EventArgs e)
        {
            gddept.DataSource = dept_det.GetDepartmentDetails();
            gddept.DataBind();
        }
    }
}