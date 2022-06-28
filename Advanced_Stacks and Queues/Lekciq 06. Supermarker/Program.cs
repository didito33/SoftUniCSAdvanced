using System;
using System.Collections.Generic;

namespace Lekciq_06._Supermarker
{
    class Program
    {
        static void Main(string[] args)
        {/*Liam
Noah
James
Paid
Oliver
Lucas
Logan
Tiana
End*/
            Queue<string> queue = new Queue<string>();
            string names = Console.ReadLine();
            while(names != "End")
            {
                if (names == "Paid")
                {
                    while(queue.Count > 0)
                    {
                        
                        Console.WriteLine(queue.Dequeue());
                        
                    }
                }
                else
                queue.Enqueue(names);

                names = Console.ReadLine();
                
            }
            
            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
