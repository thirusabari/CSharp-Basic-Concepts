using System;
using System.Collections.Generic;

namespace list.ToArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("list.ToArray Implementation");
            Console.WriteLine();

            Console.WriteLine("Creates new Array and copies all list items into it");
            Console.WriteLine();

            // Create New Array
            List<string> man = new List<string>() { "One", "Two", "Three", "Four", "Five", "Six" };

            //Perform the list.toarray implementation
            string[] numbers = man.ToArray();
            
            for(int n = 0; n < numbers.Length; n++)
            {
                Console.WriteLine(numbers[n]);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
