using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_03.Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> elements = new SortedSet<string>();
            for (int i = 0; i < n; i++)
            {
                // List<string> chemicals = Console.ReadLine().Split().ToList();
                string[] chemicals = Console.ReadLine().Split();
                foreach (string chemical in chemicals) elements.Add(chemical);

            }
            Console.WriteLine(string.Join(" ", elements));
        }
        
    }

}
