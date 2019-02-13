using System;
using System.Collections.Generic;

namespace Insert_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write to Program For Inserting Data into an existing List with Insert() Method");
            Console.WriteLine();

            //Initialize a List
            List<int> numbers = new List<int>();
            numbers.Capacity = 6;

            //Assign values to the List "numbers"
            numbers.Add(10);
            numbers.Add(100);
            numbers.Add(1000);

            Console.WriteLine("The numbers list containing the below values. There are");
            Console.WriteLine();

            //Print the Elements present in the list
            foreach(int n in numbers)
            {
                Console.Write("{0} ", n);
            }
            Console.WriteLine();

            //Now Insert the value as "12" at index 1th location

            numbers.Insert(1, 234455666);

            //Finally Print the Values of List Type
            Console.WriteLine("Finally, The list values are ");

            foreach(int m in numbers)
            {
                Console.Write("{0} ", m);
            }
            Console.WriteLine();
            Console.ReadLine();
            
        }
    }
}
