using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lekciq_02.Stack_Sum
{
    class Program
    {/*1 2 3 4
adD 5 6
REmove 3
eNd*/
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(numbers);
            /*foreach (var item in numbers)
            {
                stack.Push(item);
            }*/
        string command = Console.ReadLine().ToLower();
            while(command != "end")
            {
                string[] splittedCommand = command.Split();
                if (splittedCommand[0] == "add")
                {
                    int first = int.Parse(splittedCommand[1]);
                    int second = int.Parse(splittedCommand[2]);
                    stack.Push(first);
                    stack.Push(second);

                }
                else if(splittedCommand[0] == "remove")
                {
                    int count = int.Parse(splittedCommand[1]);
                    if(count <= stack.Count)//ako ne e po-golqm ili raven na counta
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();//mahame elementite
                        }
                    }
                }

                 command = Console.ReadLine().ToLower();
            }
            //int sum = stack.Sum();
            int sum = 0;
            while (stack.Count > 0)
            {
                sum += stack.Pop();
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
