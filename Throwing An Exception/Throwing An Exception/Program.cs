using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Throwing_An_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Throwing an Exception in C#");
            try
            {
                throw new DivideByZeroException("Invalid Data");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divide By Zero Exception is Thrown");
            }
            finally
            {
                Console.WriteLine("Final block");
            }
            Console.ReadLine();
        }
    }
}
