using System;
using System.Collections.Generic;

namespace GetRange_in_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementation of GetRange Method in list Type");

            //Initialize Integer List
            List<int> values = new List<int>() { 12,10,27,34,56,78,90,100,23,21};
            List<int> newval = new List<int>(values.GetRange(1, 8));

            //Print the actual List items 
            Console.WriteLine("Print the Actual List Item values. There are ");
            Console.WriteLine();
            foreach(int v in values)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine();
            //Print the Small Range List Types
            Console.WriteLine("Small Range Trimmed List Values Are Given Below. There are");
            Console.WriteLine();
            foreach(int nv in newval)
            {
                Console.WriteLine(nv);
            }
            Console.WriteLine();


            Console.ReadLine();
        }
    }
}
