using System;
using System.Linq;

namespace _02.Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> parser = x => int.Parse(x);
            var numbers = Console.ReadLine().Split(", ").Select(parser).ToArray();
            Console.WriteLine(numbers.Length);
            Console.WriteLine(numbers.Sum());
        }
       
    }
}
