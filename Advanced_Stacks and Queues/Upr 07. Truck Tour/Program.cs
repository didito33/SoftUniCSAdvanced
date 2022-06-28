using System;
using System.Collections.Generic;
using System.Linq;

namespace Upr_07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3
1 5
10 3
3 4*/
            int n = int.Parse(Console.ReadLine());

            Queue<int[]> queue = new Queue<int[]>();
            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                queue.Enqueue(input);
            }
            int startIndex = 0;
            

            while(true)
                {
                int totalLiters = 0;
                bool isComplete = true;
                foreach (int[] item in queue)
                {
                    int liters = item[0];
                    int distance = item[1];
                    totalLiters += liters;
                    if (totalLiters - distance < 0)//ako ne mojem da go izminem
                    {
                        startIndex++;
                        int[] currentPump = queue.Dequeue();
                        queue.Enqueue(currentPump);//vrushtam go v opashkata
                        isComplete = false;
                        break;
                    }
                    totalLiters -= distance;
                }
                    if (isComplete)
                    {
                Console.WriteLine(startIndex);
                    break;

                    }
                }
            
        }
    }
}
