﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());/*"{model} {engineSpeed} {enginePower} {cargoWeight} {cargoType} {tire1Pressure}
{tire1Age} {tire2Pressure} {tire2Age} {tire3Pressure} {tire3Age} {tire4Pressure}
{tire4Age}"*/
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];

                double tire1Pressure = double.Parse(input[5]);
                int tire1Age = int.Parse(input[6]);

                double tire2Pressure = double.Parse(input[7]);
                int tire2Age = int.Parse(input[8]);

                double tire3Pressure = double.Parse(input[9]);
                int tire3Age = int.Parse(input[10]);

                double tire4Pressure = double.Parse(input[11]);
                int tire4Age = int.Parse(input[12]);

                Engine engine = new Engine(enginePower,engineSpeed);
                Cargo cargo = new Cargo(cargoType, cargoWeight);
                Tire[] tires = new Tire[]
                {
                    new Tire(tire1Age, tire1Pressure),
                    new Tire(tire2Age, tire2Pressure),
                    new Tire(tire3Age, tire3Pressure),
                    new Tire(tire4Age, tire4Pressure),

                };
                
                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }
            string command = Console.ReadLine();
            if(command == "fragile")
            {
                //print all cars whose cargo is "fragile" and have a pressure of a single tire <1
                List<Car> fragileCars = cars.Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(p => p.Pressure < 1)).ToList();
                foreach (var item in fragileCars)
                {
                    Console.WriteLine(item.Model);
                }
                /* foreach (var car in cars) Sushtoto kato gorniq red s LISTA
                 {
                     if (car.Cargo.Type == "fragile")
                     {
                         //if(car.Tires.Any(x=>x.Pressure < 1))
                         foreach (var tire in car.Tires)
                         {
                             if (tire.Pressure < 1)
                             {
                                 Console.WriteLine(car.Model);
                                 break;
                             }
                         }
                     }
                 }*/

            }
            else
            {
                List<Car> flammableCars = cars.Where(x => x.Cargo.Type == "flammable" && x.Engine.Power > 250).ToList();
                foreach (var car in flammableCars)
                {
                    Console.WriteLine(car.Model);
                }

            }
        }
    }
}
