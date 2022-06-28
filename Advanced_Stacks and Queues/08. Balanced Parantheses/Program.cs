using System;
using System.Collections.Generic;

namespace _08._Balanced_Parantheses
{
    class Program
    {
        static void Main(string[] args)
        {
            // {[()]}              - YES
            // {[(])}              - NO
            // {{[[(())]]}}        - YES
            string input = Console.ReadLine();
            bool isBalanced = true;
            Stack<char> stack = new Stack<char>();
            foreach (var item in input)
            {
                if (item == '{' ||
                    item == '[' ||
                    item == '(')
                {
                    stack.Push(item);
                    continue;
                }
                if (stack.Count == 0)
                {
                    isBalanced = false;
                    break;
                }
                if (item == '}' && stack.Peek() == '{')//ako matchvat popvam otvarqshtata skoba
                    stack.Pop();

                else if (item == ']' && stack.Peek() == '[')//ako matchvat popvam otvarqshtata skoba
                    stack.Pop();

                else if (item == ')' && stack.Peek() == '(')//ako matchvat popvam otvarqshtata skoba
                    stack.Pop();

                else
                {
                    isBalanced = false;
                    break;
                }//ako ne vliza v nito 1 - breakvam
            }
            if (!isBalanced || stack.Count > 0)//ako ima elementi v stack-a
                Console.WriteLine("NO");
            else
                Console.WriteLine("YES");
        }
    }
}
