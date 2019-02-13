using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Continue_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementation of Continue Statement");
            for (int j = 0; j < 10; j++)
            {
                if (j == 2 || j == 8)
                    continue;
                Console.WriteLine(j);
            }
            Console.ReadLine();
        }
    }
}
