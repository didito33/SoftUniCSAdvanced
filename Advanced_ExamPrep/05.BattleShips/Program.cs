using System;
using System.Linq;

namespace _05.BattleShips
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] coordinates = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            string[,] matrix = new string[n, n];
            int firstPlayer = 0;// <
            int secondPlayer = 0;// >
            int destroyedShips = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] input = Console.ReadLine().Split();

                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[row, cols] = input[cols];

                    if (matrix[row, cols] == "<")
                        firstPlayer++;

                    else if (matrix[row, cols] == ">")
                        secondPlayer++;
                }
            }//1 2,3 1,2 1
            for (int i = 0; i < coordinates.Length; i += 2)
            {
                int row = coordinates[i];
                int col = coordinates[i + 1];

                if (!IsInRange(matrix, row, col))
                {
                    continue;
                }
                if (matrix[row, col] == ">")
                {
                    secondPlayer--;//gurmim go
                    matrix[row, col] = "X";
                    destroyedShips++;
                }
                else if (matrix[row, col] == "<")
                {
                    firstPlayer--;
                    matrix[row, col] = "X";
                    destroyedShips++;
                }
                else if (matrix[row, col] == "#")//Dynamite(mine) BOOOOOOM
                {

                    if(IsInRange(matrix,row-1,col))//up
                    {
                        if(matrix[row-1,col] == ">")
                        {
                            secondPlayer--;
                            destroyedShips++;
                        }
                        else if (matrix[row-1,col] == "<")
                        {
                            firstPlayer--;
                            destroyedShips++;
                        }
                        matrix[row - 1, col] = "X";
                    }

                    if (IsInRange(matrix, row +1, col))//down 
                    {
                        if (matrix[row + 1, col] == ">")
                        {
                            secondPlayer--;
                            destroyedShips++;
                        }
                        else if (matrix[row + 1, col] == "<")
                        {
                            firstPlayer--;
                            destroyedShips++;
                        }
                        matrix[row + 1, col] = "X";
                    }
                    if (IsInRange(matrix, row , col+1))//right
                    {
                        if (matrix[row, col+1] == ">")
                        {
                            secondPlayer--;
                            destroyedShips++;
                        }
                        else if (matrix[row , col+1] == "<")
                        {
                            firstPlayer--;
                            destroyedShips++;
                        }
                        matrix[row , col+1] = "X";
                    }

                    if (IsInRange(matrix, row , col-1))//left
                    {
                        if (matrix[row, col - 1] == ">")
                        {
                            secondPlayer--;
                            destroyedShips++;
                        }
                        else if (matrix[row, col - 1] == "<")
                        {
                            firstPlayer--;
                            destroyedShips++;
                        }
                        matrix[row, col - 1] = "X";
                    }

                    if (IsInRange(matrix, row -1, col+1))//Upright
                    {
                        if (matrix[row - 1, col + 1] == ">")
                        {
                            secondPlayer--;
                            destroyedShips++;
                        }
                        else if (matrix[row - 1, col + 1] == "<")
                        {
                            firstPlayer--;
                            destroyedShips++;
                        }
                        matrix[row - 1, col - 1] = "X";
                    }
                    if (IsInRange(matrix, row - 1, col - 1))//UpLeft
                    {
                        if (matrix[row - 1, col - 1] == ">")
                        {
                            secondPlayer--;
                            destroyedShips++;
                        }
                        else if (matrix[row - 1, col - 1] == "<")
                        {
                            firstPlayer--;
                            destroyedShips++;
                        }
                        matrix[row - 1, col - 1] = "X";
                    }
                    if (IsInRange(matrix, row + 1, col - 1))//downLeft
                    {
                        if (matrix[row + 1, col - 1] == ">")
                        {
                            secondPlayer--;
                            destroyedShips++;
                        }
                        else if (matrix[row + 1, col - 1] == "<")
                        {
                            firstPlayer--;
                            destroyedShips++;
                        }
                        matrix[row + 1, col - 1] = "X";
                    }
                    if (IsInRange(matrix, row + 1, col + 1))//downRight
                    {
                        if (matrix[row + 1, col + 1] == ">")
                        {
                            secondPlayer--;
                            destroyedShips++;
                        }
                        else if (matrix[row + 1, col + 1] == "<")
                        {
                            firstPlayer--;
                            destroyedShips++;
                        }
                        matrix[row + 1, col + 1] = "X";
                    }

                }
                if (firstPlayer == 0 || secondPlayer == 0)
                {
                    break;
                }
            }
            if (firstPlayer > 0 && secondPlayer > 0)
            {
                Console.WriteLine($"Its a draw! Player One has{firstPlayer} ships left. Player Two has {secondPlayer} ships left.");
            }
            else if (secondPlayer > 0)
            {
                Console.WriteLine($"Player Two has won the game! {destroyedShips} ships have been sunk in the battle.");
            }
            else if (firstPlayer > 0)
            {
                Console.WriteLine($"Player One has won the game! {destroyedShips} ships have been sunk in the battle.");
            }
        }

        private static bool IsInRange(string[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
            
        }
    }
}
