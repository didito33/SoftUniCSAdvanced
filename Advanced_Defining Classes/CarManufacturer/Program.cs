using System;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Tire[] tires = new Tire[]//array ot gumi
            {
                new Tire(1995, 1.6),
                new Tire(1995, 1.6),
                new Tire(1995, 1.9),
                new Tire(1995, 1.9),
            };
            Tire tire = new Tire(2021,2.5);//samo 1 guma
            Engine engine = new Engine(555, 3);

            Car newOPCar = new Car("BMW", "x1", 2017, 1000, 50,engine,tires); // DEBUG + F11 - HERE
            Console.WriteLine(newOPCar.WhoAmI());
                for (int i = 0; i < newOPCar.Tires.Length; i++)
            {
                Console.WriteLine($"{newOPCar.Tires[i].Years} -> {newOPCar.Tires[i].Pressure}");//Tires(masiv)
            }
            Car defaultCar = new Car();
            Console.WriteLine(defaultCar.WhoAmI());

            Car newCar = new Car("BMW", "x1", 2017, 1000,50);
            Console.WriteLine(newCar.WhoAmI());
            /*Car car = new Car();
            car.Model = "A5";
            car.Make = "Audi";
            car.Year = 1995;
            car.FuelQuantity = 100;
            car.FuelConsumption = 2;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Driving 30:");
               car.Drive(30);
            }*/
            
        }
    }
}
