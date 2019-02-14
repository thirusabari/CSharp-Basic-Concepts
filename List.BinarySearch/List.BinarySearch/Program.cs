using System;
using System.Collections.Generic;

namespace List.BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("list.BinarySearch Implementation");
            Console.WriteLine();

            Console.WriteLine("Returns the zero-based index of the item in the sorted list. If the items is not found, returns a negative number.");
            Console.WriteLine();

            // Create a New List
            List<int> sympathy = new List<int>();
            sympathy.Capacity = 6;

            //Add Values into the List
            sympathy.Add(12);
            sympathy.Add(23);
            sympathy.Add(45);
            sympathy.Add(67);
            sympathy.Add(100);
            sympathy.Add(200);

            Console.WriteLine("Display the Items which are all availabel in the list");
            Console.WriteLine();
            void print()
            {
                foreach (int sym in sympathy)
                {
                    Console.WriteLine(sym);
                }
                Console.WriteLine();
            }
            print();

            Console.WriteLine("Search the Number 67 is present in the List or not");
            Console.WriteLine();
            int locate=sympathy.BinarySearch(67);

            Console.WriteLine("The Number 67 is located in the following index position = {0}", locate);
            Console.ReadLine();
        }
    }
}
