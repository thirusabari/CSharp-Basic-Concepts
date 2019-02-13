using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevel_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multilevel Inheritance Example");
            c check = new c();
            check.dis();
            check.sh();
            check.showme();
            Console.ReadKey();
            
        }
    }
    class a
    {
        public void dis()
        {
            Console.WriteLine("I am number 1");
        }
    }
    class b : a
    {
        public void sh()
        {
            Console.WriteLine("I am number 2");
        }
    }
    class c : b
    {
        public void showme()
        {
            Console.WriteLine("I am number 3");
        }
    }
}
