using System;
using System.Linq;
using System.Collections.Generic;

namespace secondExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixLength = int.Parse(Console.ReadLine());
            char[,] matrix = new char[matrixLength, matrixLength];
            int row = -1;
            int col = -1;
            int beaverCount = 0;
            for (int rows = 0; rows < matrixLength; rows++)
            {
                char[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int cols = 0; cols < matrixLength; cols++)
                {
                    if (input[cols] == 'B')
                    {
                        row = rows;
                        col = cols;
                    }
                    matrix[rows, cols] = input[cols];
                }
            }
            List<char> branchesList = new List<char>();
            string cmd = Console.ReadLine();
            while (cmd != "end")
            {
                matrix[row, col] = '-';
                SwapDir(ref row, ref col, cmd);
                if (IsOutside(row, col, matrixLength))
                {
                    ReverseBeaver(ref row, ref col, cmd);
                    if (branchesList.Any())
                        branchesList.RemoveAt(branchesList.Count - 1);
                }
                if (char.IsLower(matrix[row, col]))
                    branchesList.Add(matrix[row, col]);
                if (matrix[row, col] == 'F')
                {
                    matrix[row, col] = '-';
                    if (IsGoingOpposite(ref row, ref col, cmd, matrixLength))
                    {
                        LastCellOpposite(ref row, ref col, cmd, matrixLength);
                    }
                    else
                    {
                        LastCell(ref row, ref col, cmd, matrixLength);
                    }
                    if (char.IsLower(matrix[row, col]))
                    {
                        branchesList.Add(matrix[row, col]);
                    }
                }

                matrix[row, col] = 'B';
                if (AreWoodsTaken(matrix))
                {
                    break;
                }
                cmd = Console.ReadLine();
            }
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(0); cols++)
                {
                    if (char.IsLower(matrix[rows, cols]))
                    {
                        beaverCount++;
                    }
                }
            }
            if (beaverCount > 0)
            {
                Console.WriteLine($"The Beaver failed to collect every wood branch. There are {beaverCount} branches left.");
            }
            else
            {
                Console.WriteLine($"The Beaver successfully collect {branchesList.Count} wood branches: {string.Join(", ", branchesList)}.");
            }
            for (int rows = 0; rows < matrixLength; rows++)
            {
                for (int cols = 0; cols < matrixLength; cols++)
                {
                    Console.Write(matrix[rows, cols] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void SwapDir(ref int row, ref int col, string command)
        {
            if (command == "up")
            {
                row--;
            }
            else if (command == "down")
            {
                row++;
            }
            else if (command == "right")
            {
                col++;
            }
            else if (command == "left")
            {
                col--;
            }
        }
        public static void ReverseBeaver(ref int row, ref int col, string command)
        {
            if (command == "up")
            {
                row++;
            }
            else if (command == "down")
            {
                row--;
            }
            else if (command == "right")
            {
                col--;
            }
            else if (command == "left")
            {
                col++;
            }
        }
        public static bool IsGoingOpposite(ref int row, ref int col, string command, int matrixLength)
        {
            if (command == "up"&& row == 0 )
            {
                return true;
            }
            else if (command == "down" && row == matrixLength - 1 )
            {
                return true;
            }
            else if (command == "left" && col == 0 )
            {
                return true;
            }
            else if (command == "right" && col == matrixLength - 1)
            {
                return true;
            }

            return false;
        }

      

        public static void LastCellOpposite(ref int row, ref int col, string command, int matrixLength)
        {
            if(command == "up")
            {
                row = matrixLength - 1;
            }
            else if (command == "down")
            {
                row = 0;
            }
            else if(command == "right")
            {
                col = 0;
            }
            else if (command == "left")
            {
                col = matrixLength - 1;
            }
        }
        public static bool AreWoodsTaken(char[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(0); cols++)
                {
                    if (char.IsLower(matrix[rows, cols]))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static void LastCell(ref int row, ref int col, string command, int matrixLength)
        {
           
            if(command == "up")
            {
                row = 0;
            }
            else if (command == "down")
            {
                row = matrixLength - 1;
            }
            else if (command == "right")
            {
                col = matrixLength - 1;
            }
            else if (command == "left")
            {
                col = 0;
            }
        }

        

       

        
        public static bool IsOutside(int row, int col, int matrixLength)
        {
            return row < 0 || col < 0 || row >= matrixLength || col >= matrixLength;
        }
    }
}