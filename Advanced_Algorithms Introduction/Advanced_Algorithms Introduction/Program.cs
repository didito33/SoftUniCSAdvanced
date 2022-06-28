using System;

namespace Advanced_Algorithms_Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            Print(10);//10
        }

        private static void Print(int number)
        {
            if (number == 0)
            {
                return;
            }
            Console.WriteLine($"Before Recursion {number}");//10, 9, 8 ,7 ...
            Print(number - 1);//изпълнява се до тука
            Console.WriteLine($"After Recursion {number}");// след processva всичко от последното към първото
            //                                               1, 2 ,3 ,4 ,5 ,6 
        }
    }
}
