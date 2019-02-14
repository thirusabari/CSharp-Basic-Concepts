using System;
using System.Collections.Generic;

namespace List.Exists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List.Exists Implementation");
            Console.WriteLine();

            Console.WriteLine("Returns true if the list contains items matching the specified predicate");
            Console.WriteLine();

            //Create a List 
            var animals = new List<int>();

            //Add Integer Values into the List
            animals.Add(10);
            animals.Add(100);
            animals.Add(1000);
            animals.Add(1500);

            // Print the Integer Values
            Console.WriteLine("The Integer Values Entered by the user are given below");
            foreach(var a in animals)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();

            // Implement the list.Exists'
            bool cond = false;
            cond = animals.Exists(x => x == 100);
            Console.WriteLine("Check Whether the number 100 is present in the list or not ");
            Console.WriteLine();
            if (cond)
            {
                Console.WriteLine("The number 100 is present in the list");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The Number 100 is not present in the list");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
