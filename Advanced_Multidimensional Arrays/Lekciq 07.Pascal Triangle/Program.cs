using System;

namespace Lekciq_07.Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {// primeren vhod : 5        ili 6    ili vsqko chislo..
            long n = long.Parse(Console.ReadLine());
            long[][] pascalTriangle = new long[n][];
            pascalTriangle[0] = new long[1] { 1 };//vinagi pochva s 1-ca
            for (long row = 1; row < n; row++)
            {           // new long e zashtoto go suzdavame  -  tuka moje prosto row+1
                pascalTriangle[row] = new long[pascalTriangle[row - 1].Length + 1];//na gorniq red goleminata+1
                for (long col = 0; col < pascalTriangle[row].Length; col++)
                {
                    if (pascalTriangle[row - 1].Length > col)
                    {
                        pascalTriangle[row][col] += pascalTriangle[row - 1][col];
                    }
                    if(col>0)
                    pascalTriangle[row][col] += pascalTriangle[row - 1][col - 1];
                }
            }
            PrlongJaggedArray(pascalTriangle);
        }
        static void PrlongJaggedArray(long[][] jagged)
        {
            for (long rows = 0; rows < jagged.Length; rows++)
            {
                Console.WriteLine($"{string.Join(" ", jagged[rows])}");
            }
        }
    }
}
