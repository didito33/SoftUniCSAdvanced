using System;
using System.Linq;

namespace Lekciq_06.Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jagged = ReadJaggedArray(rows);
            string command = Console.ReadLine();
            while(command != "END")
            {
                string[] input = command.Split();
                int row = int.Parse(input[1]);
                int col = int.Parse(input[2]);
                int value = int.Parse(input[3]);
                if(row>=jagged.Length || row < 0 || col < 0 ||  col>= jagged[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else if(input[0] == "Add") 
                {
                    jagged[row][col] += value;
                }
                else if(input[0] == "Subtract")
                {
                    jagged[row][col] -= value;
                }
                command = Console.ReadLine();
            }
            PrintJaggedArray(jagged);
        }

        static int[][] ReadJaggedArray(int rows)
        {
            int[][] jagged = new int[rows][];
            for (int row = 0; row < rows; row++)
            {
                jagged[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            return jagged;
        }
        static void PrintJaggedArray(int[][] jagged)
        {
            for (int rows = 0; rows < jagged.Length; rows++)
            {
                Console.WriteLine($"{string.Join(" ", jagged[rows])}");
            }
        }
        /*4
1 2 3 4
5 6 7 8
8 7 6 5
4 3 2 1
Add 4 4 100
Add 3 3 100
Subtract -1 -1 42
Subtract 0 0 42
END*/
    }
}
