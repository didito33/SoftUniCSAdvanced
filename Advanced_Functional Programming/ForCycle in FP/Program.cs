using System;

namespace ForCycle_in_FP
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNTimes("hello", 5);
        }
        static void PrintNTimes(string message, int times)
        {
            if (times == 0) 
            {
                return;
            }
            PrintNTimes(message, times - 1);//recursion
            //Izpulnqva se 5 puti do red 17 i sled kato times stava 0 -> sled tova ot red 17 times se vrushta nazad i stava 1..2..3
            //i taka 5 puti se printira console.writeline-a
            Console.WriteLine(message);
        }
    }
}
