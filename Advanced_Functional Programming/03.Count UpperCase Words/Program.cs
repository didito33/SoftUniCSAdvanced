using System;
using System.Linq;

namespace _03.Count_UpperCase_Words
{
    class Program
    {
        static void Main(string[] args)
        {// Purva duma Vtora Duma treta Duma
            //                                          proverqva po interval
            string[] words = Console.ReadLine().Split(new char[] {' '} ,StringSplitOptions.RemoveEmptyEntries);
            Func<string, bool> isStartWithCapital = w => char.IsUpper(w[0]);
            Console.WriteLine(string.Join("\n", words.Where(isStartWithCapital)));
            //Console.WriteLine(string.Join("\n", words.Where(w=>char.IsUpper(w[0]))));
        }
    }
}
