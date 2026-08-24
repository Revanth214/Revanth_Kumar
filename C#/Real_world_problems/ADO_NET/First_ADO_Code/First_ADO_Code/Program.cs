using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace First_ADO_Code
{
    class EmployeeDetails
    {
        SqlConnection connection = new SqlConnection(
            "Server=LAPTOP-RBLEO; Database=SQLMasteryLab; Integrated Security=true"
        );

        public List<EmployeeModel> GetEmpDetails()
        {
            SqlCommand cmd = new SqlCommand(
                "SELECT * FROM Employee",
                connection
            );

            SqlDataAdapter ada = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            connection.Open();

            ada.Fill(ds);

            connection.Close();

            List<EmployeeModel> lst = new List<EmployeeModel>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                EmployeeModel model = new EmployeeModel();

                model.EMP_ID = Convert.ToInt32(dr["EMP_ID"]);
                model.EMP_Name = dr["EMP_Name"].ToString();
                model.Salary = Convert.ToDecimal(dr["Salary"]);

                lst.Add(model);
            }

            return lst;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeDetails model = new EmployeeDetails();

            List<EmployeeModel> employees = model.GetEmpDetails();

            foreach (EmployeeModel employee in employees)
            {
                Console.WriteLine("Employee ID: " + employee.EMP_ID);
                Console.WriteLine("Employee Name: " + employee.EMP_Name);
                Console.WriteLine("Salary: " + employee.Salary);
                Console.WriteLine("----------------------------");
            }

            Console.ReadLine();
        }
    }
}