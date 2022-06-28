using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace VetClinic
{
    public class Clinic
    {
        private List<Pet> pets;
        public Clinic(int capacity)
        {
            this.pets = new List<Pet>();
            Capacity = capacity;
            
        }
        public int Capacity { get; set; }
        public int Count => pets.Count();
        public void Add(Pet pet)
        {
            if(pets.Count < Capacity)
            {
                pets.Add(pet);
            }
        }
        public bool Remove (string name)// Removing the pet from the list - by a name
        {
            Pet pet = pets.FirstOrDefault(x => x.Name == name);
            return pets.Remove(pet);// Remove returns Bool (true if it has succeeded)
            
        }
        public Pet GetPet(string name, string owner)
        {
            Pet pet = pets.FirstOrDefault(x => x.Name == name && x.Owner == owner);
            return pet;
        }
        public Pet GetOldest()
        {
            Pet pet = pets.OrderByDescending(x => x.Age).First();//10 -> 9 -> 8 -> 7  - and we get the first one
            return pet;
        }
        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("The clinic has the following patients:");
            foreach (var pet in pets)
            {
                sb.AppendLine($"Pet {pet.Name} with owner {pet.Owner}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
