using System;
using System.Collections.Generic;

namespace Lab_06._Wardrobe
{
    class Program
    {/*4
Blue -> dress,jeans,hat
Gold -> dress,t-shirt,boxers
White -> briefs,tanktop
Blue -> gloves
Blue dress              */
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            FillWardrobe(wardrobe,lines);
            string[] clothesToFind = Console.ReadLine().Split();//Blue dress
            string wantedColour = clothesToFind[0];//Blue
            string wantedCloth = clothesToFind[1];//dress
            PrintWardobe(wardrobe, wantedColour, wantedCloth);// Prints and finds the cloth we are looking for
        }

        private static void PrintWardobe(Dictionary<string, Dictionary<string, int>> wardrobe, string wantedColour, string wantedCloth)
        {//                 Blue
            foreach (var colorKey in wardrobe)
            {
                Console.WriteLine($"{colorKey.Key} clothes:");//Blue
                foreach (var clothing in colorKey.Value)//v nested dictionary-to
                {//     Blue                                dress           dressType
                    if(wantedColour == colorKey.Key && wantedCloth == clothing.Key)
                    {//                         dressType        int occurances
                        Console.WriteLine($"* {clothing.Key} - {clothing.Value} (found!)");
                        
                    }
                    else
                    Console.WriteLine($"* {clothing.Key} - {clothing.Value}");
                }
            }
        }

        private static Dictionary<string,Dictionary<string,int>> FillWardrobe(Dictionary<string, Dictionary<string, int>> wardrobe, int lines)
        {
            for (int i = 0; i < lines; i++)
            {//Blue -> dress,jeans,hat
                string[] input = Console.ReadLine().Split(" -> ");
                string currColour = input[0];//blue
                string[] clothes = input[1].Split(',');//dress,jeans,hat
                if (!wardrobe.ContainsKey(currColour))
                {
                    wardrobe[currColour] = new Dictionary<string, int>();
                    //wardrobe.Add(currColour, new Dictionary<string, int>());

                }
                foreach (var cloth in clothes)//dress jeans hat
                {
                    if (!wardrobe[currColour].ContainsKey(cloth)) 
                    {
                        wardrobe[currColour].Add(cloth, 0);
                    }
                    wardrobe[currColour][cloth]++;
                }
            }
        
            return wardrobe;
        }
    }
}
