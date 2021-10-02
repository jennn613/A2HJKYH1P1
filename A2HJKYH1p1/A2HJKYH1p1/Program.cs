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
}
