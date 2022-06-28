using System;
using System.Collections.Generic;

namespace Lekciq_03.Simple_Calculator
{
    class Program
    {
        // 2 + 5 + 10 - 2 - 1       =   14
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>(Console.ReadLine().Split());
            Stack<string> reversedStack = new Stack<string>();
            
            while(stack.Count > 0)
            {
                reversedStack.Push(stack.Pop());//taka go reversve-kam
            }
            
            while(reversedStack.Count > 1)//zashtoto iskam samo 1 element
            {
                int firstNumber = int.Parse(reversedStack.Pop());
                string mathOperator = reversedStack.Pop();
                int secondNumber = int.Parse(reversedStack.Pop());
                if(mathOperator == "+")
                {
                    reversedStack.Push((firstNumber + secondNumber).ToString());
                }
                else if(mathOperator == "-")
                {
                    reversedStack.Push((firstNumber - secondNumber).ToString());
                }
            }
            Console.WriteLine(reversedStack.Pop());//nai-gorniq
        }
    }
}
