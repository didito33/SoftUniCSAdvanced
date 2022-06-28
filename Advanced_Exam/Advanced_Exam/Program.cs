using System;
using System.Collections.Generic;
using System.Linq;

namespace Advanced_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] waterInput = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToArray();
            decimal[] flourInput = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToArray();
            Queue<decimal> water = new Queue<decimal>(waterInput);
            Stack<decimal> flour = new Stack<decimal>(flourInput);
            Dictionary<string, int> bakedProducts = new Dictionary<string, int>();
            int muffinCount = 0;
            int croissantCount = 0;
            int baguetteCount = 0;
            int bagelCount = 0;
            while (flour.Count > 0 && water.Count > 0)
            {
                decimal product = 0;
                decimal flourPeek = flour.Pop();
                decimal waterPeek = water.Dequeue();
                product = flourPeek + waterPeek;
                if ((waterPeek * 100) / product == 40)
                {
                    muffinCount++;
                    if (!bakedProducts.ContainsKey("Muffin"))
                    {
                        bakedProducts["Muffin"] = 0;
                    }
                    bakedProducts["Muffin"]++;
                }
                else if ((waterPeek * 100) / product == 30)
                {
                    baguetteCount++;
                    if (!bakedProducts.ContainsKey("Baguette"))
                    {
                        bakedProducts["Baguette"] = 0;
                    }
                    bakedProducts["Baguette"]++;
                }
                else if ((waterPeek * 100) / product == 20)
                {
                    bagelCount++;
                    if (!bakedProducts.ContainsKey("Bagel"))
                    {
                        bakedProducts["Bagel"] = 0;
                    }
                    bakedProducts["Bagel"]++;
                }
                else
                {
                    if (flourPeek > waterPeek)
                    {

                        flourPeek -= waterPeek;
                        flour.Push(flourPeek);
                        croissantCount++;
                        if (!bakedProducts.ContainsKey("Croissant"))
                        {
                            bakedProducts["Croissant"] = 0;
                        }
                        bakedProducts["Croissant"]++;
                        continue;

                    }
                    else if (flourPeek == waterPeek)
                    {
                        croissantCount++;
                        if (!bakedProducts.ContainsKey("Croissant"))
                        {
                            bakedProducts["Croissant"] = 0;
                        }
                        bakedProducts["Croissant"]++;
                    }
                    else
                    {
                        
                            flourPeek += flour.Pop();
                            flourPeek -= waterPeek;
                            flour.Push(flourPeek);
                            croissantCount++;
                            if (!bakedProducts.ContainsKey("Croissant"))
                            {
                                bakedProducts["Croissant"] = 0;
                            }
                            bakedProducts["Croissant"]++;
                        
                        
                    }
                    
                }
            }
                bakedProducts = bakedProducts.OrderByDescending(x => x.Value).ThenBy(x => x.Key)
                    .ToDictionary(x => x.Key, x => x.Value);
                foreach (var item in bakedProducts)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
               
                if(water.Count>0)
                {
                        Console.Write($"Water left: {string.Join(", ",water)}");
                }  
                else
                    Console.Write("Water left: None");
                Console.WriteLine();
                if (flour.Count > 0)
                {
                    Console.Write($"Flour left: {string.Join(", ", flour)}");
                }
                else
                    Console.Write("Flour left: None");

            

        }
    }
}
