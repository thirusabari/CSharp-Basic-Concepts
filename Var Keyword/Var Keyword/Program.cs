using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Var_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Var Keyword Definition for List Items");

            //Initialize a list item with var keyword
            var pay = new List<int>();
            pay.Capacity = 5;

            //Now Enter the list elements value through the console window

            Console.WriteLine("Enter the List Elements value one by one");
            Console.WriteLine();

            for(int c = 0; c < pay.Capacity; c++)
            {
                bool con = false;
                string temp = Console.ReadLine();
                con = int.TryParse(temp, out int sa);
                if (con)
                {
                    pay.Add(sa);
                }
                else
                {
                    Console.WriteLine("You have Entered Invalid data. The Data = {0}", temp);
                    Console.WriteLine();
                    Console.WriteLine("The Window Will Automatically Exists within 3 Seconds");
                    Console.WriteLine();
                    Thread.Sleep(3000);
                    Environment.Exit(0);
                }
            }

            if (pay.Count != 0)
            {
                Console.WriteLine("Print the List item value Entered by the User");
                Console.WriteLine();
                foreach(int p in pay)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
