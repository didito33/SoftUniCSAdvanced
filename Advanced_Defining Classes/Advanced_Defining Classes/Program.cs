using System;

namespace Advanced_Defining_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime timeNow = new DateTime(1997, 5, 23);
            Car bmw = new Car()
            {
                Name = "x3",
                Company = "BMW",
                Category = "Cars",
                Price = 3000
                
            };
            bmw.Drive(23);
            bmw.Drive(36);
            Car audi = new Car()
            {
                Name = "a3",
                Company = "BMW",
                Category = "Cars",
                Price = 3000

            };
            audi.Drive(50);
            audi.Drive(60);
            Console.WriteLine($"Car: {bmw.Name}, {bmw.Price}, {bmw.Company}, Mileage - {bmw.Mileage}");
            Console.WriteLine($"{audi.Name}, Mileage - {audi.Price}, {audi.Company}, Mileage - {audi.Mileage}");
        }
    }
}
