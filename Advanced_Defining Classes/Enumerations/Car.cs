using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations
{
    public class Car
    {
        public Car(string name, int mileage,CarState carstate)
        {
            Name = name;
            Mileage = mileage;
            CarState = carstate;
        }
        public string Name { get; set; }
        public int Mileage { get; set; }
        public CarState CarState { get; set; }

    }
}
