using System;
using System.Collections.Generic;

namespace Action
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 1, 2, 3, 4, 5 };
            Iterate(list, x => Console.WriteLine(x));

            //void function
            Action<string> printName = (name) => Console.WriteLine(name);
            printName("Gosho");//action
            PrintName("Gosho");//method

            //bool function
            Predicate<int> isEven = x => x % 2 == 0;
            var resultOfIsEven = isEven(6);//predicate
            var resultOfIsEvenMethod = IsEven(6);//method

            Func<int, int, int> sumNumbers = (x, y) => x + y;
            Console.WriteLine(sumNumbers(5,6));//func
            Console.WriteLine(SumNumbers(5,6);//method
        }
        public static int SumNumbers(int x, int y)
        {
            return x + y;
        }
        public static bool IsEven(int x)
        {
            return x % 2 == 0;
        }
        public static void PrintName(string x)
        {
            Console.WriteLine(x);
        }
        public static void Iterate(List<int> list, Action<int> callback)
        {
            foreach (var item in list)
            {
                callback(item);
            }
        }
    }
}
