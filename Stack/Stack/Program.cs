using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Stack1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementation of Stack In C#");
            Console.WriteLine();
            Console.WriteLine("Last In First Out Concept");
            Console.WriteLine();
            Stack s = new Stack();  //Last In First Out Concept
            s.Push("Thirunavukkaerasu");
            s.Push("TamilSelvi");
            s.Push("Logeshwaran");
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.ReadLine();
        }
    }
}
