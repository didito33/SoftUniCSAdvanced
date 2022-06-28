using System;

namespace Upr_01._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;
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
            for (int i = 0; i < size; i++)
            {
                primaryDiagonal += matrix[i, i];
            }
            //Console.WriteLine(primaryDiagonal);
               /*int k = 0;
                for (int j = size - 1; j >= 0; j--)
                {
                    //secondaryDiagonal += matrix[k, j];
                    secondaryDiagonal += matrix[k, j];// matrix.GetLength(1)-1 -i , imame 2->1 ->0
                    k++;                               //                           pri i =0,i=1 i=2
                }//                     size*/
            for (int i = 0; i < matrix.GetLength(0); i++)
            {//                             0    3 - 1 -0 = 2
                //                          1    3 -1 - 1 = 1
                //                          2    3 - 1 -2 = 0
                secondaryDiagonal += matrix[i, matrix.GetLength(1) - 1 - i];
            }
            Console.WriteLine(Math.Abs(primaryDiagonal-secondaryDiagonal));
        }
        /*3
11 2 4
4 5 6
10 8 -12*/
    }
}
