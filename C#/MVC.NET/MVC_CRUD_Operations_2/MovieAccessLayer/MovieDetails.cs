using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MovieAccessLayer
{
    public class MovieDetails
    {
        SqlConnection connection = new SqlConnection("Server=LAPTOP-RBLEO; Database=STREAMFLIX_DB; Integrated Security=true");
        public List<MovieModel> GetMovieDetails()
        {
            SqlCommand cmd = new SqlCommand("Select * from Movie", connection);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            connection.Open();
            adp.Fill(ds);
            connection.Close();

            List<MovieModel> lst = new List<MovieModel>();
            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                MovieModel model = new MovieModel();
                model.MovieID = Convert.ToInt32(dr[0]);
                model.Title = dr[1].ToString();
                model.Genre = dr[2].ToString();
                model.ReleaseDate = Convert.ToDateTime(dr[3]);
                model.StudioID = Convert.ToInt32(dr["STUDIOID"]);

                lst.Add(model);
            }
            return lst;
        }

        public void InsertMovie(MovieModel model)
        {
            SqlCommand cmd = new SqlCommand("Insert_Movie", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@title", model.Title);
            cmd.Parameters.AddWithValue("@genre", model.Genre);
            cmd.Parameters.AddWithValue("@date", model.ReleaseDate);
            cmd.Parameters.AddWithValue("@studio", model.StudioID);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void UpdateMovie(MovieModel model)
        {
            SqlCommand cmd = new SqlCommand("Update_Movie", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@movieid", model.MovieID);
            cmd.Parameters.AddWithValue("@title", model.Title);
            cmd.Parameters.AddWithValue("@genre", model.Genre);
            cmd.Parameters.AddWithValue("@date", model.ReleaseDate);
            cmd.Parameters.AddWithValue("@studioid", model.StudioID);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteMovie(MovieModel model)
        {
            SqlCommand cmd = new SqlCommand("DeleteMovie", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@movieid", model.MovieID);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
