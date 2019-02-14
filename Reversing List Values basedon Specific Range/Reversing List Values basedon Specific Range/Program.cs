using System;
using System.Collections.Generic;

namespace Reversing_List_Values_basedon_Specific_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reversing List Elements based upon the Specific Range");
            Console.WriteLine();

            Console.WriteLine("Reverses the order of the items in the specified range.");
            Console.WriteLine();

            // Create the List
            List<int> nums = new List<int>();
            nums.Capacity = 8;

            //Initialize the Values for the List
            nums.Add(123);
            nums.Add(2345);
            nums.Add(4567);
            nums.Add(1234);
            nums.Add(1000);
            nums.Add(12000);
            nums.Add(13000);

            //Print the Elements of the List
            Console.WriteLine("The Elements in the list ara");
            Console.WriteLine();
            
            void print()
            {
                foreach(int n in nums)
                {
                    Console.WriteLine(n);
                }
                Console.WriteLine();
            }
            print();

            Console.WriteLine("Reverse the Middle values of above list using list.Reverse() method");
            Console.WriteLine();

            nums.Reverse(2, 3);

            Console.WriteLine("The Re ordered list values are Given below");
            print();

            Console.ReadLine();
        }
    }
}
