using System;

namespace CarsClasses
{
    class Program
    {
        static void Main(string[] args)
        {Person person = new Person();
            person.FirstName = "Gogi";
            person.LastName = "Gogov";
            Console.WriteLine(person.FullName);
            //person.FullName = .. - WRONG, FullName nqma setter
            return;
            Car car = new Car();
            car.Mileage = 5;//5 = value
            Console.WriteLine($"car mileage {car.Mileage}");
            car.Mileage = -1;
            Console.WriteLine($"car mileage = {car.Mileage}");

            
        }
    }
}
