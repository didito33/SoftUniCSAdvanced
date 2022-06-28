using System;
using System.Collections.Generic;

namespace HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();//contains Unique elements
            set.Add(5);
            set.Add(5);
            set.Add(5);//dobavq samo 1 put
            set.Add(6);
            set.Add(3);
            set.Add(7);
            if (set.Contains(5))
            {
                //Insanely Fast
            }
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

        }
    }
}
