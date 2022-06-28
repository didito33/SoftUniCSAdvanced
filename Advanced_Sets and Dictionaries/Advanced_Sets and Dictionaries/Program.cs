using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Advanced_Sets_and_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> studentNumbers = new SortedDictionary<int, string>(new NumberComparer());
            studentNumbers.Add(16, "Peshkata");
            studentNumbers.Add(17, "Vankata");
            studentNumbers.Add(15, "Pesho");
            studentNumbers.Add(12, "Deivid");
            foreach (var item in studentNumbers)
            {
                Console.WriteLine($"{item.Key} -> {item.Key} ");
            }
        }
    }
    class NumberComparer : IComparer<int>
    {
        public int Compare([AllowNull] int x, [AllowNull] int y)
        {
            //return y - x;//sortirat se na obratno
            return y % 2 == 0 ? 1 : -1;//sortira chetnite purvo
        }
    }
   /* class StringsComparer : IComparer<string>
    {
        public int Compare([AllowNull] int x, [AllowNull] int y)
        {
            return x.CompareTo(y);
        }
    }*/
}
