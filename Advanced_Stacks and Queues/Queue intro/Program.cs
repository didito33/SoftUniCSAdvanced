using System;
using System.Collections.Generic;

namespace Queue_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();// FiFo
            Stack<int> stack = new Stack<int>(new int[] { 1, 2, 3, 4 });//Lifo
            var stackArray = stack.ToArray();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            var array = queue.ToArray();
            /*Console.WriteLine(queue.Dequeue());       
            Console.WriteLine(queue.Dequeue());       
            Console.WriteLine(queue.Dequeue());       
            Console.WriteLine(queue.Dequeue());*/
            return;
        }
    }
}
