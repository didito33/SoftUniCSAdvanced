using System;
using System.Collections.Generic;

namespace Lekciq_07.Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            Queue<string> queue = new Queue<string>(names);
            int tossCountToRemove = int.Parse(Console.ReadLine());
            int currentTosses = 1;
            while(queue.Count > 1)
            {
                var kidWithPotato = queue.Dequeue();
                if(currentTosses != tossCountToRemove)
                {
                    currentTosses++;
                    queue.Enqueue(kidWithPotato);//taka zavurtame i vrushtame horata v igrata
                }
                else
                {
                    currentTosses = 1;//zanulqvame i pochvame otnachalo
                    Console.WriteLine($"Removed {kidWithPotato}");
                }
               
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
        // Alva James William
        //  2
    }
}
