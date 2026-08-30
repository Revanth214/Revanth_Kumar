using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDataAccessLayer
{
    public class EmployeeModel
    {
        public int Emp_ID { get; set; }
        public string Emp_Name { get; set; }
        public string Job { get; set; }
        public decimal Salary { get; set; }
    }
}
