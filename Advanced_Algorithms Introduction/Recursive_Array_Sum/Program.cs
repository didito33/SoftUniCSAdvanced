using System;
using System.Linq;

namespace Recursive_Array_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine().Split().Select(int.Parse).ToArray();//new int[] { 2, 4, 6 };//sum is 12
            int sum = SumArray(integers,0);
            Console.WriteLine(sum);
        }

        private static int SumArray(int[] integers, int index)
        {
            if(index == integers.Length)
            {
                return 0;
            }

             return integers[index]+ SumArray(integers, index+1);
        }
    }
}
