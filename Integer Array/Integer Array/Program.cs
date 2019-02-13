using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Integer Array Implementation");
            int[] set = new int[10] { 1,2,3,4,5,6,7,8,9,10};
            foreach (int s in set)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            Console.WriteLine("Another Array Type Implementation");
            int[] set1 = new int[5];
            set1[0] = 10;
            set1[1] = 20;
            set1[2] = 30;
            set1[3] = 40;
            set1[4] = 50;
            for (int i = 0; i < set1.Length; i++)
            {
                Console.WriteLine(set1[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Another Array Type Implementation");
            int[] set3 = { 30, 60, 80, 90, 100 };
            foreach (int t in set3)
            {
                Console.WriteLine(t);
            }
            Console.Read();

        }
    }
}
