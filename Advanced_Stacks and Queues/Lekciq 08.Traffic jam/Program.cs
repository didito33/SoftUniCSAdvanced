using System;
using System.Collections;
using System.Collections.Generic;

namespace Lekciq_08.Traffic_jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();

            string command = Console.ReadLine();
            int passedCount = 0;
            while(command != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (cars.Count == 0)//breakva kato svurshat elementite
                        {
                            break;
                        }
                        //var car = cars.Dequeue();
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        passedCount++;
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{passedCount} cars passed the crossroads.");
        }
        /*3
Enzo&#39;s car
Jade&#39;s car
Mercedes CLS
Audi
green
BMW X5
green
end*/
    }
}
