using System;
using System.Collections.Generic;


namespace list.ConvertAll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("list.ConvertAll Implementation");
            Console.WriteLine();

            Console.WriteLine("Converts items using specified delegate. Items can be converted to another type.");
            Console.WriteLine();

            // Create New List
            List<int> convert = new List<int>();
            convert.Capacity = 5;

            //Add Values to the List
            convert.Add(1);
            convert.Add(13);
            convert.Add(14);
            convert.Add(15);
            convert.Add(100);

            // Print the List Elements
            void print(List<int> one)
            {
                foreach(int con in one)
                {
                    Console.WriteLine(con);
                }
                Console.WriteLine();
            }
            void deci(List<decimal> de)
            {
                foreach(decimal d in de)
                {
                    Console.WriteLine(d);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Print the Values of List");
            Console.WriteLine();
            print(convert);
            var conv = new Converter<int, decimal>(x => (decimal)(x + 1));
            //Perform the list.ConvertAll() for convert named list
            List<decimal> decims=convert.ConvertAll<decimal>(conv);

            Console.WriteLine("Print the Converted list value");
            Console.WriteLine();
            deci(decims);

            Console.WriteLine("Convert the Integer List Values into Decimals with List.ConvertAll()");
            Console.WriteLine();

            //Convert a list into another list type with convert All
            List<decimal> dec = convert.ConvertAll(x =>(decimal) (x+1) );

            //Print the Decimally Converted List
            Console.WriteLine("Print the Decimally Converted list");
            Console.WriteLine();

            foreach(decimal d in dec)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
