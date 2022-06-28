using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Product_shop
{
    class Shop
    {
        //private string product;
        //private string price;
        public string Product { get; set; }
        public double Price { get; set; }
        public Shop(string product, double price)
        {
            Product = product;
            Price = price;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Shop>> dictShop = new Dictionary<string, List<Shop>>();
            string input = Console.ReadLine();
            while(input != "Revision")
            {
                string[] cmdSplitted = input.Split(", ");
                string shop = cmdSplitted[0];
                string product = cmdSplitted[1];
                double price = double.Parse(cmdSplitted[2]);
                if (!dictShop.ContainsKey(cmdSplitted[0]))
                {
                    dictShop[shop] = new List<Shop>();
                    dictShop[shop].Add(new Shop(product, price));

                }
                else//veche sme create-nali List-a
                    dictShop[shop].Add(new Shop(product, price));
                input = Console.ReadLine();
            }
            dictShop = dictShop.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            foreach (var shops in dictShop)
            {
                Console.Write($"{shops.Key}->");
                foreach(var products in shops.Value)
                {
                    Console.WriteLine($"Product: {products.Product}, Price: {products.Price:f1}");
                }
            }
        }
    }
}
