using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
           // HashSet<int> hashN = new HashSet<int>();
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            int n = int.Parse(Console.ReadLine());
            FillDictionary(numbers, n);
            foreach (var kvp in numbers.Where(kvp=>kvp.Value%2==0))
            {
                Console.WriteLine(kvp.Key);
            }
            /*foreach (var item in numbers)
            {
                if(item.Value % 2==0)
                    Console.WriteLine(item.Key);
            }*/
            
        }

        private static Dictionary<int,int> FillDictionary(Dictionary<int, int> numbers, int lines)
        {
            for (int i = 0; i < lines; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(currentNum))
                {
                    numbers.Add(currentNum, 0);//addvam go prosto s value = 0
                }
                
                numbers[currentNum]++;//uvelichavam value s +1
            }
            return numbers;
        }
    }
}
