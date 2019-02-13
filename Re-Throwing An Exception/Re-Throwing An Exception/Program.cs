using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re_Throwing_An_Exception
{
    class cause
    {

        public void Check()
        {
            try
            {
                int x = 0, result;
                result = 100 / x;
            }
            catch (DivideByZeroException)
            {
                throw;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rethrowing an exception implementation");
            cause ca = new cause();
            try
            {
                ca.Check();
            }
            catch (Exception)
            {
                Console.WriteLine("Exception Caught Here");
            }
            Console.ReadLine();
        }
    }
    
}
