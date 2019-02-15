using System;
using System.Collections.Generic;

namespace Dictionary_Methdods
{
    public static class Display
    {
        public static void Print(Dictionary<string,string> details)
        {
            foreach(var d in details)
            {
                Console.WriteLine("Key:Value = {0}:{1}", d.Key, d.Value);
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dictionary Methods Implementation");
            Console.WriteLine("1.Add");
            Console.WriteLine("2. Update An Existing Item");
            Console.WriteLine("3.Remove");
            Console.WriteLine("4.Clear");
            Console.WriteLine("5.Find a Key");
            Console.WriteLine("6.Find a Value");

            // Create object for the Display

            // Initialize a Dictionary
            Dictionary<string, string> Inform = new Dictionary<string, string>();

            // 1. Add Values into the Dictionary
            Inform.Add("Thirunavukkarasu", "Head");
            Inform.Add("Subaashini", "Lead");
            Inform.Add("pavithra", "Memeber");
            Inform.Add("Saranya", "Memeber");
            Inform.Add("Umapthy","Member");
            Inform.Add("Selvi", "Family Lead");
            Inform.Add("TamilSelvi", "Member");

            // Print the Elements of the Dictionary to the Console
            Display.Print(Inform);

            // Update an Existing Item

            Inform["pavithra"] = "Family Member";

            Console.WriteLine("After Update the Dictionary, Print the Values into the Console");
            Console.WriteLine();

            Display.Print(Inform);

            // Remove an Item From the Dictionary
            Inform.Remove("Subaashini");

            Console.WriteLine("After removed the Subaashini from the Dictionary, Print the All Elements of the Dictioanry");

            Display.Print(Inform);

            Console.WriteLine("Find a key Pragadeesh Found in the Dictionary. If Not Found, add a similar one. And Then Finally Print all the items into the Console");

            //Find a Key Pragadeesh in the above Dictionary. if it is not found, add one. And Then Finally print all the Items presnet in the Dictionary
            if (!Inform.ContainsKey("Pragadeesh"))
            {
                Inform["Pragadeesh"] = "Kanmani Subbiah";
                Display.Print(Inform);
            }

            Console.WriteLine("Find a Value Teacher Found in the Dictionary. If it is not found, add a similar one. And Then Print all the items to the Console");

            //Find a value Teacher in the above Dictionary, If it is not founf, add a similar one. Then Finally Print all the items present in the Dictioanry
            if (!Inform.ContainsValue("Teacher"))
            {
                Inform["Amutha"] = "Teacher";
                Display.Print(Inform);
            }

            //Remove all the items in the Dictionary with the help of clear method
            Inform.Clear();

            Console.WriteLine("The Number of Elements in the Dictionary are = {0}", Inform.Count);

            Console.ReadLine();
        }
    }
}
