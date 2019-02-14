using System;
using System.Collections.Generic;

namespace list.Contains
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementation of list.contains");

            // Initialize New List Item

            List<string> pages = new List<string>();

            //Set the Capacity of the List
            pages.Capacity = 10;

            //Add Values to the list
            pages.Add("Sharmela");
            pages.Add("Hemalatha");
            pages.Add("Thirunavukkarasu");
            pages.Add("Kumaran");
            pages.Add("Vadivel");
            pages.Add("Sabarinathan");
            pages.Add("Kumar");
            pages.Add("Sakthiswaran");
            pages.Add("Mutharasan");
            pages.Add("Bharat");

            Console.WriteLine("list.contains()");

            Console.WriteLine("Returns true if the list contains the specified item.");
            Console.WriteLine();

            bool con = false;
            con = pages.Contains("TamilSelvi");
            if (con)
            {
                Console.WriteLine("pages list contains the TamilSelvi Value");
            }
            else
            {
                Console.WriteLine("Pages list does not contains the TamilSelvi");
            }

            Console.WriteLine();
            //Ensure another value present in the list or not

            bool con1 = false;
            con1 = pages.Contains("Sharmela");
            if (con1)
            {
                Console.WriteLine("Pages list contains the sharmela");
            }
            else
            {
                Console.WriteLine("Pages List does not containts the sharmelaa");
            }
            Console.ReadLine();
        }
    }
}
