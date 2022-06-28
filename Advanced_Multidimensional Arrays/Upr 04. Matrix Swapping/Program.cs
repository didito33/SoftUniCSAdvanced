using System;
using System.Linq;

namespace Upr_04._Matrix_Swapping
{
    class Program
    {/*2 3
1 2 3
4 5 6
swap 0 0 1 1
swap 10 9 8 7
swap 0 1 1 0
END*/ /*  
       *  OR 
1 2
Hello World
0 0 0 1
swap 0 0 0 1
swap 0 1 0 0
END*/
        static void Main(string[] args)
        {
            int[] rowCol = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string[,] matrix = new string[rowCol[0], rowCol[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < matrix.GetLength(1); col++)
                {

                    matrix[row, col] = (rowInput[col]);

                }

            }
            string command = Console.ReadLine();
            while(command != "END")
            {
                string[] cmdSplitted = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);//swap 0 0 1 1
                if (cmdSplitted[0] == "swap")
                {
                    if (int.Parse(cmdSplitted[1]) >= matrix.GetLength(0) ||
                        int.Parse(cmdSplitted[2]) >= matrix.GetLength(1) ||
                        int.Parse(cmdSplitted[3]) >= matrix.GetLength(0) ||
                        int.Parse(cmdSplitted[4]) >= matrix.GetLength(1))
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else//swapping
                    {

                        /*string a = "hello";
                        string b = "world";
                        a = a + b;
                        b = a.Substring(0, a.Length - b.Length);
                        a = a.Substring(b.Length); - start index b.length do samiq krai*/
                        int one = int.Parse(cmdSplitted[1]);
                        int two = int.Parse(cmdSplitted[2]);
                        int three = int.Parse(cmdSplitted[3]);
                        int four = int.Parse(cmdSplitted[4]);
                        //string swap = matrix[cmdSplitted[1],cmdSplitted[2]].Substring(0,matrix[cmdSplitted[1],cmdSplitted[2]].Length);
                        matrix[one, two] += matrix[three, four];
                        matrix[three, four] = matrix[one,two].Substring(0, matrix[one, two].Length - matrix[three, four].Length);
                        matrix[one, two] = matrix[one, two].Substring(matrix[three, four].Length);
                        PrintingMatrix(matrix);
                    }
                }
                else
                    Console.WriteLine("Invalid input!");

                command = Console.ReadLine();
            }


        }
        static void PrintingMatrix(string[,] matrix)
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
