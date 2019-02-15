using System;
using System.Collections.Generic;

namespace Adding_Items_into_the_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adding Items into the Dictionary");

            //Create a dictionary with integer and string parameters

            Dictionary<int, string> personal = new Dictionary<int, string>();
            personal.Add(12, "Muthukumar");
            personal.Add(14, "Vinoth");
            personal.Add(16, "Santhosh");
            personal.Add(18, "Thirumurugan");
            personal.Add(20, "Waging");

            // Print the Dictionary Item to the Console Window
            Console.WriteLine("Print the Key Value Pair");

            foreach(var p in personal)
            {
                Console.WriteLine("{0}:{1}", p.Key, p.Value);
            }
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
