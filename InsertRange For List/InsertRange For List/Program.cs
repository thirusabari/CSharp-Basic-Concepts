using System;
using System.Collections.Generic;
namespace InsertRange_For_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert Range Implementation for the List");
            Console.WriteLine();
            Console.WriteLine("InsertRange method Inserts the elements of a collection into the ArrayList at the specified index.");
            Console.WriteLine();

            //Create a Integer List
            List<int> insert = new List<int>();
            insert.Add(1);
            insert.Add(2);
            insert.Add(3);
            insert.Add(4);
            insert.Add(5);

            //Create a integer array
            int[] arr = new int[5];
            arr[0] = 1234;
            arr[1] = 3456;
            arr[2] = 4567;
            arr[3] = 6789;
            arr[4] = 2345;

            //Insert the created array in above list at a specific index

            insert.InsertRange(5, arr);

            //Print the all array elements with for each loop

            Console.WriteLine("The List Elements are ");
            Console.WriteLine();
            foreach(int a in insert)
            {
                Console.WriteLine("{0}", a);
            }

            Console.ReadLine();
        }
    }
}
