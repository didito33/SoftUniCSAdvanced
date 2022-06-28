using System;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Car car = new Car();
            car.Model = "A5";
            Console.WriteLine(car.Model);
        }
    }
}
