using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract Class Example");
            dog mydog = new dog();
            cat one = mydog;
            one.eat();
            mydog.sound();
            Console.ReadKey();
        }
    }
    abstract class cat
    {
        public abstract void eat();
        public void sound()
        {
            Console.WriteLine("The cat will miyaavvv");
        }
    }
    class dog : cat
    {
        public void dogsound()
        {
            Console.WriteLine("The dogs will barks");
        }
        public override void eat()
        {
            Console.WriteLine("Cat eats curd, milk");
        }
    }
}
