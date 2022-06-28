using System;
using System.Linq;

namespace _01.SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {//1, 5, 6, 7, 3, 4, 8
            int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            numbers = numbers.Where(x => x % 2 == 0).OrderBy(x=>x).ToArray();//ordervame po samiq element
            Console.WriteLine(string.Join(", ", numbers.Select(x=>1)));//select transforms the element into 1
            Console.WriteLine(String.Join(", ", numbers));
        }
    }
}
