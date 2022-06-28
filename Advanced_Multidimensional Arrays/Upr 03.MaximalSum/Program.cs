using System;
using System.Linq;

namespace Upr_03.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4 5
1 5 5 2 4
2 1 4 14 3
3 7 11 2 8
4 8 12 16 4*/
            int[] rowCol = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[,] matrix = new int[rowCol[0], rowCol[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < matrix.GetLength(1); col++)
                {

                    matrix[row, col] = int.Parse(rowInput[col]);

                }

            }
            int maxSum = int.MinValue;
            int maxSumRow = 0;
            int maxSumCol = 0;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)//zashtoto shte imame +2
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)//zashtoto shte imame +2
                {
                    /*int currentSum = matrix[0, 0] + matrix[0, 1] + matrix[0, 2] +
                        matrix[1, 0] + matrix[1, 1] + matrix[1, 2] +
                        matrix[2, 0] + matrix[2, 1] + matrix[2, 2];*/
                    //така обхождаме [3,3] субМатрицата
                    int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                        matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxSumRow = row;//запазваме си редът, от където започва макс сумата
                        maxSumCol = col;//запазваме си колоната, от където започва макс сумата
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            for (int row = maxSumRow; row  <= maxSumRow + 2 ; row++)//започва от макса и ни трябват още 2 елемента
            {                                                       //за да се получи 3х3макс Матрицата
                for (int col = maxSumCol; col <= maxSumCol+2; col++)// ---:---+
                {
                    Console.Write($"{matrix[row,col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
