using System;
using System.Collections.Generic;

namespace Creating_New_Integer_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating New Integer List!");
            Console.WriteLine();
            List<int> num = new List<int>();
            num.Add(10);
            num.Add(45);
            num.Add(55);
            num.Add(100);
            num.Add(150);

            //Display the number of elements in a list
            Console.WriteLine("The Number of Elements in above list is = {0}", num.Count);
            Console.ReadLine();
        }
    }
}
