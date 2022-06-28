using System;
using System.Linq;

namespace Upr_06.Jagged_Array_Manipulator
{
    class Program
    {/*5
10 20 30
1 2 3
2
2
10 10
Add 0 10 10
Add 0 0 10
Subtract -3 0 10
Subtract 3 0 10
End*/
            static void Main(string[] args)
            {
                int rows = int.Parse(Console.ReadLine());

                double[][] jagged = RegisterJagged(rows);

                AnalyzeJagged(jagged);
                ModifyJagged(jagged);
                PrintJagged(jagged);
            }

             static void AnalyzeJagged(double[][] jagged)
            {
                for (int row = 0; row < jagged.Length - 1; row++)//-1 da ne hvanem exception
                {
                    if (jagged[row].Length == jagged[row + 1].Length)
                    {
                        jagged[row] = jagged[row].Select(x => x * 2).ToArray();
                        jagged[row + 1] = jagged[row + 1].Select(x => x * 2).ToArray();
                    }
                    else
                    {
                        jagged[row] = jagged[row].Select(x => x / 2).ToArray();
                        jagged[row + 1] = jagged[row + 1].Select(x => x / 2).ToArray();
                    }
                }
            }

             static void ModifyJagged(double[][] jagged)
            {
                string input = Console.ReadLine();
                while (input != "End")
                {
                    string[] cmd = input.Split();

                    int row = int.Parse(cmd[1]);
                    int col = int.Parse(cmd[2]);
                    int value = int.Parse(cmd[3]);

                    if (row < 0 || col < 0 || row >= jagged.Length || col >= jagged[row].Length)//proverka dali ne sa greshni indexite
                    {
                        input = Console.ReadLine();
                        continue;
                    }

                    if (cmd[0] == "Add") jagged[row][col] += value;
                    else jagged[row][col] -= value;//substract

                    input = Console.ReadLine();
                }
            }

             static void PrintJagged(double[][] arr)
            {
                for (int row = 0; row < arr.Length; row++)
                {
                    for (int col = 0; col < arr[row].Length; col++)
                    {
                        Console.Write($"{arr[row][col]} ");
                    }

                    Console.WriteLine();
                }
            }

             static double[][] RegisterJagged(int n)
            {
                double[][] jagged = new double[n][];

                for (int i = 0; i < n; i++)
                {
                    jagged[i] = Console.ReadLine()
                        .Split().Select(double.Parse).ToArray();
                }

                return jagged;
            }
        
    }
}
