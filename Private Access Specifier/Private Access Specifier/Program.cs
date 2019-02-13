using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_Access_Specifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Private Access Modifier Sample Program");
            Console.WriteLine();
            Console.WriteLine("Private access specifier allows a class to hide its member variables and member functions from other functions and objects. Only functions of the same class can access its private members. Even an instance of a class cannot access its private members.");
            Console.WriteLine();
            pr p = new pr();
            p.assign();
            p.display();
            Console.ReadKey();
        }
    }
    class pr
    {
        private int length;
        private int breadth;
        public void assign()
        {
            length = 35;
            breadth = 56;

        }
        public void display()
        {
            Console.WriteLine("Area of Rectangle is = " + length * breadth);
        }
    }
}
