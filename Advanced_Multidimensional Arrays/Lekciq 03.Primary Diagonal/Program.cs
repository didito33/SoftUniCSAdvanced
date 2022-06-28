using System;

namespace Lekciq_03.Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            int primaryDiagonal = 0;
            /*Console.WriteLine($"Rows: {matrix.GetLength(0)}");
            Console.WriteLine($"cols: {matrix.GetLength(1)}");*/
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowInput = Console.ReadLine().Split(" ");
                for (int col = 0; col < matrix.GetLength(1); col++)
                {

                    matrix[row, col] = int.Parse(rowInput[col]);

                }

            }
            for (int i = 0; i <size; i++)
            {
                primaryDiagonal += matrix[i, i];
            }
            Console.WriteLine(primaryDiagonal);
            
        }
    }
}
