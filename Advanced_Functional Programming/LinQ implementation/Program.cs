using System;
using System.Collections.Generic;

namespace LinQ_implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
            numbers = Where(numbers, x => x > 3);
            Console.WriteLine(string.Join(" ", numbers));
        }
        static bool IsBiggerThan3(int number)
        {
            return number > 3;
        }
        public static List<int> Where(List<int> list, Func<int,bool> checker)
        {
            List<int> result = new List<int>();
            foreach (var item in list)
            {
                if(checker(item))
                {
                    result.Add(item);

                }
            }
            return result;
        }
    }
}
