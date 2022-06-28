using System;
using System.Collections.Generic;
using System.Linq;

namespace Upr_06.Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            //5 6
            //SoftUni
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            char[,] matrix = new char[dimensions[0], dimensions[1]];
            char[] snek = Console.ReadLine().ToCharArray();

            Queue<char> snekQueue = new Queue<char>(snek);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = snekQueue.Dequeue();
                        if (snekQueue.Count == 0)
                            snekQueue = new Queue<char>(snek);
                    }
                }
                else
                {
                    for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
                    {
                        matrix[i, j] = snekQueue.Dequeue();
                        if (snekQueue.Count == 0)
                            snekQueue = new Queue<char>(snek);
                    }
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }

                Console.WriteLine();
                /*int[] rowCol = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                string snakeSymbols = Console.ReadLine();
                char[,] matrix = new char[rowCol[0], rowCol[1]];

                bool rightToLeft = true;
                int indexOfSymbol = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {

                    if (rightToLeft)//ot dqsno na lqvo
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            matrix[row, col] = snakeSymbols[indexOfSymbol++];//взимам 0левия индекс .. след това 1 и така нататък
                            if (indexOfSymbol == snakeSymbols.Length)
                            {
                                indexOfSymbol = 0;
                            }
                        }

                        rightToLeft = false;
                    }

                    else
                    {
                        for (int col = matrix.GetLength(1)-1; col >= 0; col--)
                        {
                            matrix[row, col] = snakeSymbols[indexOfSymbol++];//така взимам буквите 
                            if (indexOfSymbol == snakeSymbols.Length)
                            {
                                indexOfSymbol = 0;
                            }
                        }
                        rightToLeft = true;
                    }

                }
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        Console.Write(matrix[row,col]);
                    }
                    Console.WriteLine();*/
            }
        }
    }
}
