using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_04.Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {/*1 10
          * odd      or     even   */

            int[] range = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> numbers = new List<int>();
            string oddOrEven = Console.ReadLine();
            for (int i = range[0]; i <= range[1]; i++)
            {
                numbers.Add(i);
            }
            Predicate<int> isEven = x => x % 2 == 0;

            Predicate<int> isOdd = x => x % 2 != 0;
            /*List<int> result = new List<int>();
            if (oddOrEven == "even")
            {
                 result = numbers.FindAll(isEven);
                
            }
            else
            {
                result = numbers.FindAll(isOdd);
            }*/
            List<int> result = oddOrEven=="even" ?      // По-добрият запис
                numbers.FindAll(isEven) :
                numbers.FindAll(isOdd);
            
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
