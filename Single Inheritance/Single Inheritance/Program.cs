using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Single Inheritance Example");
            two t = new two();
            t.display();
            t.show();
            Console.ReadLine();
        }
    }
    class one
    {
        public void display() {
            Console.WriteLine("I am number One");
        }
    }
    class two : one
    {
        public void show()
        {
            Console.WriteLine("I am number two");
        }
    }
}
