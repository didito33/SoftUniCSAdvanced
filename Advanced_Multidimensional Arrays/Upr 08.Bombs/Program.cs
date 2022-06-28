using System;
using System.Linq;

namespace Upr_08.Bombs
{
    class Program
    {/*4
8 3 2 5
6 4 7 9
9 9 3 6
6 8 1 2
1,2 2,1 2,0*/
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine().Split()
                    .Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }
            

            //1,2 2,1 2,0
            int[] indexes = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            for (int i = 0; i < indexes.Length; i+=2)
            {
                int row = indexes[i];
                int col = indexes[i + 1];
                if(matrix[row,col] <= 0)
                {
                    continue;
                }
                int valueBomb = matrix[row, col];//bomba
                //up, down, left, right, upLeft, upRight,downLeft, downRight
                if (isInRange(matrix, row - 1, col) && matrix[row-1,col] > 0)
                {
                    matrix[row - 1, col] -= valueBomb;
                }
                if (isInRange(matrix, row + 1, col) && matrix[row + 1, col] > 0)
                {
                    matrix[row + 1, col] -= valueBomb;
                }
                if (isInRange(matrix, row , col-1) && matrix[row , col-1] > 0)
                {
                    matrix[row , col-1] -= valueBomb;
                }
                if (isInRange(matrix, row, col +1) && matrix[row , col +1] > 0)
                {
                    matrix[row , col+1] -= valueBomb;
                }
                if (isInRange(matrix, row-1, col -1) && matrix[row-1, col -1] > 0)
                {
                    matrix[row-1, col - 1] -= valueBomb;
                }
                if (isInRange(matrix, row - 1, col + 1) && matrix[row - 1, col + 1] > 0)
                {
                    matrix[row - 1, col + 1] -= valueBomb;
                }
                if (isInRange(matrix, row + 1, col - 1) && matrix[row + 1, col - 1] > 0)
                {
                    matrix[row + 1, col - 1] -= valueBomb;
                }
                if (isInRange(matrix, row + 1, col + 1) && matrix[row + 1, col + 1] > 0)
                {
                    matrix[row + 1, col + 1] -= valueBomb;
                }
                matrix[row, col] = 0; //занулявам бомбата където е гръмнала

            }
            int aliveCellsCount = 0;
            int aliveSum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if(matrix[row,col] > 0)//alive
                    {
                        aliveCellsCount++;
                        aliveSum += matrix[row, col];
                    }

                }
            }
            Console.WriteLine($"Alive cells: {aliveCellsCount}");
            Console.WriteLine($"Sum: {aliveSum}");
            PrintMatrix(matrix);
        }
        private static bool isInRange(int[,] board, int row, int col)
        {
            return row >= 0 && row < board.GetLength(0) &&
                col >= 0 && col < board.GetLength(1);
        }
        static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row,col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
