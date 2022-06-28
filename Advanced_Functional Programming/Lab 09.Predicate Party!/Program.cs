using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_09.Predicate_Party_
{
    class Program
    {/*Peter Misha Stephen
Remove StartsWith P
Double Length 5
Party!*/
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            string cmd = Console.ReadLine();
            while(cmd != "Party!")
            {
                string[] cmdSplitted = cmd.Split();

                string method = cmdSplitted[0];
                string operation = cmdSplitted[1];
                string value = cmdSplitted[2];

                if (method == "Double")
                {
                    List<string> doubleNames = names.FindAll(GetPredicate(operation, value));
                    if (!doubleNames.Any())
                    {
                        cmd = Console.ReadLine();
                        continue;
                    }
                    int index = names.FindIndex(GetPredicate(operation, value));//zashtoto iskame da vkarame imeto tochno predi tova
                    names.InsertRange(index, doubleNames);
                }
                else
                {
                    names.RemoveAll(GetPredicate(operation, value));
                }
                cmd = Console.ReadLine();
            }
            if (names.Any())
            {
                Console.WriteLine($"{string.Join(", ",names)} are going to the party!");
            }
            else
                Console.WriteLine("Nobody is going to the party!");
        }

        private static Predicate<string> GetPredicate(string operation, string value)
        {
            if(operation == "StartsWith")
            {
                return x => x.StartsWith(value);
            }
            if(operation == "EndsWith")
            {
                return x => x.EndsWith(value);
            }
            int valueAsInt = int.Parse(value);
            return x => x.Length == valueAsInt;
        }
    }
}
