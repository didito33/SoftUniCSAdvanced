using System;
using System.Collections.Generic;

namespace _07.Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] cmdSplit = input.Split(", ");
                if (cmdSplit[0] == "IN")
                {
                    set.Add(cmdSplit[1]);
                }
                else if (cmdSplit[0] == "OUT")
                    set.Remove(cmdSplit[1]);
                input = Console.ReadLine();
            }
            if (set.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
                Environment.Exit(0);
            }
            else
            {
                foreach (var item in set)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
