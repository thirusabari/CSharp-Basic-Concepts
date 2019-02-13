using System;
using System.Collections.Generic;

namespace Copies_Array_to_a_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Copy An Array Elements into a list And Finally Print the items");
            Console.WriteLine();
            // If you enter empty space as input, console window will automatically exits
            Console.WriteLine("Enter the Elements to your new Array");
            //Create a Array
            int[] nums = new int[5];
            int arrlen = nums.Length;
            int n;

            //Get the Input Elements from the User through the Console Window with foreach
            for (n = 0;n<arrlen;n++)
            {
                bool condition;
                
                
                string value = Console.ReadLine();
                
                condition = int.TryParse(value,out int nw);
                if (condition)
                {
                    nums[n] = nw;                    
                }
                else
                {
                    Environment.Exit(0);
                }
            }

            //Create an Empty List and Copy the Array Items Into it
            List<int> elements = new List<int>(nums);

            Console.WriteLine("Print the Number of Elements in the List ");
            Console.WriteLine();

            //Print the List Elements in the Console Window

            foreach(int e in elements)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }
    }
}
