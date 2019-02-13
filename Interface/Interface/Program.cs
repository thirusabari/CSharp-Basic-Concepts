using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface details
    {
        void assignData(string firstName, string lastName);
        String getData();
    }
    class Program : details
    {
        protected string first;
        protected string last;
       public void assignData(string firstName, string lastName)
    {
        first = firstName;
        last = lastName;
    }
       public String getData()
       {
           return first +" "+ last;
       }
        static void Main(string[] args)
        {
            Console.WriteLine("Interface Implementation Example");
            Program pro = new Program();
            Console.WriteLine();
            pro.assignData("Thirunavukkarasu", "G");
            Console.WriteLine();
            Console.WriteLine(pro.getData());
            Console.WriteLine();
            Console.ReadKey();
        }
    }
    
}
