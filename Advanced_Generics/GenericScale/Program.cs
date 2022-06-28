using System;

namespace GenericScale
{
    class Program
    {
        public static void Main(string[] args)
        {
            EqualityScale<int> equalityScale = new EqualityScale<int>(4, 5);
            Console.WriteLine(equalityScale.AreEqual());
        }
    }
}
