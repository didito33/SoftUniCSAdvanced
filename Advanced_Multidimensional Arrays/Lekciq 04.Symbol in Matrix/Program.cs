using System;

namespace Lekciq_04.Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            for (int i = 0; i < n; i++)
            {
                char[] rows = Console.ReadLine().ToCharArray();
                for (int j = 0; j < n; j++)
                {
                    
                    matrix[i, j] = rows[j];
                }
            }
            for (int i = 0; i <n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (!char.IsLetterOrDigit(matrix[i, j]))
                    {
                        Console.WriteLine($"({i}, {j})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{n} does not occur in the matrix");
        }
    }
}
