using System;
using System.Collections.Generic;

namespace List_Manipulation_with_for_and_foreach_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List Manipulation with for and for each loops");

            //Create a string List 
            List<string> names = new List<string>();
            names.Add("Thirunavukkarasu");
            names.Add("TamilSelvi");
            names.Add("Vinoth");
            names.Add("Selvaraj");
            names.Add("Umashankar");

            Console.WriteLine("The Elements in the string List Are Given below");
            Console.WriteLine();

            //Print the strings available in the "names" using foreach loop
            foreach (string n in names)
            {
                Console.WriteLine("{0}", n);
            }
            Console.WriteLine();
            //Create new float List
            List<float> fl = new List<float>();
            fl.Add(56.78f);
            fl.Add(34.21f);
            fl.Add(100.98f);
            fl.Add(45.3400f);
            fl.Add(1.123f);

            //Print the Float List Elements with for loop

            Console.WriteLine("The Elements Present in the Float List Are Given Below ");
            Console.WriteLine();
            for (int i = 0; i < fl.Count; i++)
            {
                Console.WriteLine("{0}", fl[i]);
            }

            Console.Read();
        }
    }
}
