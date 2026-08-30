using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace EmployeeDataAccessLayer
{
    public class EmployeeDetails
    {
        SqlConnection connection = new SqlConnection("Server=LAPTOP-RBLEO; Database=SQLMasteryLab; Integrated Security=true");
        public List<EmployeeModel> GetEmployeeDetails()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM EMPLOYEE", connection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            connection.Open();
            sda.Fill(ds);
            connection.Close();
            List<EmployeeModel> my_lst = new List<EmployeeModel>();
            foreach(DataRow data in ds.Tables[0].Rows)
            {
                EmployeeModel model = new EmployeeModel();
                model.Emp_ID = Convert.ToInt32(data["EMP_ID"]);
                model.Emp_Name = data["EMP_NAME"].ToString();
                model.Job = data["JOB"].ToString();
                model.Salary = Convert.ToDecimal(data["SALARY"]);

                my_lst.Add(model);
            }
            return my_lst;
        }
    }
}
