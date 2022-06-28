using System;
using System.Collections.Generic;

namespace Upr_09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<char> stack = new Stack<char>();
            string lastOperationText = "";
            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                string[] cmdSplitted = command.Split();
                if(cmdSplitted[0] == "1")
                {
                    string characters = cmdSplitted[1];
                    for (int p = 0; p < characters.Length; p++)
                    {
                        char currentChar = characters[p];
                        stack.Push(currentChar);
                    }
                    lastOperationText = string.Join("", stack);
                }
                else if (cmdSplitted[0] == "2")
                {
                    int eraseCount = int.Parse(cmdSplitted[1]);
                    for (int j = 0; j < eraseCount; j++)
                    {
                        stack.Pop();
                    }
                    lastOperationText = string.Join("", stack);
                }
                else if (cmdSplitted[0] == "3")
                {
                    if (int.Parse(cmdSplitted[1]) == stack.Count)
                        Console.WriteLine(stack.Peek());
                    else if (int.Parse(cmdSplitted[1]) < stack.Count)
                    {
                        char currentChar = 'a';
                        for (int k = 0; k < stack.Count-(stack.Count-int.Parse(cmdSplitted[1])); k++)
                        {
                            currentChar = stack.Peek();
                            stack.Pop();

                        }
                        
                        Console.WriteLine(stack.Peek());
                        stack.Push(currentChar);
                        for (int m = 0; m < stack.Count-int.Parse(cmdSplitted[1]); m++)
                        {
                            stack.Pop();
                        }
                    }
                }
                /*else if (cmdSplitted[0] == "4")
                {
                    stack.Clear();
                    foreach (char item in lastOperationText)
                    {
                        stack.Push(item);
                    } 

                }*/

            }
        }
    }
}
