using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_10.Party_Reservation_Filter_Module
{
    class Program
    {/*Peter Misha Slav
Add filter;Starts with;P
Add filter;Starts with;M
Print*/
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            string cmd = Console.ReadLine();
            Dictionary<string, Predicate<string>> allFilters = new Dictionary<string, Predicate<string>>();
            while (cmd != "Print")
            {
                string[] cmdSplitted = cmd.Split(";");

                string method = cmdSplitted[0];
                string operation = cmdSplitted[1];
                string value = cmdSplitted[2];
                cmd = Console.ReadLine();
                if(method == "Add filter")
                {
                    allFilters.Add(operation + value,GetPredicate(operation,value));
                }
                else
                {
                    allFilters.Remove(operation + value);
                }
                
            }
            foreach (var filter in allFilters)
            {
                names.RemoveAll(filter.Value);
            }
                
        }

        private static Predicate<string> GetPredicate(string operation, string value)
        {
            if (operation == "Starts with")
            {
                return x => x.StartsWith(value);
            }
            if (operation == "Ends with")
            {
                return x => x.EndsWith(value);
            }
            if(operation == "Contains")
            {
                return x => x.Contains(value);
            }
            int valueAsInt = int.Parse(value);
            return x => x.Length == valueAsInt;
        }
    }
}
