using System;
using System.Collections.Generic;

namespace Keys_In_Dictionary_with_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print out the Keys in Dictionary using List");
            Console.WriteLine();
            Console.WriteLine("We use the List constructor to get a List of keys from a Dictionary.This is a simple way to iterate over Dictionary keys(or store them elsewhere).");
            Console.WriteLine();
            Console.WriteLine("The Keys property returns an enumerable collection of keys.But a List of these elements is more usable.");
            Console.WriteLine();
            //Initialize the Dictionary
            Dictionary<string, int> Record = new Dictionary<string, int>();
            Record.Add("Thirunavukkarasu", 4554);
            Record.Add("Selvakumar", 23456);
            Record.Add("Umasaravana", 45678);
            Record.Add("Santhiya", 6789);
            Record.Add("Vel Murugan", 456321);

            //Print the Dictionary Items with For each loop
            Console.WriteLine("The key value Pairs Available in the Dictionary Are ");
            Console.WriteLine();

            foreach(KeyValuePair<string,int> rec in Record)
            {
                Console.WriteLine("Key:{0},Value:{1}", rec.Key, rec.Value);
                Console.WriteLine();
            }

            Console.WriteLine("The Keys Values Stored in the List Type Are");
            Console.WriteLine();
            //Take the Keys From Dictionary Using List Type
            List<string> k = new List<string>(Record.Keys);

            //Print the Dictionary keys Stored in the List
            foreach(string Ke in k)
            {
                Console.Write("{0} ",Ke);
            }
            Console.WriteLine();
            Console.Read();

        }
    }
}
