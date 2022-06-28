using System;

namespace Lab_01.Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {//Lucas Noah Tea
            string[] names = Console.ReadLine().Split();
            Action<string[]> printNames = allNames //=> Console.WriteLine(string.Join("\n", allNames));
                =>
            {
                foreach (var item in allNames)
                {
                    Console.WriteLine(item);
                }
            }; // I dvata nachina stavat
            printNames(names);
                
        }
    }
}
