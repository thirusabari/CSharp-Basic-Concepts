using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_with_try_and_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exception Handling Implementation with try and catch");
            int x = 0, div = 0;
            try
            {
                div = 100 / x;
                Console.WriteLine("The statement didnit executed");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divide by Zero Exception thrown");
            }
            finally
            {
                Console.WriteLine("The result will be = {0}", div);
            }
            Console.ReadLine();
        }
    }
}
