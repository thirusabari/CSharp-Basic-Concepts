using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Single_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class properties
    {
        public int width;
        public int length;
        public string w, l;
        public bool res1, res2;
        public void getValue()
        {
            Console.WriteLine("Enter the Width of the rectangle");
            w = Console.ReadLine();
            Console.WriteLine("Enter the Lenght of the Rectangle");
            l = Console.ReadLine();

            //Check user input value is an integer or not
            res1 = int.TryParse(w, out width);
            res2 = int.TryParse(l, out length);

            if (res1 && res2)
            {
                Console.WriteLine("You have Entered the Rectangle width as ={0}", width);
                Console.WriteLine("You have Entered the Rectangle length as ={0}", length);
            }
            else
            {
                Console.WriteLine("You have Entered The Invalid Data. This window will automatically closed within 3 seconds!");

            }
        }
    }
}
