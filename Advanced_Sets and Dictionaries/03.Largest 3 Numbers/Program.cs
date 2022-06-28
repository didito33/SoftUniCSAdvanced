using System;
using System.Linq;

namespace _03.Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sortedNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            sortedNumbers = sortedNumbers.OrderByDescending(x => x).ToArray();
            for (int i = 0; i < 3; i++)
            {
                if (i == sortedNumbers.Length)
                    break;
                Console.Write($"{sortedNumbers[i]} ");
            }
        }
    }
}
