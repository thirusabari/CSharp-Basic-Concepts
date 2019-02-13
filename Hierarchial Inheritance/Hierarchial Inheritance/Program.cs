using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchial_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Heirarchial Inheritacne Example");
            son s = new son();
            s.msg();
            Console.ReadKey();
        }
    }
    class father
    {
        public void show(){
            Console.WriteLine("I am your Dad");
        }
    
    }
    class mother : father
    {
        public void dis()
        {
            Console.WriteLine("I am your husband");
        }
    }
    class son : father
    {
        public void msg()
        {
            Console.WriteLine("I am Your Fatehr");
        }
    }
}
