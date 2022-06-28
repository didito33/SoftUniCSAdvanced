using System;
using System.Collections.Generic;

namespace Advanced_Stacks_and_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(); // LIFO - last in, first out
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);

            Console.WriteLine(stack.Pop());
            Console.WriteLine($"Stack count: {stack.Count}");
            Console.WriteLine(stack.Pop());
            Console.WriteLine($"Stack count: {stack.Count}");
            Console.WriteLine(stack.Pop());
            Console.WriteLine($"Stack count: {stack.Count}");

            Console.WriteLine(stack.Peek());
            
        }
    }
}
