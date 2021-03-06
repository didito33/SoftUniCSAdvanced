using System;
using System.Collections.Generic;
using System.Linq;

namespace Advanced_ExamPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWaves = int.Parse(Console.ReadLine());
            Stack<int> plates = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));//30 20 10
            plates.Reverse();// 10 20 30
            Stack<int> orcs = new Stack<int>();
            for (int i = 1; i <= numberOfWaves; i++)//защото ще търсим всеки 3ти wave
            {
                var currentWave = Console.ReadLine().Split().Select(int.Parse);
                foreach (var orc in currentWave)
                {
                    orcs.Push(orc);
                    
                }
                if(i % 3 == 0)
                {
                    int plate = int.Parse(Console.ReadLine());
                    var platesAsList = plates.ToList();
                    platesAsList.Add(plate);
                    platesAsList.Reverse();
                    plates = new Stack<int>(platesAsList);
                    /*plates.Push(plate);
                    plates.Reverse();*/
                }
                //fighting
                while(plates.Count>0 && orcs.Count > 0)
                {
                    int currentPlate = plates.Pop();
                    int currentOrc = orcs.Pop();

                    if(currentPlate > currentOrc)
                    {
                        currentPlate -= currentOrc;
                        plates.Push(currentPlate);
                    }
                    else if(currentPlate < currentOrc)
                    {
                        currentOrc -= currentPlate;
                        orcs.Push(currentOrc);
                    }

                }
                if (plates.Count <= 0)
                    break;
            }
            if(plates.Count > 0)
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
                Console.WriteLine($"Plates left: {string.Join(", ", plates)}");
            }
            else
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                Console.WriteLine($"Orcs left: {string.Join(", ", orcs)}");
            }
        }
    }
}
