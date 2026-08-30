using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeDataAccessLayer;

namespace ASP_EmployeeInfo
{
    public partial class Employee : System.Web.UI.Page
    {
        EmployeeDetails emp_obj = new EmployeeDetails();
        protected void Page_Load(object sender, EventArgs e)
        {
            gridemp.DataSource = emp_obj.GetEmployeeDetails();
            gridemp.DataBind();
        }
    }
}