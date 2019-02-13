using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_And_Objects
{
    class Accessspecfiers
    {
        static void Main(string[] args)
        {
            details d = new details();
            d.setData();
            d.show();
            //inform i = new inform();  // We cannot call the private class methods using those objects inside another classes
            //data da = new data(); // We cannot call the protcted class methods using those objects inside another classes
            page p = new page();
            p.set();
            p.show();
            
        }
    }
    public class details
    {
        public string name;
        public int dob;
        public string surname;
        public void setData()
        {
            name = "Thirunavukkarasu";
            dob = 26101993;
            surname = "Creator";
        }
        public void show()
        {
            Console.WriteLine("The Name = " + name);
            Console.WriteLine("The DOB = " + dob);
            Console.WriteLine("The SurName = " + surname);
            Console.ReadLine();
        }
    }
    /*private class inform
    {
        private string name;
        private int dob;
        private string surname;
        private void assign()
        {
            name = "TamilSelvi";
            dob = 30081995;
            surname = "Tamil";
        }
        private void display()
        {
            Console.WriteLine("The Name = " + name);
            Console.WriteLine("The DOB = " + dob);
            Console.WriteLine("The SurName = " + surname);
            Console.ReadLine();

        }
    }
    protected class data
    {
        protected string name;
        protected int dob;
        protected string surname;
        protected void set()
        {
            name = "Logeshwaran";
            dob = 06061993;
            surname = "Logesh";
        }
        protected void show()
        {
            Console.WriteLine("The Name = " + name);
            Console.WriteLine("The DOB = " + dob);
            Console.WriteLine("The Surname = " + surname);
            Console.ReadLine();
        }
    }*/
    internal class page
    {
        internal string name;
        internal int dob;
        internal string surname;
        internal void set()
        {
            name = "Logeshwaran";
            dob = 06061993;
            surname = "Logesh";
        }
        internal void show()
        {
            Console.WriteLine("The Name = " + name);
            Console.WriteLine("The DOB = " + dob);
            Console.WriteLine("The Surname = " + surname);
            Console.ReadLine();
        }
    }
}
