using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Defining_Classes
{
    class Car
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Company { get; set; }
        public decimal Price { get; set; }
        public int Mileage { get; set; }
        public void Drive(int km)
        {   
            this.Mileage += km;
            Console.WriteLine($"Car - {Name} {Company} driven for {Mileage} km.");
            
        }
    }
}
