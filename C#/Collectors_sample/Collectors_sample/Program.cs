using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collectors_sample
{
    class Program
    {
        static void Main(string[] args)
        {

            //Generic Collections-List, Array, Dictionary

            List<string> courses = new List<string>();
            courses.Add(".NET");
            courses.Add("Pytjon");
            courses.Add(".UniBasic");
            courses.Add("SQL");
            courses.Add("Java");

            foreach (string s in courses)
            {
                Console.WriteLine(s);

            }
            List<Student_Model> sm = new List<Student_Model>();
            Student_Model model = new Student_Model();

            model.Id = 12;
            model.Name = "Revanth";
            model.Marks = 100;
            model.Sports = "Kabaddi";
            model.Gender = 'M';

            sm.Add(model);

            foreach (var item in sm)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Marks);
                Console.WriteLine(item.Sports);
                Console.WriteLine(item.Gender);
            }

            //Dict

            Dictionary<string, object> my_dict = new Dictionary<string, object>();
            my_dict.Add("Name", "Krishna");
            my_dict.Add("Addres", "Dwaraka");
            my_dict.Add("Skill", "Flutist");

            foreach (var item in my_dict)
            {
                Console.WriteLine(item);
            }




            // Hashtable

            Hashtable hash_table = new Hashtable();
            { 
            hash_table.Add(1, "Cake");
            hash_table.Add(2, "Milk");
            hash_table.Add(3, "Egg");
            hash_table.Add(4, "Meat");
            hash_table.Add(5, "Fish");
            }
            foreach (DictionaryEntry item in hash_table)
            {
                Console.WriteLine(item.Value);
            }

            foreach(DictionaryEntry item in hash_table)
            {
                Console.WriteLine(item.Key + ":"+hash_table[item.Key]);
            }




            Console.ReadLine();
        }
    }
}
