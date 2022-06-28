using System;
using System.Linq;

namespace _02.Mario
{
    class Program
    {
        static void Main(string[] args)
        {
            int marioLives = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());

            int marioRow = 0;
            int marioCol = 0;
            char[][] matrix = new char[rows][];

            for (int i = 0; i < rows; i++)// Finding Mario
            {
               char[] currentRow = Console.ReadLine().ToCharArray();
                matrix[i] = currentRow;
                if (currentRow.Contains('M'))
                {
                    marioRow = i;
                    marioCol = currentRow.ToList().IndexOf('M');
                }
            }
            while (true)
            {
                string[] cmd = Console.ReadLine().Split();
                string command = cmd[0];
                int enemyRow = int.Parse(cmd[1]);
                int enemyCol = int.Parse(cmd[2]);
                matrix[enemyRow][enemyCol] = 'B';
                marioLives--;

                matrix[marioRow][marioCol] = '-';//setvame si defaultnata stoinost preedi da se premestim

                if (command == "W" && marioRow - 1 >=0)//up
                {
                    marioRow--;
                }
                else if (command == "S" && marioRow + 1 <rows)//down
                {
                    marioRow++;
                }
                else if (command == "A" && marioCol -1 >= matrix[0].Length)//left
                {
                    marioCol--;
                }
                else if (command == "D" && marioCol + 1 < matrix[0].Length)//right
                {
                    marioCol++;
                }

                if(matrix[marioRow][marioCol] == 'B')
                {
                    marioLives -= 2;
                }

                else if (matrix[marioRow][marioCol] == 'P')
                {
                    matrix[marioRow][marioCol] = '-';
                    Console.WriteLine($"Mario has successfully saved the princess! Lives left: {marioLives}");
                    break;
                }
                if (marioLives <= 0)
                {
                    matrix[marioRow][marioCol] = 'X';
                    Console.WriteLine($"Mario died at {marioRow};{marioCol}.");
                    break;
                }

                matrix[marioRow][marioCol] = 'M';
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine(new string (matrix[i]));
            }
            /*for (int row = 0; row < arr.Length; row++)
                {
                    for (int col = 0; col < arr[row].Length; col++)
                    {
                        Console.Write($"{arr[row][col]} ");
                    }

                    Console.WriteLine();
                }*/
        }
    }
}
