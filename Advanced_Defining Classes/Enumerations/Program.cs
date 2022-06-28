using System;

namespace Enumerations
{
    class Program
    {
        static void Main(string[] args)
        {
            CarState newCarState = (CarState)0;
            CarState weirdCarState = (CarState)3;
            Console.WriteLine(newCarState);
            Car car = new Car("BMW", 10000, newCarState);
            Console.WriteLine(car.Name + " " + car.Mileage + " " + car.CarState);
            Console.WriteLine($"Sold - {(DayOfWeek)0}");
            Console.WriteLine($"Testing - {(DayOfWeek)67}");
        }
    }
    enum DayOfWeek
    {
        Monday,
        Tuesday,
        Wednesday=67,
        Thursday,
        Friday,
        Saturday,
        Sunday

    }
}
