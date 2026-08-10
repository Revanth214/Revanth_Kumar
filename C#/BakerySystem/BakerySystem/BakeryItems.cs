using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerySystem
{
    class BakeryItems
    {
        public string[] item = { "cake", "past", "Puff", "Samosa", "Donut", "Desserts", "Ice-Creame" };
        int price;
        public void select_item(string name, int quantity, char extra)
        {
            switch (name)
            {
                case "cake":
                    Console.WriteLine(item[0]);
                    price = 50;
                    break;

                case "past":
                    Console.WriteLine(item[1]);
                    price = 30;
                    break;

                case "Puff":
                    Console.WriteLine(item[2]);
                    price = 60;
                    break;

                case "Samosa":
                    Console.WriteLine(item[3]);
                    price = 55;
                    break;

                case "Donut":
                    Console.WriteLine(item[4]);
                    price = 80;
                    break;

                case "Dessert":
                    Console.WriteLine(item[5]);
                    price = 90;
                    break;

                case "Ice-Cream":
                    Console.WriteLine(item[6]);
                    price = 100;
                    break;
            }

            while (extra=='Y')
            {
                //price = quantity                                                                                          * price;
            }
            Console.WriteLine(price);


            if (quantity=='Y')
            {
                select_item(name, quantity, extra);
            }
            else
            {
                return;
            }
        }

    }

}
