using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0.Constructors
{
    public class Animal
    {
        public Animal(string species, string name, string gender, bool isHungry):this(name,isHungry,gender)//ot dolnite constr setvame
        {
            Console.WriteLine($"I am in the biggest constructor");
            Species = species;
            
        }
        public Animal(string name, bool isHungry, string gender):this(name)//ot dolniq constr setvame Name
        {
            IsHungry = isHungry;
            Gender = gender;
        }
        public Animal(string name)
        {
            Name = Name;
        }
        public string  Species { get; set; }
        public string  Name { get; set; }
        public string  Gender { get; set; }
        public bool IsHungry { get; set; }
        


    }
}
