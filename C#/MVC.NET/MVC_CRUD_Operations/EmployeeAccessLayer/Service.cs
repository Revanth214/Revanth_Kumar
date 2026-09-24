using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAccessLayer
{
    public class Service
    {
        SqlConnection connection = new SqlConnection("Server=LAPTOP-RBLEO; Database=SQLMasteryLab; Integrated Security=true");
        public List<Model> GetEmployeeDetails()
        {
            SqlCommand cmd = new SqlCommand("select * from employee", connection);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet set = new DataSet();
            connection.Open();
            adp.Fill(set);
            connection.Close();

            List<Model> lst = new List<Model>();
            foreach (DataRow dr in set.Tables[0].Rows)
            {
                Model model = new Model();
                model.Emp_ID = Convert.ToInt32(dr[0]);
                model.Emp_Name = dr["Emp_Name"].ToString();
                model.Salary = (dr["salary"]==DBNull.Value ? (decimal?)null : Convert.ToDecimal(dr["salary"]));

                lst.Add(model);
            }
            return lst;

        }


        public void InsertEmployee(EmployeeCreateModel model)
        {
            SqlCommand cmd = new SqlCommand("InsertEmployee", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empname", model.Emp_Name);
            cmd.Parameters.AddWithValue("@email", model.Email);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void UpdateEmployee(Model model)
        {
            SqlCommand cmd = new SqlCommand("UpdateEmployee", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empid", model.Emp_ID);
            cmd.Parameters.AddWithValue("@empname", model.Emp_Name);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteEmployee(Model model)
        {
            SqlCommand cmd = new SqlCommand("DeleteEmployee", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empid", model.Emp_ID);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
