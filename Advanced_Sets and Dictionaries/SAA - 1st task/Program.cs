using System;
using System.Collections.Generic;
using System.Linq;

namespace SAA___1st_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < rows; i++)
            {
                int[] rowInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = (rowInput[j]);
                }
            }

            List<int> xrows = new List<int>();
            List<int> xcols = new List<int>();
           
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, 0] > x || matrix[i, rows-1] < x) break; // otivame na nov red
                    else if(matrix[i,j] == x)
                    {
                        xrows.Add(i);
                        xcols.Add(j);
                    }

                }
            }
            if (xrows.Count == 0) Console.WriteLine("X not found.");
            else
            {
                for (int i = 0; i < xrows.Count; i++)
                {
                    Console.WriteLine($"{1+xrows[i]} row and {1+xcols[i]} column");
                }
            }
            /*int[] a = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (!dict.ContainsKey(a[i]))
                {
                    dict[a[i]] = 1;
                }
                else
                    dict[a[i]]++;
            }
            if (dict.Count == 1) Console.WriteLine("1");//vs ednkavi
            else if (dict.Count == 5) Console.WriteLine("6");//vs razlichni
            else if (dict.Count == 4) Console.WriteLine("5");//samo 2 chisla ednakvi
            else if (dict.Count == 3) Console.WriteLine("4");// 2 endkavi, drugi 2 ednakvi i 1 random
            else if (dict.Count == 2)
            {
                foreach (var item in dict)
                {
                    if (item.Value == 4)
                    {
                        Console.WriteLine("2");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("3");
                        return;
                    }
                }
            }*/
        }
    }
}
