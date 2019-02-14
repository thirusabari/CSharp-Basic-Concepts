using System;
using System.Collections.Generic;

namespace list.find
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("list.find() Implementation");
            Console.WriteLine();
            Console.WriteLine("Returns the first occurrence of item matching the specified predicate.");
            Console.WriteLine();
            // Create New List
            List<int> collect = new List<int>();

            //Adding Elements to the List
            collect.Add(234);
            collect.Add(1111);
            collect.Add(8765);
            collect.Add(1000);
            collect.Add(1234567780);

            //Print the List item value entererd by the user

            Console.WriteLine("The List values Entered by the User Are");
            Console.WriteLine();

            foreach(var c in collect)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine();

            // Perform the list.find() Method
            int f = collect.Find(e => e > 1000);

            Console.WriteLine("The Elements Value Greater than 1000 are = {0}", f);

            Console.ReadLine();
        }
    }
}
