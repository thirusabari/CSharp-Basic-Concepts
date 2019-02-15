using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;

namespace Get_the_Dictionary_Values_From_the_user
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Get the Input For the user Through the Console Window");

            //Create a Dictionary
            Dictionary<int, string> detail = new Dictionary<int, string>();

            //Get the Inputs for the Dictionary Item Through the Console Window
            Console.WriteLine("Get the Input values From the User");
            Console.WriteLine();

            int count = 1;

            for(int d=0;d<10;d++)
            {
                Console.WriteLine("Enter the {0} - Key And value ", count);
                string num,word;
                bool chk = false;
                num = Console.ReadLine();
                chk = int.TryParse(num, out int Number);
                
                word = Console.ReadLine();
                bool whitespace = String.IsNullOrWhiteSpace(word);
                if (chk && word.Length!=0 && !whitespace)
                {
                    detail.Add(Number, word);
                    count++;
                }
                else
                {
                    Console.WriteLine("You have entered Invalid Data ={0}, {1}",num,word);
                    Console.WriteLine();
                    Console.WriteLine("The Console Window will automatcially Exits within  3 Seconds");
                    Console.WriteLine();
                    Thread.Sleep(3000);
                    Environment.Exit(0);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Print the Items Entered by the User to the Console Window");
            Console.WriteLine();

            foreach(var t in detail)
            {
                Console.WriteLine("{0}:{1}", t.Key, t.Value);
            }
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
