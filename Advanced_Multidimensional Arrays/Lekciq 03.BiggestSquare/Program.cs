using System;
using System.Linq;

namespace Lekciq_03.BiggestSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int biggestSquareRows = 3;//tuka moga da gi promenqm
            int biggestSquareCols = 3;
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] rowInput = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowInput[col];
                }
            }
            int maxSum = int.MinValue;
            int maxRowIndex = 0;
            int maxColIndex = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if(row+  biggestSquareCols -1 < rows && col + biggestSquareCols-1 < cols)//za da napravim kvadrat
                    {
                        //int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                        int sum = 0;
                        for (int currentRow = row; currentRow < row+biggestSquareRows; currentRow++)
                        {
                            for (int currentCol = col; currentCol < col + biggestSquareCols; currentCol++)
                            {
                                sum += matrix[currentRow, currentCol];
                            }
                        }
                        if(sum > maxSum)
                        {
                            maxSum = sum;
                            maxColIndex = col;
                            maxRowIndex = row;
                        }
                    }
                }
            }
            
            for (int row = maxRowIndex; row < maxRowIndex+biggestSquareRows; row++)
            {
                for (int col = maxColIndex; col < maxColIndex + biggestSquareCols; col++)
                {
                    Console.Write($"{matrix[row,col]}, ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxSum);
            /*3, 6
7, 1, 3, 3, 2, 1
1, 3, 9, 8, 5, 6
4, 6, 7, 9, 1, 0
             */
        }
    }
}
