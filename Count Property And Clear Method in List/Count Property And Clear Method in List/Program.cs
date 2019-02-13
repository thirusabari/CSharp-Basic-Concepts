using System;
using System.Collections.Generic;

namespace Count_Property_And_Clear_Method_in_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementation of List's Count Property And Clear method");
            Console.WriteLine();

            //Create new List
            List<int> li = new List<int>();
            li.Add(1200);
            li.Add(1400);
            li.Add(1600);
            li.Add(1800);
            li.Add(1900);

            //Count the Number of Elements in Above List
            Console.WriteLine("The number of Elements in the List is ={0}", li.Count);
            Console.WriteLine();

            //Clear the Number of Elements in Above List
            li.Clear();
            Console.WriteLine(li.Count);
            //Print the Available List Elements using foreach
            //foreach(int l in li)
            //{
            //    Console.WriteLine(l);
            //}
            Console.ReadLine();
        }
    }
}
