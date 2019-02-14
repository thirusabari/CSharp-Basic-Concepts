using System;
using System.Collections.Generic;

namespace list.Remove_All
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("list.RemoveAll Implementation");
            Console.WriteLine();

            Console.WriteLine("Removes all items matching the specified predicate.");
            Console.WriteLine();

            // Create a List
            List<int> group = new List<int>();

            // Add values into the List
            group.Add(12);
            group.Add(34);
            group.Add(56);
            group.Add(78);
            group.Add(100);

            // Print the All Items in the List
            Console.WriteLine("The list Contains following Items There are");
            Console.WriteLine();

            foreach(int g in group)
            {
                Console.WriteLine(g);
            }
            Console.WriteLine();

            //Remove all items which is lesser than 50 in above list with RemoveAll() method
            group.RemoveAll(x => x < 50);

            // Again print the List items

            Console.WriteLine("The List value which is lesser than the 50 are removed with the RemoveAll Method");
            Console.WriteLine("There are ");
            Console.WriteLine();

            foreach(int g1 in group)
            {
                Console.WriteLine(g1);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
