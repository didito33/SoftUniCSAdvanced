using System;
using System.Collections.Generic;

namespace WardobeDict
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            FillDicionary(wardrobe, n);
        }

        private static void FillDicionary(Dictionary<string, Dictionary<string, int>> wardrobe, int n)
        {
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string color = input[0];
                string[] splittedInput = input[1].Split(",");
                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();
                }
                
            }
        }
    }
}
