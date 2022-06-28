using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Warm_Winter
{
    class Program
    {
        static void Main(string[] args)
        {
            //hats and scarfs
            //if (hats > scarfs) -> // new set -> hats + scarfs
            //remove hats and scarf elements
            // else if(hats<scarfs) - > remove hat
            //else remove scarf, element of hats + 1
            int[] inputHats = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] inputScarfs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> elements = new List<int>();
            Stack<int> hats = new Stack<int>(inputHats);
            Queue<int> scarfs = new Queue<int>(inputScarfs);

            while(hats.Count>0 && scarfs.Count > 0)
            {
                int hat = hats.Peek();
                int scarf = scarfs.Peek();

                if(hat > scarf)
                {
                    elements.Add(hat + scarf);
                    hats.Pop();
                    scarfs.Dequeue();
                }
                else if (scarf > hat)
                {
                    hats.Pop();
                }
                else if (scarf == hat)
                {
                    scarfs.Dequeue();
                    int value = hats.Pop() + 1;//взимаме елемента, увелияаваме го 
                    hats.Push(value);// и го връщаме
                }
            }
            Console.WriteLine($"The most expensive set is: {elements.Max()}");
            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
