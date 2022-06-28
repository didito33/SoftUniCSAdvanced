using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniParking
{
    public class Parking
    {
       private int capacity;
       private Dictionary<string,Car> cars;
        public Parking(int capacity)
        {
            this.capacity = capacity;
            cars = new Dictionary<string, Car>();
        }
        public int Count
        {
            get
            {
                return cars.Count;//vrushta prosto counta na kolite BEZ SETTER
            }
        }
        public string AddCar(Car car)
        {
            if (cars.ContainsKey(car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            if(cars.Count == capacity)
            {
                return "Parking is full!";
            }
            cars.Add(car.RegistrationNumber, car);
            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
        }
        public string RemoveCar(string registrationNumber)
        {
            if (!cars.ContainsKey(registrationNumber))
            {
                return "Car with that registration number, doesn't exist!";
            }
            cars.Remove(registrationNumber);
            return $"Successfully removed {registrationNumber}";
        }
        public Car GetCar(string registrationNumber)
        {
            foreach (var car in cars)
            {
                if(car.Key == registrationNumber)
                {
                    return car.Value;//returnvam kolata
                }
            }
            return null;
            //return cars.FirstOrDefault(x => x.Key == registrationNumber).Value;
        }
        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (var regNum in registrationNumbers)
            {
                cars.Remove(regNum);//maha vsichki
            }
        }
    }
}
