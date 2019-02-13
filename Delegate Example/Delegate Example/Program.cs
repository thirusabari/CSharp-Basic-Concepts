using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int Sum(int i);
namespace Delegate_Example
{
    class Program
    {
        static int n = 25;
        public static int add(int a)
        {
            n += a;
            return n;
        }
        public static int mul(int b)
        {
            n *= b;
            return n;
        }
        public static int num()
        {
            return n;
        }
        static void Main(string[] args)
        {
            Sum s = new Sum(add);
            Sum s1 = new Sum(mul);

            //Calling the methods with delegate Objects
            s(4);
            Console.WriteLine("Value of Num: {0}", num());
            s1(10);
            Console.WriteLine("Value of Num:{0}", num());
            Console.ReadLine();

        }
    }
}
