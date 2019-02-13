using System;
using System.Collections.Generic;

namespace Joining_String_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Joining String List with Comma Operator");
            Console.WriteLine();

            Console.WriteLine(" Next we use string.Join on a List of strings.This is helpful when we need to turn several strings into one comma - delimited string.");
            Console.WriteLine("It requires the ToArray instance method on List. This ToArray is not an extension method. ");
            Console.WriteLine("The biggest advantage of Join here is that no trailing comma is present on the resulting string.");
            Console.WriteLine();

            //Initialize the String list
            List<string> set = new List<string>();

            //Set the Size of the List with List.Capacity Property
            set.Capacity = 7;

            Console.WriteLine("Enter the String names for your list");
            

            //Get the List Input From the User
            for(int s=0;s<set.Capacity;s++)
            {
                set.Add(Console.ReadLine());
            }

            //Combine the List Items with Comma

            string line = string.Join(",", set);

            //Print the Comma Separated String

            Console.WriteLine("The comma Separated String is given below");
            Console.WriteLine();
            Console.WriteLine(line);
            Console.ReadLine();
        }
    }
}
