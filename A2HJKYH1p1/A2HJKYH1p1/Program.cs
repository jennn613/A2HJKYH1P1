/* 
 * Program ID: assignment2
 * 
 * Program Authors:
 *      Yusuf Hafeji
 *      Hyunjin Kim
 * 
 * 
 * Revision History:
 *      created Oct 3, 2021 by Yusuf Hafeji, Hyunjin Kim
 *      
 */

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
            string quarter; // yearly quarter 
            string membershipNum; // membership number
            int itemNum; // number of items purchased
            double itemCost; // cost of single item
            double totalCost; // total cost of items
            double discountedTotalCost; // first discount from total cost
            double furtherDiscountedTotalCost; // second discount from total cost
            double finalDiscountedTotalCost; //The last discounted cost
            double finalCost; // final cost

            // Getting user input

            do
            {
                Console.Write("Please enter the quarter you registered in: ");
                quarter = Console.ReadLine();

                if (Convert.ToInt32(quarter) > 5 || 0 >= Convert.ToInt32(quarter))
                {
                    Console.WriteLine("Invalid quarter. Please enter your quarter again.");
                }
                else
                {
                    break;
                }

            } while (Convert.ToInt32(quarter) > 5 || 0 >= Convert.ToInt32(quarter));

            Console.Write("Please enter your membership number: ");
            membershipNum = Console.ReadLine();

            Console.Write("Please enter the number of items you are purchasing today: ");
            itemNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the cost of the item you are purchasing today: ");
            itemCost = Convert.ToDouble(Console.ReadLine());

            // Calculations
            totalCost = itemCost * itemNum;
            discountedTotalCost = Discount(itemNum, totalCost);

            if (discountedTotalCost < 0)
            {
                discountedTotalCost = totalCost * 0.13;
            }

            furtherDiscountedTotalCost = Discount(discountedTotalCost);
            
            if (furtherDiscountedTotalCost < 0)
            {
                furtherDiscountedTotalCost = 0;
            }

            finalDiscountedTotalCost = QuarterDiscount(Convert.ToInt32(quarter), furtherDiscountedTotalCost);

            finalCost = finalDiscountedTotalCost * 1.13;

            if (finalCost < 20)
            {
                finalCost = 0;
            }

            // Displaying information to the user
            Console.WriteLine("");
            Console.WriteLine(" ---------------------------------------------------- ");
            Console.WriteLine("");
            Console.WriteLine(quarter + " is the quarter you registered in.");
            Console.WriteLine("Membership number: " + membershipNum);
            Console.WriteLine("Total items: " + itemNum);
            Console.WriteLine("Total cost before adjustment: " + totalCost);
            Console.WriteLine("First discounted price: " + discountedTotalCost);
            Console.WriteLine("Second discounted price: " + furtherDiscountedTotalCost);
            Console.WriteLine("Final cost: " + finalCost);     
        }


        static double Discount(int a, double b) // discount by number of purchsed items, a = itemNum, b = totalCost
        {
            double discountedTotalCost;

            if (5 < a && a < 10)
            {
                discountedTotalCost = b - 20;
                return discountedTotalCost;
            }
            else if (a > 10)
            {
                discountedTotalCost = b * 70 / 100;
                return discountedTotalCost;
            }
            else
            {
                return b;

            }
        }

        static double Discount(double a) // discount by total cost, a = furtherDiscountedTotalCost;
        {
            double furtherDiscountedTotalCost;

            if (a > 100)
            {
                furtherDiscountedTotalCost = a * 97.5 / 100;
                return furtherDiscountedTotalCost;
            }
            else if (a < 30)
            {
                furtherDiscountedTotalCost = a - 2;
                return furtherDiscountedTotalCost;
            }
            else
            {
                return a;
            }
        }

        static double QuarterDiscount(int a, double b) // a = quarter, b = furtherDiscountedTotalCost
        {
            switch (Convert.ToInt32(a))
            {

                case 1:
                    if (a == 1)
                    {
                        b -= 15;
                    }
                    return b;

                case 2:
                    if (a == 2)
                    {
                        b -= 15;
                    }
                    return b;

                case 3:
                    if (a == 3)
                    {
                        b -= 5;
                    }
                    return b;

                case 4:
                    if (a == 4)
                    {
                        b -= 1;
                    }
                    return b;

                default:
                    Console.WriteLine("Invalid yearly quarter. Please enter again");
                    return a;
            }
        }

    }
}
