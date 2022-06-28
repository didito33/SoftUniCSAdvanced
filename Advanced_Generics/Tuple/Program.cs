using System;

namespace Generics
{
    class Program
    {
        public static void Main(string[] args)
        {/*Adam Smith California
Mark 2
23 21.23212321*/
           
            string[] personInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] beerInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] numbersInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            MyTuple<string, string> personInfo = new MyTuple<string, string>($"{personInput[0]} {personInput[1]}", personInput[2] );
            int liters = int.Parse(beerInput[1]);
            MyTuple<string, int> beerInfo = new MyTuple<string, int>(beerInput[0],liters);
            int number1 = int.Parse(numbersInput[0]);
            double number2 = double.Parse(numbersInput[1]);
            MyTuple<int, double> numbersInfo = new MyTuple<int, double>(number1,number2);
            Console.WriteLine(personInfo);
            Console.WriteLine(beerInfo);
            Console.WriteLine(numbersInfo);
        }

    }
}
