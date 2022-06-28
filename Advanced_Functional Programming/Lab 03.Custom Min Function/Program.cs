using System;
using System.Linq;

namespace Lab_03.Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {//-5 -3 5 6 7
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int[], int> smallestNumber = numbers //=> numbers.Min();
                =>
            {
                int minValue = int.MaxValue;
                foreach (var number in numbers)
                {
                    if (number < minValue)
                        minValue = number;
                }
                return minValue;
            };
            int result = smallestNumber(numbers);
            Console.WriteLine(result);
        }
    }
}
