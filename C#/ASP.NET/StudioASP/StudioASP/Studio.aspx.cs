using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudioDetailsLayer;

namespace StudioASP
{
    public partial class Studio : System.Web.UI.Page
    {
        StudioDetails studio = new StudioDetails();
        protected void Page_Load(object sender, EventArgs e)
        {
            gridstudio.DataSource = studio.GetStudioDetails();
            gridstudio.DataBind();
        }
    }
}