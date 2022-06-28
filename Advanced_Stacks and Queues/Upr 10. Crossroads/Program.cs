using System;
using System.Collections.Generic;

namespace Upr_10._Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            int passedCars = 0;
            string input = Console.ReadLine();
            
            while (input != "END")
            {
                if (input != "green") // ako ne e zeleno, addvame
                {
                    cars.Enqueue(input);
                    input = Console.ReadLine();
                    continue;
                }
                int currentGreenLight = greenLight;
                while(currentGreenLight > 0 && cars.Count > 0)
                {
                    string currentCar = cars.Dequeue();
                    if(currentGreenLight - currentCar.Length >= 0)
                    {
                        currentGreenLight -= currentCar.Length;//minava uspeshno
                        passedCars++;
                        continue;
                    }
                    if(currentGreenLight + freeWindow - currentCar.Length >= 0)
                    {
                        currentGreenLight = 0;
                        passedCars++;
                        continue;//tuka shte breakne zashtoto currGreenlight e 0
                    }//
                    int hitChar = currentGreenLight + freeWindow;
                    Console.WriteLine("A crash happened!");
                    Console.WriteLine($"{currentCar} was hit at {currentCar[hitChar]}.");
                    Environment.Exit(0);//Terminirame processa
                }
                //car passes - no time left
                //car passes - time left
                //car passes - time left + free window
                //fucc

                input = Console.ReadLine();
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{passedCars} total cars passed the crossroads.");
        }
    }
}
