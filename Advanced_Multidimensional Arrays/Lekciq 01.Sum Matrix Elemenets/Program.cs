using System;

namespace Lekciq_01.Sum_Matrix_Elemenets
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            int rows = int.Parse(input[0]);
            int cols = int.Parse(input[1]);
            int[,] matrix = new int[rows, cols];
            int sum = 0;
           
            /*Console.WriteLine($"Rows: {matrix.GetLength(0)}");
            Console.WriteLine($"cols: {matrix.GetLength(1)}");*/
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowInput = Console.ReadLine().Split(", ");
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    
                    matrix[row, col] = int.Parse(rowInput[col]);
                    sum += matrix[row, col];
                }
                
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    //PRINTING CYCLES
                }
            }
            Console.WriteLine(matrix.GetLength(0));//rows
            Console.WriteLine(matrix.GetLength(1));//cols
            Console.WriteLine(sum);


        }
    }
}
