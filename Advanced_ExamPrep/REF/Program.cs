using System;

namespace REF
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 10;
            int refValue = 10;
            RefMethod(ref refValue);
            Method(value);
            Console.WriteLine(value);
            Console.WriteLine(refValue);
            Console.WriteLine(IntMethod(value));
            
            

        }
        private static void Method(int value)
        {
            value += 10;
        }
        private static int IntMethod(int value)
        {
            return value + 10;
        }

        private static void RefMethod(ref int value)
        {
            value += 10;
        }
    }
}
