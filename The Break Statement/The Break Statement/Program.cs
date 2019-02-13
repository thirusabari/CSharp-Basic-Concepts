using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Break_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Break Statement Example");
            for (int i = 0; i < 4; i++)
            {
                if (i == 3)
                    break;
                Console.WriteLine("Thirunavukkarasu");
            }
            Console.ReadLine();
        }
    }
}
