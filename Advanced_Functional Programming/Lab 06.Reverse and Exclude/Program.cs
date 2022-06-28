using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_06.Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).Reverse().ToArray();
            int divisionNumber = int.Parse(Console.ReadLine());

            Func<int, int, bool> isDivisible = (x, divisionNumber) => x % divisionNumber == 0;
            List<int> result = numbers.Where(x => !isDivisible(x, divisionNumber)).ToList();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
