using System;
using System.Collections.Generic;

namespace Lekciq_04.Matching_Brackets
{
    class Program
    {//             1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] ==  '(')
                {
                    stack.Push(i);//slagam nai-novata otvarqshta skoba nai-otgore
                }
                if (expression[i] == ')')
                {//                 pop-a mi maha i samiq element ot stack-a
                    int startIndex = stack.Pop();//i tova mi e nai-novata otvarqshta skoba
                    int endIndex = i;//tova mi e zatvarqshtata й skoba      
                                                        //                            +1 za da printq i skobata
                    Console.WriteLine(expression.Substring(startIndex, endIndex - startIndex + 1));
                }
            }
        }
    }
}
