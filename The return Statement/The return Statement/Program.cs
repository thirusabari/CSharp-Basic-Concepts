using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_return_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = sum(10, 25);
            Console.WriteLine("The sum of two values are ={0} ",value);
            Console.ReadLine();
        }
        static int sum(int x,int y){
            return x + y;
        }
    }
}
