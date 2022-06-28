using System;
using System.Collections.Generic;

namespace Lab_05.Count_Symbols
{
    class Program
    {//SoftUni rocks
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<char, int> symbolsCount = new SortedDictionary<char, int>();
            FillDictionary(symbolsCount, input);
            PrintResult(symbolsCount);
        }

        private static void PrintResult(SortedDictionary<char, int> symbolsCount)
        {
            foreach (var item in symbolsCount)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }

        private static SortedDictionary<char,int> FillDictionary(SortedDictionary<char, int> symbols, string input)
        {
            foreach (char symbol in input)
            {
                if (!symbols.ContainsKey(symbol))
                {
                    symbols.Add(symbol, 0);
                }
                symbols[symbol]++;
            }
            return symbols;
        }
    }
}
