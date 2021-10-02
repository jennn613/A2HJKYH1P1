/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2HJKYH1p1
{
    class Program
    {
        static void Main(string[] args)
        {
            string quarter; // yearly quarter that the customer registered
            string membershipNum; // membership number
            int itemNum; // number of items purchased
            double itemCost; // cost of a single item
            double totalCost; // total cost

            Console.WriteLine("Please enter the qurater you regieterd in ");
            quarter = Console.ReadLine();
            Console.WriteLine("Enter your membership number: ");
            membershipNum = Console.ReadLine();
            Console.WriteLine("How many items did you buy?: ");
            itemNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How much is single cost?: ");
            itemCost = Convert.ToInt32(Console.ReadLine());
        }
    }
}*/
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
            string quarter;
            string membershipNum;
            int itemNum;
            double itemCost;
            double totalCost;
            double tax;
            double finalCost;

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

            // Displaying information to the user
            Console.WriteLine("");
            Console.WriteLine(quarter + " is the quarter you registered in.");
            Console.WriteLine("Membership number: " + membershipNum);
            Console.WriteLine("Total items: " + itemNum);
            Console.WriteLine("Total cost before adjustment: " + totalCost);
            Console.WriteLine("Final cost: " + finalCost);

        }
    }
}
