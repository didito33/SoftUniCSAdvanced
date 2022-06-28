using System;

namespace NestedFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNTimes(PrintHello, 5);
        }
        public static void PrintHello()
        {
            Console.WriteLine("Hello");
        }
        static void PrintNTimes(Action function, int times)
        {
            if (times == 0)
            {
                return;
            }
            PrintNTimes(function, times - 1);//recursion
            function();
        }
    }
}
