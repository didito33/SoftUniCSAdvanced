using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            //Queue<string> queue = new Queue<string>();
            string input = Console.ReadLine();
            while (input != "END")
            {
                if (input == "PARTY")
                {
                    while (input != "END")
                    {
                        input = Console.ReadLine();
                        if (set.Contains(input))
                            set.Remove(input);
                    }
                }
                else 
                {
                    set.Add(input);
                    input = Console.ReadLine();
                }
            }

            Console.WriteLine(set.Count);
            foreach (var item in set)
            {
                char[] charArray = item.ToCharArray();
                if (char.IsNumber(charArray[0]))
                {
                    Console.WriteLine(item);
                    set.Remove(item);
                }
                
            }
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}
