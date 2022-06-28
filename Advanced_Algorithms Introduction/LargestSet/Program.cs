using System;
using System.Collections.Generic;
using System.Linq;

namespace LargestSet
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> universe = new List<int> { 1, 3, 5, 7, 9, 11, 20, 30, 40 };
            List<int[]> sets = new List<int[]>
            {
                new[] { 6 },
                new[] { 20 },
                new[] { 1, 5, 20, 30 },
                new[] { 3, 7, 20, 30, 40 },
                new[] { 9, 30 },
                new[] { 11, 20, 30, 40 },
                new[] { 3, 7, 40 },

            };
            int[] largestSubsetOfUniverse = sets
                .OrderByDescending(x => x.Count(element => universe.Contains(element)))
                .FirstOrDefault();
            for (int i = 0; i < largestSubsetOfUniverse.Length; i++)
            {
                Console.Write($"{largestSubsetOfUniverse[i]} ");
            }
        }
    }
}
