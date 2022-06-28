using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.CitiesByContinentCountry
{
    class Program
    {
        static void Main(string[] args)
        {/*9
Europe Bulgaria Sofia
Asia China Beijing
Asia Japan Tokyo
Europe Poland Warsaw
Europe Germany Berlin
Europe Poland Poznan
Europe Bulgaria Plovdiv
Africa Nigeria Abuja
Asia China Shanghai*/
            Dictionary<string, Dictionary<string, List<string>>> map = new Dictionary<string, Dictionary<string, List<string>>>();
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                string[] inputSplit = Console.ReadLine().Split();
                string continent = inputSplit[0];
                string country = inputSplit[1];
                string city = inputSplit[2];
                if (!map.ContainsKey(continent))// ако нямаме Key-a
                {
                    map[continent] = new Dictionary<string, List<string>>();//createvam dict
                }
                if (!map[continent].ContainsKey(country))//aко го няма записано в листа
                        map[continent][country] = new List<string>();//createvam lista
                
                map[continent][country].Add(city);// във всеки случай, просто добавям
                
            }
            //map = map.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in map)
            {
                Console.Write($"{item.Key}:\n");
                foreach (var subItem in item.Value)
                {                           //    Country                   City
                    Console.WriteLine($" {subItem.Key} -> {string.Join(", ", subItem.Value)}");
                }
            }
        }
    }
}
