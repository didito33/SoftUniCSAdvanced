using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {// INPUT -> 3 -> aa -> aaa -> bb -> aa
            /*       int left = 1;
            int right = 1;
            Console.WriteLine(left.CompareTo(right));// 1 and 1 => 0(same value), 1 and 2 => -1 ;   2 and 1 => 1*/
            int n = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();
            for (int i = 0; i < n; i++)
            {
                string stringValue = Console.ReadLine();
                box.Items.Add(stringValue);
            }
            string comparingString = Console.ReadLine();
            int value = box.CountGreaterThan(comparingString);
            Console.WriteLine(value);
        }
    }
}