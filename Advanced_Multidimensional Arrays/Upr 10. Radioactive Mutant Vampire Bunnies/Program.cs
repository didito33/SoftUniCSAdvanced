using System;
using System.Collections.Generic;
using System.Linq;

namespace Upr_10._Radioactive_Mutant_Vampire_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sizeRow = dimensions[0];
            int sizeCol = dimensions[1];

            char[,] matrix = new char[sizeRow, sizeCol];
            int playerRow = 0;
            int playerCol = 0;
            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                    if (matrix[row, col] == 'P')
                    {
                        playerCol = col;
                        playerRow = row;
                    }
                }
            }
            string directions = Console.ReadLine();
            bool hasWon = false;
            bool isAlive = true;
            foreach (var direction in directions)
            {
                int nextRow = 0;
                int nextCol = 0;
                matrix[playerRow, playerCol] = '.';
                switch (direction)
                {
                    case 'U':
                        nextRow = -1;
                        break;
                    case 'D':
                        nextRow = 1;
                        break;
                    case 'L':
                        nextCol = -1;
                        break;
                    case 'R':
                        nextCol = 1;
                        break;

                }
                if (!IsInRange(matrix, playerRow + nextRow, playerCol + nextCol))
                    hasWon = true;
                else//ako e vuv range -> otiva na next position
                {
                    playerRow += nextRow;
                    playerCol += nextCol;
                }
                //ako tam kudeto stupi e B-> gg
                if (matrix[playerRow, playerCol] == 'B')
                    isAlive = false;//gg well played
                else if(!hasWon)
                matrix[playerRow, playerCol] = 'P';

                List<int[]> bunnies = new List<int[]>();
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row, col] == 'B')
                        {
                            bunnies.Add(new int[] { row, col });
                        }
                    }
                }
                foreach (var currentBunny in bunnies)
                {
                    int bunnyRow = currentBunny[0];
                    int bunnyCol = currentBunny[1];
                    //up
                    if (IsInRange(matrix, bunnyRow - 1, bunnyCol))
                    {
                        if (matrix[bunnyRow - 1, bunnyCol] == 'P')
                        {
                            isAlive = false;
                        }
                        matrix[bunnyRow - 1, bunnyCol] = 'B';
                    }
                    //down
                    if (IsInRange(matrix, bunnyRow + 1, bunnyCol))
                    {
                        if (matrix[bunnyRow + 1, bunnyCol] == 'P')
                        {
                            isAlive = false;
                        }
                        matrix[bunnyRow + 1, bunnyCol] = 'B';
                    }
                    //left
                    if (IsInRange(matrix, bunnyRow, bunnyCol - 1))
                    {
                        if (matrix[bunnyRow, bunnyCol - 1] == 'P')
                        {
                            isAlive = false;
                        }
                        matrix[bunnyRow, bunnyCol - 1] = 'B';
                    }
                    //right
                    if (IsInRange(matrix, bunnyRow, bunnyCol + 1))
                    {
                        if (matrix[bunnyRow, bunnyCol + 1] == 'P')
                        {
                            isAlive = false;
                        }
                        matrix[bunnyRow, bunnyCol + 1] = 'B';
                    }
                }
                if (!isAlive || hasWon)
                PrintMatrix(matrix);

                if (!isAlive)
                {
                    Console.WriteLine($"dead: {playerRow} {playerCol}");
                    break;
                }
                else if (hasWon)
                {
                    Console.WriteLine($"won: {playerRow} {playerCol}");
                    break;

                }
            }
            
                
        }
        private static bool IsInRange(char[,] board, int row, int col)
        {
            return row >= 0 && row < board.GetLength(0) &&
                col >= 0 && col < board.GetLength(1);
        }
        static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }
                Console.WriteLine();
            }
        }
    }
}
