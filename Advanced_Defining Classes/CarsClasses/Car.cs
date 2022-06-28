using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsClasses
{
    class Car
    {
        private int mileage;
        public int Mileage
        {
            get { return mileage; }
            set 
            {
                Console.WriteLine($"Setting value with {value}");
                if(value < 0)
                {
                    Console.WriteLine("Wrong value!!!");
                }
                else
                mileage = value; //5
            }
        }

    }
}
