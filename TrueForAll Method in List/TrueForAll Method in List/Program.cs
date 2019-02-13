using System;
using System.Collections.Generic;

namespace TrueForAll_Method_in_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TrueForAll Method Implementation in List");

            Console.WriteLine();
            Console.WriteLine("This method accepts a Predicate. If the Predicate returns true for each element in the List, TrueForAll() will also return true. ");
            Console.WriteLine();
            Console.WriteLine("TrueForAll() checks the entire list—unless an element doesn't match (it has an early exit condition).");
            Console.WriteLine();
            //Initializa a new List
            List<int> collect = new List<int> { 12, 34, 56, 78, 100 };

            //Print the List Items to the Console Window
            Console.WriteLine("The list Items are ");
            Console.WriteLine();

            foreach(int c in collect)
            {
                Console.Write("{0} ", c);
            }

            Console.WriteLine();

            //Check the List Item Values are Greater than 100 or not
            if (collect.TrueForAll(element => element > 100))
            {

                Console.WriteLine("The Given List Items are not Greather Than 100");

            }

            //Check the Initialized List Items are Lesser than 150
            if (collect.TrueForAll(element => element < 150))
            {
                Console.WriteLine("The Given List Items are lesser than 150");
            }

            //Check if the Initialized list item value is lesser than 50 or not
            if (collect.TrueForAll(element => element < 50))
            {
                Console.WriteLine("The Given list Items are not lesser than 50");
            }
            Console.ReadKey();
        }
    }
}
 