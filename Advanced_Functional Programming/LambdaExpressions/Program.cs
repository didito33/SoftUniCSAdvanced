using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //                                      select(x=>int.parse(x))
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
            //numbers = numbers.Where(x => x > 3).ToList();
            //numbers = numbers.Where(isBiggerThan3).ToList();
            /*numbers = numbers.Where((int x, int index)=>
            {
            Console.WriteLine($"Checking {x} > 3 , index: {index}");
            return x>3'
            }).ToList();*/
            
            //numbers = numbers.Select(x => x * 5).ToList();
            numbers = numbers.Select(x =>
            {
                Console.WriteLine($"Multiplying {x} by 5");
                return x * 5; 
            }).ToList();
            numbers = numbers.Select(Multiply).ToList();//its the same as the one above
            Console.WriteLine(String.Join(" ",numbers));
        }

        public static int Multiply(int x)
        {
            Console.WriteLine($"Multiplying {x} by 5");
            return x * 5;
        }
        public static bool isBiggerThan3(int x)
        {
            Console.WriteLine($"Checking {x} >3");
            return x > 3;
        }
    }
}
