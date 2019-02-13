using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Multiple_Catch_Blocks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiple Catch Blocks Implementations");
            int x = 0, result;
            try
            {
                result = 100 / x;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divide By Zero Exception is found");
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
            }
            finally
            {
                Console.WriteLine("Final block");
            }
            Console.ReadLine();
        }
    }
}
