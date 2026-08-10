using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; // These are all name spaces

namespace Firstappication
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter your Name: ");
			string name = Console.ReadLine();
			Console.WriteLine("User entered name is : " + name);
			Console.WriteLine("Enter number: ");
			float num = Convert.ToSingle(Console.ReadLine());
			Console.WriteLine(num);
			int a = Convert.ToInt32(num);
			Console.WriteLine(a);
			Console.ReadLine();
		}
	}
}
