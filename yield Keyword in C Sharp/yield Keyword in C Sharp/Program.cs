using System;
using System.Collections.Generic;
using System.Collections;

namespace yield_Keyword_in_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementation of Yield Keyword in C# with List");
            Console.WriteLine();


            // Create a List
            List<string> names = new List<string>();
            names.Capacity = 6;

            Console.WriteLine("Get the Input From the User");
            Console.WriteLine();

            //Get the List Input From the User
            foreach (string n in names)
            {
                string temp = Console.ReadLine();
                if (temp.Length != 0 && temp != " " && temp != "  ")
                {
                    names.Add(temp);
                    temp = string.Empty;
                }
            }

            //Print the List values entered by the user in the Console Window
            Console.WriteLine("Print the Values Entered by the User");
            Console.WriteLine();

            foreach (string na in names)
            {
                Console.WriteLine(na);
            }
            Console.WriteLine();

            Console.WriteLine("Get the TamilSelvi in above list with the help of yield keyword");
            display(names);
            void display(List<string> words)
            {
                foreach (string word in words)
                {
                    if (word == "TamilSelvi") yield return word;
                }
            }
            

            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
