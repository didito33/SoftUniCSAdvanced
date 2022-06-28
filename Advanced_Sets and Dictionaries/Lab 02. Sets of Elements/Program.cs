using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int m = input[1];
            HashSet<int> hashN = new HashSet<int>();
            HashSet<int> hashM = new HashSet<int>();
            HashSet<int> hashCombined = new HashSet<int>();
            FillSet(hashN,n);
            FillSet(hashM, m);
            hashN.IntersectWith(hashM);
            Console.WriteLine(string.Join(" ", hashN));
            /*for (int j = 0; j < m; j++)
            {
                int mNumber = int.Parse(Console.ReadLine());
                hashM.Add(mNumber);
                if(hashN.Contains(mNumber))
                hashCombined.Add(mNumber);
            }
            foreach (var item in hashCombined)
            {
                Console.Write($"{item} ");
            }*/
            
           

        }
        private static void CompareSets(HashSet<int> firstSet, HashSet<int> secondSet)
        {
            /* List<int> nums = new List<int>();
             foreach(int currNum in firstSet)
             {
                 if (secondSet.Contains(currNum))
                     nums.Add(currNum);

             }
             Console.WriteLine(string.Join(' ', nums));*/
            firstSet.IntersectWith(secondSet);
            Console.WriteLine(string.Join(' ', firstSet));
        }
        private static HashSet<int> FillSet(HashSet<int> set, int length)
        {
            for (int i = 0; i < length; i++)
            {
                set.Add(int.Parse(Console.ReadLine()));
            }
            return set;
        }
    }
}
