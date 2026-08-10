using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery_System
{
    class Bakery
    {

        public string[] items = {
            "1. Cake      ------- Rs.50",
            "2. Pasta     ------- Rs.30",
            "3. coffee    ------- Rs.40",
            "4. donut     ------- Rs.50",
            "5. Ice_Cream ------- Rs.100",
            "6. Egg_puff  ------- Rs.25"
        };

        public int price=0;
        public char extra_item;
        int quantity;
        public int item;
        long Total_Amount;
        bool discount = true;
        double final_bill;
        public void Select_item()
        {


            do
            {
                Console.WriteLine("==========Menu==========");

                for (int i = 0; i < items.Length; i++)
                {
                    Console.WriteLine(items[i]);
                }

                Console.WriteLine("=====Select your item=====");
                Console.Write("What are you going to pick: ");
                item=Convert.ToInt32(Console.ReadLine());

                Console.Write("How many do you want: ");
                quantity = Convert.ToInt32(Console.ReadLine());

                switch (item)
            {
                case 1:
                    Console.WriteLine("Your item is: Cake");
                    price = 50;
                    break;
                case 2:
                    Console.WriteLine("Your item is: Pasta");
                    price = 30;
                    break;

                case 3:
                    Console.WriteLine("Your item is: Coffee");
                    price = 40;
                    break;

                case 4:
                    Console.WriteLine("Your item is: Donut");
                    price = 50;
                    break;

                case 5:
                    Console.WriteLine("Your item is: Ice_Cream");
                    price = 100;
                    break;

                case 6:
                    Console.WriteLine("Your item is: Egg_Puff");
                    price = 25;
                    break;
            }

                Total_Amount += (quantity * price);
                Console.Write("Do you anything else(y/n):");
                extra_item = Convert.ToChar(Console.ReadLine());

                
            }
            while (extra_item == 'y');

            Console.WriteLine("Your total bill is : "+ Total_Amount);


            Console.WriteLine("Can I get any discount");
            if (discount == true)
            {

                Console.WriteLine("Alright, let me check. Yes, you can get a 10 % discount");

                final_bill = Total_Amount *0.90;

                Console.Write("Here's your final bill: " + final_bill);
            }

        }

    }
}
