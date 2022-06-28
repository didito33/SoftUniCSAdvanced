using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountSameValues
{
    class Program
    {
        static void Main(string[] args)
        {//-2.5 4 3 -2.5 -5.5 4 3 3 -2.5 3
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double, int> numberOccurrences = new Dictionary<double, int>();
            foreach (var number in numbers)
            {
                if (!numberOccurrences.ContainsKey(number))
                {
                    numberOccurrences.Add(number, 0);
                    //numberOccurrences[number] = 0;

                }
                numberOccurrences[number]++;
            }
            foreach (var occurrence in numberOccurrences)
            {
                Console.WriteLine($"{occurrence.Key} - {occurrence.Value} times");
            }
        }
    }
}
