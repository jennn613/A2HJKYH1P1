﻿using System;
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
            double discountedTotalCost; // 
            double furtherDiscountedTotalCost; // 
            double finalDiscountedCost;
            double tax; // tax
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
            discountedTotalCost = Discount(itemNum, totalCost);
            tax = 0.13 * totalCost;
            finalCost = totalCost + tax;

            if (discountedTotalCost < 0)
            {
                discountedTotalCost = totalCost * 0.13;
            }

            furtherDiscountedTotalCost = Discount(discountedTotalCost);
            
            if (furtherDiscountedTotalCost < 0)
            {
                furtherDiscountedTotalCost = 0;
            }

            switch (Convert.ToInt32(quarter))
            {
                case 1:
                    finalDiscountedCost = furtherDiscountedTotalCost - 15;
                    if (finalDiscountedCost < 0)
                    {
                        finalDiscountedCost = 0;
                    }
                    break;
                case 2:
                    finalDiscountedCost = furtherDiscountedTotalCost - 15;
                    if (finalDiscountedCost < 0)
                    {
                        finalDiscountedCost = 0;
                    }
                    break;
                case 3:
                    finalDiscountedCost = furtherDiscountedTotalCost - 5;
                    if (finalDiscountedCost < 0)
                    {
                        finalDiscountedCost = 0;
                    }
                    break;
                case 4:
                    finalDiscountedCost = furtherDiscountedTotalCost - 1;
                    if (finalDiscountedCost < 0)
                    {
                        finalDiscountedCost = 0;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid yearly quarter. enter again");
                    //quarter =  Console.ReadLine();
                    //Console.WriteLine(quarter);
                    //I want to change the value of quarter that they entered and make this switch statement work again. But I can't figure this out ;_;
                    break;
            }



            // Displaying information to the user
            //Console.WriteLine(quarter + " is the quarter you registered in.");
            //Console.WriteLine("Membership number: " + membershipNum);
            //Console.WriteLine("Total items: " + itemNum);
            //Console.WriteLine("Total cost before adjustment: " + totalCost);
            //Console.WriteLine("Final cost: " + finalCost);
            //Console.WriteLine("First discounted price: " + discountedTotalCost);
            //Console.WriteLine("Second discounted price: " + furtherDiscountedTotalCost);
        }


        static double Discount(int a, double b) // discount by number of purchsed items, a = itemNum, b = totalCost
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

    }
}
