using System;
using System.Collections.Generic;

namespace List.RemoveRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List.RemoveRange() Implementationa");
            Console.WriteLine();

            Console.WriteLine("Removes items from the specified range.");
            Console.WriteLine();

            //Initialize the String List

            List<string> centers = new List<string>();
            centers.Capacity = 7;

            // Add Values into the List
            centers.Add("CSC Computer Education");
            centers.Add("TNPSC Coaching Center");
            centers.Add("Jurassic Park");
            centers.Add("Anna Museum");
            centers.Add("national park");
            centers.Add("bangalore");
            centers.Add("Chennai");

            Console.WriteLine("The Values in the List are ");
            Console.WriteLine();



            void print()
            {
                foreach(string c in centers)
                {
                    Console.WriteLine(c);
                }
                Console.WriteLine();
            }
            // Print the list values
            print();

            //Remove the 2 values from the 3rd index position in the above list
            centers.RemoveRange(3, 2);
            Console.WriteLine("Remove 2 Values from the 3rd Index position in the above list");

            //Again print the values
            print();

            Console.ReadLine();

            

        }
    }
}
