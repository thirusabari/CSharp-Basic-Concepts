using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_or_CompileTimePolymorphism_EarlyBinding_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Static or Compile Time Polymorphism (Also Known as Early Binding");
            Console.WriteLine();
            Console.WriteLine("It is also known as Early Binding. Method overloading is an example of Static Polymorphism. In Overloading, the method / function has the same name but different signatures. It is also known as Compile Time Polymorphism because the decision of which method is to be called is made at compile time. Overloading is the concept in which method names are the same with a different set of parameters.");
            Console.WriteLine();
            check ck = new check();
            int x = ck.add(4, 5, 6);
            int y = ck.add1(10, 15);
            Console.WriteLine("The sum of 2 values are = " + x + y);
            Console.ReadKey();
        }
    }
    class check
    {
        public int add(int a, int b, int c)
        {
            return a + b + c;
        }
        public int add1(int a, int b)
        {
            return a + b;
        }

    }
}
