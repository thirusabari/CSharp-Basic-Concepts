using System;
using System.Collections.Generic;

namespace Custom_Function_to_do_the_Conversion
{
    class Program
    {
         static double performSquare(int x)
        {
            return x*x;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Custom Functions to do the Conversion");
            Console.WriteLine();

            // Create a new integer List and add values into it
            List<int> integer = new List<int>();
            integer.Capacity = 5;
            integer.Add(4);
            integer.Add(8);
            integer.Add(12);
            integer.Add(16);
            integer.Add(24);

            //Create a Converter for the custom function
            Converter<int, double> dob = performSquare;
            List<double> cons=integer.ConvertAll<double>(dob);

            // Print the Double converted values
            foreach (double co in cons)
            {
                Console.WriteLine(co);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
