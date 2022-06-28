using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Product_Shop_DictofDict
{
    class Program
    {/*lidl, juice, 2.30
fantastico, apple, 1.20
kaufland, banana, 1.10
fantastico, grape, 2.20
Revision*/
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> dictShop = new Dictionary<string, Dictionary<string, double>>();
            string input = Console.ReadLine();
            while (input != "Revision")
            {
                string[] cmdSplitted = input.Split(", ");
                string shop = cmdSplitted[0];
                string product = cmdSplitted[1];
                double price = double.Parse(cmdSplitted[2]);
                if (!dictShop.ContainsKey(cmdSplitted[0]))
                {
                    dictShop[shop] = new Dictionary<string, double>();//create-vam dictionaryto
                }
                    dictShop[shop].Add(product, price);//vuv vseki drug sluchai prosto zapisvam
                input = Console.ReadLine();
            }
            dictShop = dictShop.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var shops in dictShop)
            {
                Console.Write($"{shops.Key}->\n");
                foreach (var products in shops.Value)
                {
                    Console.WriteLine($"Product: {products.Key}, Price: {products.Value}");
                }
            }
        }
    }
}
