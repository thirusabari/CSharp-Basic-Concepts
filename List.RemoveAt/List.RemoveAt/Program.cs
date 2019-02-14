using System;
using System.Collections.Generic;

namespace List.RemoveAt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List.RemoveAt Implementation");
            Console.WriteLine();

            Console.WriteLine("Removes the first occurence of the specified item from the list.");
            Console.WriteLine();

            //Create a List
            List<int> one = new List<int>();
            one.Capacity = 5;

            // Add Element values to the List
            one.Add(10);
            one.Add(15);
            one.Add(30);
            one.Add(45);
            one.Add(60);

            // Print the value in the list
            print();
            void print()
            {
                foreach(int o in one)
                {
                    Console.WriteLine(o);
                }
                Console.WriteLine();
            }

            //Remove the index 3 positined value in the List.RemoveAt()

            one.RemoveAt(3);

            Console.WriteLine("The 3th index positioned value isa removed from the list");
            Console.WriteLine();

            // print the list values

            print();

            Console.ReadLine();

        }
    }
}
