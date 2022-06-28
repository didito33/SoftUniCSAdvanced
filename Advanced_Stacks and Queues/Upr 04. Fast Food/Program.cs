using System;
using System.Collections.Generic;
using System.Linq;

namespace Upr_04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalQuantity = int.Parse(Console.ReadLine());
            int[] inputOrders = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(inputOrders.Max());

            Queue<int> queueOfOrders = new Queue<int>(inputOrders);
            while(queueOfOrders.Count > 0 && totalQuantity >= 0)
            {
                int currentOrder = queueOfOrders.Peek();//samo peekvame, ne go mahame

                if(totalQuantity - currentOrder < 0)
                    break;
                totalQuantity -= currentOrder;
                queueOfOrders.Dequeue();//veche go mahame
            }
            if(queueOfOrders.Count > 0)//ako ima oshte neizpulneni poruchki gi printiram
            {
                Console.Write($"Orders left: {string.Join(" ", queueOfOrders)}");
                /*foreach(var item in queueOfOrders)
                {
                    Console.Write($"{item}");
                }*/
            }
            else
                Console.WriteLine("Orders complete");
        }
    }
}
