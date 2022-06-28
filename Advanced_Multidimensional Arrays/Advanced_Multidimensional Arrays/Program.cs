using System;
using System.Threading;

namespace Advanced_Multidimensional_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3];
            /*{
                /*{ 4,5,6},
                { 11,3,9},
                {1,2,3 }*/
            /*/;}
            */


            /*matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[0, 2] = 3;
            

            matrix[1, 0] = 5;
            matrix[1, 1] = 6;
            matrix[1, 2] = 7;*/

            /*Console.WriteLine($"matrix[0,0] = {matrix[0, 0]}");
            Console.WriteLine($"matrix[0,1] = {matrix[0, 1]}");
            Console.WriteLine($"matrix[0,2] = {matrix[0, 2]}");
            Console.WriteLine();
            Console.WriteLine($"matrix[1,0] = {matrix[1, 0]}");
            Console.WriteLine($"matrix[1,1] = {matrix[1, 1]}");
            Console.WriteLine($"matrix[1,2] = {matrix[1, 2]}");
            Console.WriteLine();
            Console.WriteLine($"matrix[2,0] = {matrix[2, 0]}");
            Console.WriteLine($"matrix[2,1] = {matrix[2, 1]}");
            Console.WriteLine($"matrix[2,2] = {matrix[2, 2]}");*/

            int row = 15;
            int col = 0;
            while (true)
            {
                Console.Clear();
                Console.SetCursorPosition(col, row);//tuk sa razmeneni
                col++;
                Console.WriteLine("@");
                Thread.Sleep(100);
            }
        }
    }
}
