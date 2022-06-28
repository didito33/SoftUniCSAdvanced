using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace FishingNet
{
    public class Net
    {
        
        public List<Fish> Fish { get; set; }
        public Net(string material, int capacity)
        {
            Material = material;
            Capacity = capacity;
            Fish = new List<Fish>();
        }

        public string Material { get; set; }
        public int Capacity { get; set; }
        public int Count => Fish.Count();
        public string AddFish(Fish fish)
        {
            if (fish.FishType == null || fish.FishType == " " || fish.Length <= 0 || fish.Weight <= 0)
            {
                return $"Invalid fish.";
            }
            else if (Fish.Count >= Capacity)
            {
                return $"Fishing net is full.";
            }
            Fish.Add(fish);
            return $"Successfully added {fish.FishType} to the fishing net.";
        }
        public bool ReleaseFish(double weight)
        {
            Fish newFish = Fish.FirstOrDefault(x => x.Weight == weight);
            return Fish.Remove(newFish);// Remove returns Bool (true if it has succeeded)
        }
        public Fish GetFish(string fishType)
        {
            Fish newFish = Fish.FirstOrDefault(x => x.FishType == fishType);
            return newFish;
        }
        public Fish GetBiggestFish()
        {
            Fish fish = Fish.OrderByDescending(x => x.Length).First();
            return fish;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Into the {Material}:");

            foreach (var item in Fish.OrderByDescending(x=>x.Length))
            {
                sb.AppendLine($"{item}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
