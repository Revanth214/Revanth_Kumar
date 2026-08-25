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
        SqlConnection connection=new SqlConnection("Server= LAPTOP-RBLEO; Database=STREAMFLIX_DB; Integrated Security=true");

        public List<MovieModel> GetDetails()
        {
            SqlCommand cmd = new SqlCommand(
                "Select * from MOVIE m join Studio s on m.studioid=s.studioid",
                connection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            connection.Open();
            sda.Fill(ds);
            connection.Close();
            List<MovieModel> lst = new List<MovieModel>();
            foreach(DataRow item in ds.Tables[0].Rows)
            {
                MovieModel model = new MovieModel();
                model.MovieID = Convert.ToInt32(item["MOVIEID"]);
                model.Title = item["Title"].ToString();
                model.Genre = item["Genre"].ToString();
                model.StudioName = item["Studioname"].ToString();
                lst.Add(model);
            }
            return lst;
        }

    }
}
