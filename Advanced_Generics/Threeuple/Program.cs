using System;

namespace Generics
{
    class Program
    {
        public static void Main(string[] args)
        {/*Adam Smith Wallstreet New York
Mark 18 drunk
Karren 0.10 USBank*/
            string[] personInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] beerInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] numbersInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            MyTuple<string, string, string> personInfo = new MyTuple<string, string, string>
                ($"{personInput[0]} {personInput[1]}", personInput[2], personInput[3]);
            int liters = int.Parse(beerInput[1]);
            bool isDrunk = beerInput[2] == "drunk" ? true : false;
            /*bool isDrunk = false;
             if(beerInput[2] == "drunk";    isDrunk = true;*/
            MyTuple<string, int,bool> beerInfo = new MyTuple<string, int,bool>(beerInput[0], liters,isDrunk);
            
            double number2 = double.Parse(numbersInput[1]);
            MyTuple<string, double,string> numbersInfo = new MyTuple<string, double,string>(numbersInput[0],number2, numbersInput[2]);
            Console.WriteLine(personInfo);
            Console.WriteLine(beerInfo);
            Console.WriteLine(numbersInfo);
        }
    }
}
