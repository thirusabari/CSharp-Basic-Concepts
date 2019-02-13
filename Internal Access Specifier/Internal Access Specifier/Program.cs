using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal_Access_Specifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Internal Access Modifier Example");
            Console.WriteLine();
            Console.WriteLine("Internal access specifier allows a class to expose its member variables and member functions to other functions and objects in the current assembly. In other words, any member with internal access specifier can be accessed from any class or method defined within the application in which the member is defined.");
            Console.WriteLine();
            data d = new data();
            d.name = "Thirunavukkarasu";
            d.initial = "G";
            d.show();
            Console.ReadKey(); 
        }
    }
    class data
    {
        internal string name;
        internal string initial;
        string set(){
            return name+" "+initial;
        }
        public void show()
        {
            Console.WriteLine("The Fullname is  = " + set());
            
        }
    }
}
