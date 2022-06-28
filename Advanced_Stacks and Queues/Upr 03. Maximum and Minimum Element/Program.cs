using System;
using System.Collections.Generic;
using System.Linq;

namespace Upr_03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (commands[0] == 1)
                    stack.Push(commands[1]);

                if (commands[0] == 2)
                {
                    if (stack.Count > 0)
                        stack.Pop();

                    else continue;
                }

                if(commands[0] == 3)
                    Console.WriteLine($"{stack.Max()}");
                if(commands[0] == 4)
                {
                    Console.WriteLine($"{stack.Min()}");
                }
            }
            while(stack.Count > 1)
            {
                Console.Write($"{stack.Pop()}, ");
            }
            Console.Write(stack.Pop());
        }
    }
}
