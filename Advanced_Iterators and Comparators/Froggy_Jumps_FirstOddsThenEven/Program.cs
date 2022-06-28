using System;
using System.Collections.Generic;
using System.Linq;

namespace IteratorsAndComparators
{
    class Program
    {
        static void Main(string[] args)
        {// 1, 2, 3, 4, 5, 6, 7, 8
            List<int> elements = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            Lake lake = new Lake(elements);
            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
