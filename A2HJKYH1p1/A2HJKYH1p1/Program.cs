using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2HJKYHS1P1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Defining variables
            string quarter; // yearly quarter that the customer registered
            string membershipNum; // membership number
            int itemNum; // number of items purchased
            double itemCost; // cost of a single item
            double totalCost; // total cost
            double tax; // calculate tax
            double finalCost; // final cost

            // Getting user input
            Console.WriteLine("Please enter the quarter you registered in: ");
            quarter = Console.ReadLine();

            Console.WriteLine("Please enter your membership number: ");
            membershipNum = Console.ReadLine();

            Console.WriteLine("Please enter the number of items you are purchasing today: ");
            itemNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the cost of the item you are purchasing today: ");
            itemCost = Convert.ToDouble(Console.ReadLine());

            // Calculations
            totalCost = itemCost * itemNum;
            tax = 0.13 * totalCost;
            finalCost = totalCost + tax;

            if (5 < itemNum && itemNum < 10)
            {
                discountedTotalCost = totalCost - 20;
            }
            else (10 < itemNum)
            {
                discountedTotalCost = totalCost * 70 / 100;
            }

            if (discountedTotalCost <= 0)
            {
                totalCost = totalCost * 0.13;
            }

            if (discountedTotalCost > 100)
            {
                furtherDiscountedTotalCost = discountedTotalCost * 97.5 / 100;
            }
            else (discountedTotalCost < 30)
            {
                furtherDiscountedTotalCost = discountedTotalCost - 2;
            }

            if (furtherDiscountedTotalCost < 0)
            {
                furtherDiscountedTotalCost = 0;
            }
            


            // Displaying information to the user
            //Console.WriteLine("");
            //Console.WriteLine(quarter + " is the quarter you registered in.");
            //Console.WriteLine("Membership number: " + membershipNum);
            //Console.WriteLine("Total items: " + itemNum);
            //Console.WriteLine("Total cost before adjustment: " + totalCost);
            //Console.WriteLine("Final cost: " + finalCost);

        }
    }
}
