using System;

namespace RecursionFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int factorial = GetFactirial(n);//5 * 4 * 3 * 2 * 1
            Console.WriteLine(factorial);

        }

        private static int GetFactirial(int n)
        {
            if(n == 0)
            {
                return 1;//ако е 0, всичко умножено по 0 е 0
            }
            Console.WriteLine($"Before recursion {n}");
            int result =  n * GetFactirial(n - 1);
            Console.WriteLine($"After recursion {result}");
            return result;
        }
    }
}
