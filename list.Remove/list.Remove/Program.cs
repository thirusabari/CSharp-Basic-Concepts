using System;
using System.Collections.Generic;

namespace list.Remove
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lists.Remove Implementation");
            Console.WriteLine();

            //Initialize a List
            List<float> ant = new List<float>();
            ant.Capacity = 6;

            // Add Values to the List
            ant.Add(1.13f);
            ant.Add(2.14f);
            ant.Add(3.14f);
            ant.Add(4.67f);
            ant.Add(3.456f);
            ant.Add(12.345f);

            //Now Remove the flaoting point value 4.67f from the above list

            ant.Remove(4.67f);

            Console.WriteLine("Display the Items in the List");

            Console.WriteLine();

            foreach(float an in ant)
            {
                Console.WriteLine(an);
            }
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
