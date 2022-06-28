using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {// INPUT -> 3 -> 3.5 -> 5.6 -> 6.1 -> 5.9
            /*       int left = 1;
            int right = 1;
            Console.WriteLine(left.CompareTo(right));// 1 and 1 => 0(same value), 1 and 2 => -1 ;   2 and 1 => 1*/
            int n = int.Parse(Console.ReadLine());
            Box<double> box = new Box<double>();
            for (int i = 0; i < n; i++)
            {
                double doubleValue = double.Parse(Console.ReadLine());
                box.Items.Add(doubleValue);
            }
            double comparingValue = double.Parse(Console.ReadLine());
            int value = box.CountGreaterThan(comparingValue);
            Console.WriteLine(value);
        }
    }
}
