using System;

namespace Lab02.Knight_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            Action<string[]> printNames = allNames //=> Console.WriteLine("Sir" + string.Join("\n" + "Sir", allNames));
                =>
            {
                foreach (var item in allNames)
                {
                    Console.WriteLine($"Sir {item}");
                }
            }; // I dvata nachina stavat
            printNames(names);
        }
    }
}
