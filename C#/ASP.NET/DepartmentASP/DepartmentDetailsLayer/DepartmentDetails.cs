using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DepartmentDetailsLayer
{
    public class DepartmentDetails
    {
        SqlConnection connection = new SqlConnection("Server=LAPTOP-RBLEO; Database=SQLMasteryLab; Integrated Security=true");

        public List<DepartmentModel> GetDepartmentDetails()
        {
            SqlCommand cmd = new SqlCommand("Select * from department", connection);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            connection.Open();
            adp.Fill(ds);
            connection.Close();
            List<DepartmentModel> lst = new List<DepartmentModel>();
            foreach (DataRow data in ds.Tables[0].Rows)
            {
                DepartmentModel model = new DepartmentModel();
                model.Dept_Id = Convert.ToInt32(data["DEPT_ID"]);
                model.Dept_Name = data["DEPT_NAME"].ToString();
                model.Location = data["LOCATION"].ToString();

                lst.Add(model);
            }
            return lst;
        }
    }
}
