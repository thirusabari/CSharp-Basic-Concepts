using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_goto_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Goto Statement Implementation");
            Console.WriteLine();
            string name="TamilSelvi";
            switch(name){
                case "arul":
                    Console.WriteLine("Arul");
                    break;
                case "anu":
                    Console.WriteLine("Anu");
                    break;
                case "selva":
                    Console.WriteLine("Selva");
                    break;
                case "TamilSelvi":
                    Console.WriteLine("TamilSelvi");
                    goto case "arul";
                default:
                    Console.WriteLine("Match not found");
                    break;
            }
            Console.ReadLine();
        }
    }
}
