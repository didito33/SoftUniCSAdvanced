﻿using System;

namespace Upr_07.Knight_Game
{
    class Program
    {/*5
0K0K0
K000K
00K00
K000K
0K0K0*/
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] board = new char[size, size];
            for (int row = 0; row < board.GetLength(0); row++)
            {
                string items = Console.ReadLine();
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    board[row, col] = items[col];
                }
            }
            int removedKnights = 0;
            while (true)
            {
                int maxAttack = 0;
                int knightRow = 0;
                int knightCol = 0;
                for (int row = 0; row < board.GetLength(0); row++)
                {
                    for (int col = 0; col < board.GetLength(1); col++)
                    {
                        if (board[row, col] == '0')
                            continue;
                        //Knight
                        int currentAttacks = 0;
                        //upLeft upRight
                        if (isInRange(board,row-2,col-1) && board[row - 2, col - 1] == 'K')
                        {
                            currentAttacks++;
                        }
                        if(isInRange(board, row - 2, col +1) && board[row - 2, col +1] == 'K')
                        {
                            currentAttacks++;
                        }

                        //leftUp leftDown
                        if(isInRange(board, row -1, col - 2) && board[row - 1, col - 2] == 'K')
                        {
                            currentAttacks++;
                        }
                        if (isInRange(board, row + 1, col - 2) && board[row + 1, col - 2] == 'K')
                        {
                            currentAttacks++;
                        }

                        //downLeft downRight
                        if (isInRange(board, row +2, col -1) && board[row +2, col -1] == 'K')
                        {
                            currentAttacks++;
                        }
                        if (isInRange(board, row + 2, col +1) && board[row + 2, col + 1] == 'K')
                        {
                            currentAttacks++;
                        }

                        //rightUp rightDown
                        if (isInRange(board, row +1, col +2) && board[row +1, col + 2] == 'K')
                        {
                            currentAttacks++;
                        }
                        if (isInRange(board, row - 1, col + 2) && board[row - 1, col + 2] == 'K')
                        {
                            currentAttacks++;
                        }
                        if(currentAttacks > maxAttack)
                        {
                            maxAttack = currentAttacks;
                            knightRow = row;
                            knightCol = col;
                        }
                    }
                }

                if(maxAttack > 0)
                {
                    removedKnights++;
                    board[knightRow, knightCol] = '0';
                }
                else
                {
                    Console.WriteLine(removedKnights);
                    break;

                }
            }
        }

        private static bool isInRange(char[,] board, int row, int col)
        {
            return row >= 0 && row < board.GetLength(0) &&
                col >= 0 && col < board.GetLength(1);
        }
    }
}
