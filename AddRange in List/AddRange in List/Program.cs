using System;
using System.Collections.Generic;

namespace AddRange_in_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementation of AddRange in List!");

            //Create A Integer List
            List<int> range = new List<int>();
            range.Add(23);
            range.Add(45);
            range.Add(78);
            range.Add(100);

            // Create new Array to be added 
            int[] set = new int[4];
            set[0] = 0;
            set[1] = 1;
            set[2] = 2;
            set[3] = 3;

            // Add the Created Array into the list with "AddRange" 
            range.AddRange(set);

            Console.WriteLine("The List Elements are Given below");

            //Print the List Elemenets with For each loop
            foreach(int r in range)
            {
                Console.WriteLine(r);

            }
            Console.ReadLine();


        }
    }
}
