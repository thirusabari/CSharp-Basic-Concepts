using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation_of_String_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementation of String Array");
            string[] one;   //Declaration of String Array
            one=new string[5]{"Thirunavukkarasu","TamilSelvi","Baby","Gnanasekaran","Kumarasn"};
            foreach (string o in one)
            {
                Console.WriteLine(o);
            }
            Console.ReadKey();
        }
    }
}
