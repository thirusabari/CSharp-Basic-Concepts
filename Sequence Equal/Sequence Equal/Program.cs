using System;
using System.Collections.Generic;
using System.Linq;

namespace Sequence_Equal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a Program to Implement the Sequence Equals Concept with the List method");

            //Initialize the First String
            Console.WriteLine();
            List<string> one = new List<string>() { "Value1", "Value2", "Value3", "Value4" };

            //Copy first string into new string
            List<string> two = new List<string>(one);

            if (one.SequenceEqual(two))
            {
                Console.WriteLine("The Two Lists Are Equal");
            }
            Console.ReadKey();
        }
    }
}
