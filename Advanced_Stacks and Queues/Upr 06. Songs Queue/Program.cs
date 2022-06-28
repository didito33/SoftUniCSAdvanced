using System;
using System.Collections.Generic;

namespace Upr_06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] musicInput = Console.ReadLine().Split(", ");
            Queue<string> queue = new Queue<string>(musicInput);

            string command = Console.ReadLine();
            while (queue.Count > 0) 
            {
                string[] cmdSplitted = command.Split();
                if(cmdSplitted[0] == "Play")
                {
                    if (queue.Count > 0)
                        queue.Dequeue();
                   
                }
                else if(cmdSplitted[0] == "Add")//Add Watch Me
                {                               //0123 zapochva ot 4 ->
                    if (!queue.Contains(command.Substring(4, command.Length-4)))//ako go nqma substringa
                        queue.Enqueue(command.Substring(4, command.Length-4));
                    else
                        Console.WriteLine($"{command.Substring(4, command.Length-4)} is already contained!");
                    
                }
                else if (cmdSplitted[0] == "Show")
                {
                    Console.WriteLine(string.Join(", ", queue));
                }

                command = Console.ReadLine();
            }
            Console.WriteLine("No more songs!");
        }
        /*All Over Again, Watch Me
Play
Add Watch Me
Add Love Me Harder
Add Promises
Show
Play
Play
Play
Play*/
    }
}
