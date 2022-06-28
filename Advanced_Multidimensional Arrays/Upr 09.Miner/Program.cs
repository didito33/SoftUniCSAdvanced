﻿using System;

namespace Upr_09.Miner
{
    class Program
    {/*6
left left down right up left left down down down
* * * * * *
e * * * c *
* * c s * *
* * * * * *
c * * * c *
* * c * * **/
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            string[] directions = Console.ReadLine().Split();
            int coalCount = 0;
            int playerRow = 0;
            int playerCol = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                // char[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                  //   .Select(x => char.Parse(x)).ToArray(); - tova e po-dobroto
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col][0];//zashtoto e string[], bez [0] - ako beshe char array
                    if(matrix[row,col] == 'c')
                    {
                        coalCount++;
                    }
                    else if(matrix[row,col] == 's')
                    {
                        playerCol = col;
                        playerRow = row;
                    }

                }
            }
            foreach(var direction in directions)
            {
                int nextRow = 0;
                int nextCol = 0;
                if (direction == "left")
                {
                    nextCol = -1;
                }
                else if (direction == "right")
                {
                    nextCol = 1;
                }
                else if (direction == "down")
                    nextRow = 1;
                else if (direction == "up")
                    nextRow = -1;
                if (!isInRange(matrix, playerRow + nextRow, playerCol + nextCol))//if it exists
                    continue;
                playerRow += nextRow;
                playerCol += nextCol;
                if(matrix[playerRow, playerCol] == 'e')
                {
                    Console.WriteLine($"Game over! ({playerRow}, {playerCol})");
                    Environment.Exit(0);
                }
                if(matrix[playerRow,playerCol] == 'c')
                {
                    matrix[playerRow, playerCol] = '*';
                    coalCount--;
                    if(coalCount == 0)
                    {
                        Console.WriteLine($"You collected all coals! ({playerRow}, {playerCol})");
                        Environment.Exit(0);
                    }
                }
                //nextRow = e(endGame)
                //nextCell = c
            }
            Console.WriteLine($"{coalCount} coals left. ({playerRow}, {playerCol})");
        }
        private static bool isInRange(char[,] board, int row, int col)
        {
            return row >= 0 && row < board.GetLength(0) &&
                col >= 0 && col < board.GetLength(1);
        }
    }
}
