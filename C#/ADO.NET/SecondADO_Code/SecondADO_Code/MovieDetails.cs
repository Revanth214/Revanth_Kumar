using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondADO_Code
{
    class MovieDetails
    {
        SqlConnection connect=new SqlConnection("Server= LAPTOP-RBLEO; Database=STREAMFLIX_DB; Integrated Security=true");

        public List<MovieModel> GetDetials()
        {
            SqlCommand cmd = new SqlCommand(
                "Select * from MOVIE m join Studio s on m.studioid=s.studioid",
                connect);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            connect.Open();
            sda.Fill(ds);
            connect.Close();
            List<MovieModel> lst = new List<MovieModel>();
            foreach(DataRow item in ds.Tables[0].Rows)
            {
                MovieModel model = new MovieModel();
                model.MovieID = Convert.ToInt32(item["MOVIEID"]);
                model.Title = item["Title"].ToString();
                model.Genre = item["Genre"].ToString();
                model.StudiioName = item["Studioname"].ToString();
                lst.Add(model);
            }
            return lst;
        }

    }
}
