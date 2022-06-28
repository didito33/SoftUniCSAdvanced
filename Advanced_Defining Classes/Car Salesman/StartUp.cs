using System;
using System.Collections.Generic;
using System.Linq;

namespace Car_Salesman
{
    class StartUp
    {
        static void Main(string[] args)
        {/*2
V8-101 220 50
V4-33 140 28 B
3
FordFocus V4-33 1300 Silver
FordMustang V8-101
VolkswagenGolf V4-33 Orange*/
            List<Engine> engines = new List<Engine>();
            int enginesCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < enginesCount; i++)
            {//"{model} {power} {int:displacement} {string:efficiency?}"
                string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                int power = int.Parse(input[1]);
                Engine engine = new Engine
                {
                    Model = model,
                    Power = power
                };
                if(input.Length== 4)
                {
                    int displacement = int.Parse(input[2]);
                    string efficiency = input[3];
                    engine.Displacement = displacement;
                    engine.Efficiency = efficiency;
                }
                else if(input.Length == 3)
                {
                    bool isDisplacement = int.TryParse(input[2], out var disp);//ako moje da se parse-ne
                    if (isDisplacement)
                    {
                        engine.Displacement = disp;
                    }
                    else
                    {
                        engine.Efficiency = input[2];
                    }
                }
                engines.Add(engine);
            }
            List<Car> cars = new List<Car>();
            int carsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < carsCount; i++)
            {// {model} {engine} {int:weight?} {string:color?}
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                string engine = input[1];
                Engine lookupEngine = engines.FirstOrDefault(x => x.Model == engine);//ako engineModela  e raven na engine-a
                Car car = new Car
                {
                    Model = model,
                    Engine = lookupEngine
                };
                if(input.Length == 4)
                {
                    int weight = int.Parse(input[2]);
                    string color = input[3];
                    car.Weight = weight;
                    car.Color = color;
                }
                else if(input.Length == 3)
                {// {model} {engine} {int:weight?} {string:color?}
                    bool isWeight = int.TryParse(input[2], out int result);//ako e parsenato uspeshno go zapisvam v result
                    if (isWeight)
                    {
                        car.Weight = result;
                    }
                    else
                    {
                        car.Color = input[2];
                    }
                }
                cars.Add(car);
                
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"   Power: {car.Engine.Power}");
                string displacementInfo = car.Engine.Displacement.HasValue ?
                    $"   Displacement: {car.Engine.Displacement}" :
                    $"   Displacement: n/a"; 
                if (car.Engine.Displacement.HasValue)
                {Console.WriteLine($"   Displacement:{car.Engine.Displacement}");
                }
                else
                    Console.WriteLine("   Displacement: n/a");
                if(car.Engine.Efficiency !=null)
                Console.WriteLine($"   Efficiency:{car.Engine.Efficiency}");
                else
                    Console.WriteLine("   Efficiency: n/a");
                if(car.Weight.HasValue)
                Console.WriteLine($"  Weight: {car.Weight}");
                else
                    Console.WriteLine($"  Weight: n/a");
                if(car.Color != null)
                Console.WriteLine($"  Color: {car.Color}");
                else
                    Console.WriteLine($"  Color: n/a");
                
            }
        }
    }
}
