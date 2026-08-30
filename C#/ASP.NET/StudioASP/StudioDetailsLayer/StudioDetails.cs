using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace StudioDetailsLayer
{
    public class StudioDetails
    {
        SqlConnection connection = new SqlConnection("Server=LAPTOP-RBLEO; Database=STREAMFLIX_DB; Integrated Security=true");
        public List<StudioModel> GetStudioDetails()
        {
            SqlCommand cmd = new SqlCommand("Select * from studio", connection);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            connection.Open();
            adp.Fill(ds);
            connection.Close();
            List<StudioModel> lst = new List<StudioModel>();
            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                StudioModel model = new StudioModel();
                model.StudioID = Convert.ToInt32(dr["STUDIOID"]);
                model.StudioName = dr["STUDIONAME"].ToString();
                model.Country = dr["COUNTRY"].ToString();
                model.FoundedYear = Convert.ToInt32(dr["FOUNDEDYEAR"]);
                model.CEO = dr["CEO"].ToString();

                lst.Add(model);
            }
            return lst;
        }
    }
}
