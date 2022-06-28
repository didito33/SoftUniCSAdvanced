using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {//10, 24, 12, 71
            List<decimal> numbers = Console.ReadLine().Split(", ").Select(decimal.Parse).ToList();
            /*Func<decimal, decimal> vatAdder = n => n + n * 0.2m;
            numbers = numbers.Select(vatAdder).ToList(); edni i sushti sa/*/
            numbers = numbers.Select(n => n + n * 0.2m).ToList();
            numbers.ForEach(n => Console.WriteLine($"{n:f2}"));
        }
    }
}
