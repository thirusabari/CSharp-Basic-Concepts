using System;
using System.Collections.Generic;

namespace Reversing_List_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reversing of List Elements");

            //Initialize the List Type
            List<string> calls = new List<string>();
            calls.Capacity = 10;

            Console.WriteLine("Enter the String list values one by one .....");
            for(int x = 0; x < calls.Capacity; x++)
            {
                string say = Console.ReadLine();
                if (say.Length != 0 && say != null)
                {
                    calls.Add(say);
                } // If the User Enters Empty or none of the data, the console window will automatically closed
                else 
                {
                    Environment.Exit(0);
                }

            }

            // Ensure the list elments having special charactrs or not

            bool chk = calls.TrueForAll(element => element.Contains("*/-+_@&$#%"));
            

            if (calls.Count != 0 && !chk)
            {
                // Print the Elements Present in the List
                Console.WriteLine("Print the Element values present in the last");
                Console.WriteLine();
                foreach(string c in calls)
                {
                    Console.WriteLine(c);
                }
                calls.Reverse();

                Console.WriteLine("The Reversed Array Are Given below");
                Console.WriteLine();

                // Print the Reversed the list Items with the foreach loop
                foreach (string cal in calls)
                {
                    Console.WriteLine(cal);
                }
                Console.WriteLine();
            }
            // Reverse the list Type
            Console.ReadLine();
        }
    }
}
