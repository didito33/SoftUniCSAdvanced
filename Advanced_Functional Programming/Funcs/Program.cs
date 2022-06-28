using System;

namespace Funcs
{
    class Program
    {
        static decimal StrangeFunction(int x, string y, bool z)
        {
            return 1;
        }
       
        static void Main(string[] args)
        {
            Func<int, string, bool, decimal> strangeFunc = StrangeFunction;
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            string sign = Console.ReadLine();
            Func<int, int, int> calcMethod = GetCalcMethod(sign);
            Console.WriteLine(calcMethod(x,y));
        }

        

        static int Multiply(int x, int y)
        {
            return x * y;
        }
        static int Substract(int x, int y)
        {
            return x - y;
        }
        static int Add(int x, int y)
        {
            return x + y;
        }
        static Func<int,int,int> GetCalcMethod(string input)
        {
            switch (input)
            {
                case "*": return Multiply;
                case "+": return Add;
                case "-": return Substract;
                default:
                break; }
            return null;
        }

    }
}
