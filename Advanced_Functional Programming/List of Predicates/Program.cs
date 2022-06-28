using System;
using System.Collections.Generic;
using System.Linq;

namespace List_of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {/*100
2 5 10 20*/
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = Enumerable.Range(1, n).ToList();
            /*List<int> numbers = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                numbers.Add(i);
            }*/
            List<Predicate<int>> predicates = new List<Predicate<int>>();
            int[] divNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach (var divnumber in divNumbers)//2 5 10 20
            {
                predicates.Add(x => x % divnumber == 0);
                //x => x%2 == 0
                //x => x%5 == 0
                //x => x%10 == 0
                //x => x%20 == 0
            }
            foreach (var number in numbers)
            {
                bool isDivisible = true;
                foreach (var predicate in predicates)
                {
                    if (!predicate(number))// ako ne vseki predicate e true za current number-a 
                    {
                        isDivisible = false;
                        break;
                    }
                }
                if (isDivisible)
                    Console.Write(number + " ");
            }
        }
    }
}
