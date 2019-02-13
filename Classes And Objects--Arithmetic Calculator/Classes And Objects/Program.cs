using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Classes_And_Objects
{
    class calculator
    {
        public string num1;
        public string num2;
        public int n1, n2;
        bool check1,check2;
        public int result;
        public string op;
        public float answer;
        public int count = 0;
        public void getData()
        {
            Console.WriteLine("Enter the First Number");
            num1 = Console.ReadLine();
            
            Console.WriteLine("Enter the Second Number");
            num2 = Console.ReadLine();

            check1 = int.TryParse(num1, out n1);
            check2 = int.TryParse(num2, out n2);

            if (check1 && check2)
            {
                Console.WriteLine("You have entered the first number as = {0}", n1);
                Console.WriteLine("You have entered the second number as = {0}", n2);
            }
            else
            {
                Console.WriteLine("You have entered Invalid Datas");
                Thread.Sleep(3000);
                Console.Clear();
                Environment.Exit(0);
            }
        }
        public void printData()
        {
            Console.WriteLine("You have entered the first number as = {0}", num1);
            Console.WriteLine("You have entered the second number as = {0}", num2);
        }
        public void chooseOperation()
        {
            Console.WriteLine("Calculator Operations");
            Console.WriteLine("Add");
            Console.WriteLine("Subtract");
            Console.WriteLine("Multiplication");
            Console.WriteLine("Division");
            Console.WriteLine("Percentage");
            Console.WriteLine("Enter a Operation from Above list");
            op = Console.ReadLine();
            if (op.Length != 0 && op != null && op != " ")
            {
            switch (op.ToUpper())
            {
                case "ADD":
                    result = n1 + n2;
                    Console.WriteLine("The sum of {0} and {1} are = {2}", n1, n2, result);
                    break;
                case "SUBTRACT":
                    result = n1 - n2;
                    Console.WriteLine("The Differences of {0} and {1} are = {2}", n1, n2, result);
                    break;
                case "MULTIPLICATION":
                    result = n1 * n2;
                    Console.WriteLine("The mulitplication of {0} and {1} are = {2}", n1, n2, result);
                    break;
                case "DIVISION":
                    answer = n1 / n2;
                    Console.WriteLine("The division of {0} and {1} are = {2}", n1, n2, answer);
                    break;
                case "PERCENTAGE":
                    answer = n1 % n2;
                    Console.WriteLine("The Percentage of {0} and {1} are = {2}", n1, n2, answer);
                    break;
                default:
                    Console.WriteLine("Invalid Operations You have entered");
                    Console.Clear();
                    if(n1!=0 && n2!=0 && n1!=null && n2!=null){
                        printData();
                        chooseOperation();
                    }
                    break;
                }
            }

        }

    }

    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator Functionality Implementation with Integer Data Type");
            calculator calc = new calculator();
            //get Data from the user
            calc.getData();
            //perform the operation
            calc.chooseOperation();
            Console.ReadLine();
        }
    }
}
