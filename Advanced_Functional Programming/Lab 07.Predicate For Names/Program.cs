using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_07.Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {//4
         //kris ivan petkan
            int nameLength = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();
            Func<string, int, bool> isLengthLess = (name, length) => 
            name.Length <= length;

            List<string> list = names.Where(element=>isLengthLess(element,nameLength)).ToList();
            Console.WriteLine(string.Join(Environment.NewLine,list));
        }
    }
}
