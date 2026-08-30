using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MovieDataAccessLayer
{
    public class MovieDetails
    {
        SqlConnection connection = new SqlConnection("Server=LAPTOP-RBLEO; Database=STREAMFLIX_DB; Integrated Security=true");

        public List<MovieModel> GetMovieDetails(int num)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM MOVIE JOIN STUDIO ON MOVIE.STUDIOID=STUDIO.STUDIOID", connection);
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM MOVIE WHERE MOVIEID=@num", connection);
            cmd2.Parameters.Add("@num", SqlDbType.Int).Value = num;
            SqlDataAdapter adp = new SqlDataAdapter(cmd);









































































            DataSet ds = new DataSet();
            connection.Open();
            adp.Fill(ds);
            connection.Close();

            List<MovieModel> lst = new List<MovieModel>();

            foreach(DataRow data in ds.Tables[0].Rows)
            {
                MovieModel model = new MovieModel();
                model.MovieID = Convert.ToInt32(data["MOVIEID"]);
                model.Title = data["TITLE"].ToString();
                model.Genre = data["GENRE"].ToString();
                model.StudioName = data["STUDIONAME"].ToString();

                lst.Add(model);
            }
            return lst;
        }
    }
}
