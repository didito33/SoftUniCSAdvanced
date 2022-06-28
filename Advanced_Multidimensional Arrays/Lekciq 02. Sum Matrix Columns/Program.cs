using System;

namespace Lekciq_02._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            int rows = int.Parse(input[0]);
            int cols = int.Parse(input[1]);
            int[,] matrix = new int[rows, cols];
            int columnSum = 0;

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
            for (int j = 0; j < cols; j++)//cols
            {
                columnSum = 0;
                for (int i = 0; i < rows; i++)//row - tozi s redovete go pravq vutreshen cycle
                {
                    columnSum += matrix[i, j];//matrix[0,0], matrix[1,0]
                    
                }
                Console.WriteLine(columnSum);
            }
            /*for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    columnSum += matrix[]
                }
            }*/
           
            

        }
    }
}
