using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieDataAccessLayer;

namespace ASP_EmployeeInfo
{
    public partial class Movie : System.Web.UI.Page
    {
        MovieDetails movie_obj = new MovieDetails();
        protected void Page_Load(object sender, EventArgs e)
        {
            gdmovie.DataSource = movie_obj.GetMovieDetails(5);
            gdmovie.DataBind();
        }
    }
}