using System;
using System.Collections.Generic;

namespace list.equals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementation of list.equals method");
            Console.WriteLine();

            Console.WriteLine("Returns true if the two specified lists are reference equal (are the same instance).");
            Console.WriteLine();

            //Create a New List
            List<int> one = new List<int>() { 1, 2, 3, 4 };
            var two = one;
            bool cond1 = one.Equals(two);

            if (cond1)
            {
                Console.WriteLine("List one and two are Equal");
            }
            else
            {
                Console.WriteLine("List one and two are not Equal");
            }

            Console.WriteLine("Returns false if the specified two lists are not the same instance. To determine whether all items of the two lists are equal use LINQ method SequenceEqual.");
            Console.WriteLine();

            //Create List three and 4;
            List<int> three = new List<int>() { 1, 2, 3, 4 };
            List<int> four = new List<int>() { 5, 6, 7, 8 };
            bool cond2 = three.Equals(four);

            if (cond2)
            {
                Console.WriteLine("List 3 and 4 are Equal");
            }
            else
            {
                Console.WriteLine("List 3 and 4 are not Equal");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
