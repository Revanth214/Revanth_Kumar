using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdADO
{
    class Program
    {
        static void Main(string[] args)
        {
            DepartmentDetails dept_obj = new DepartmentDetails();
            List<DepartmentModel> model = dept_obj.GetDepartmentDetails();
            foreach(DepartmentModel dept in model)
            {
                Console.WriteLine(dept.Dept_Id);
                Console.WriteLine(dept.Dept_Name);
                Console.WriteLine(dept.Location);
                Console.WriteLine("=====================");
            }

            Console.ReadLine();
        }
    }
}
