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
            double discountedTotalCost; // discounted total cost
            //double furtherDiscountedTotalCost; // total cost after discounting twice
            double tax; // calculate tax
            double finalCost; // final cost
            
            /* --------------------------------------------------------------------------- */

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
            discountedTotalCost = FirstDiscount(itemNum, totalCost); // total cost after discounted 
            tax = 0.13 * totalCost;
            finalCost = totalCost + tax;


            if (discountedTotalCost < 0) // how can the cost be less than zero? the method and this if statement works well. I changed it to method bc if else if if didn't work
            {
                discountedTotalCost = - (totalCost * 0.13);
            }         

            //Console.WriteLine(discountedTotalCost); //you can check if my code works well or not 


            //try to make this by using method!

            /*if (discountedTotalCost > 100)
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

            furtherDiscountedTotalCost = 0; */


            // Displaying information to the user
            //Console.WriteLine("");
            //Console.WriteLine(quarter + " is the quarter you registered in.");
            //Console.WriteLine("Membership number: " + membershipNum);
            //Console.WriteLine("Total items: " + itemNum);
            //Console.WriteLine("Total cost before adjustment: " + totalCost);
            //Console.WriteLine("Final cost: " + finalCost);

        }

        static double FirstDiscount(int a, double b) // discount by number of purchsed items, a = itemNum, b = totalCost
        {
            double discountedTotalCost;

            if (5 < a && a < 10)
            {
                discountedTotalCost = b - 20;
                return discountedTotalCost;
            }
            else if (10 < a)
            {
                discountedTotalCost = b * 70 / 100;
                return discountedTotalCost;
            }
            else
            {
                return b;
            }
        }
    }
}
