using System;
using System.Collections.Generic;

namespace DictMapAttempt
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> map = new Dictionary<string, Dictionary<string, List<string>>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string continent = input[0];
                string country = input[1];
                string city = input[2];
                if (!map.ContainsKey(continent))
                {
                    map[continent] = new Dictionary<string, List<string>>();
                }
                if (!map[continent].ContainsKey(country))
                {
                    map[continent][country] = new List<string>();
                }
                map[continent][country].Add(city);
            }
            foreach (var kvp in map)
            {
                Console.WriteLine($"{kvp.Key}:");
                foreach (var subItem in kvp.Value)
                {
                    Console.WriteLine($"{subItem.Key} -> {string.Join(", ", subItem.Value)}");
                }
            }
        }
    }
}
