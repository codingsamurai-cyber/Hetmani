using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] board = new int[8, 8];

            isSafe(7, 7);
            Solve(0);
            Draw();

            void Draw()
            {
                for (int i = 0; i < 8; i++)
                {
                    for(int j = 0; j < 8; j++)
                    {
                        Console.Write(board[i, j] + "   ");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
            }

            bool Solve(int col)
            {
                if (col >= 8)
                {
                    return true;
                }

                for (int i = 0; i < 8; i++)
                {
                    if (isSafe(i, col))
                    {
                        board[i, col] = 1;

                        if (Solve(col + 1))
                        {
                            return true;
                        }

                        board[i, col] = 0; // backtrack
                    }
                }
                return false;
            }
                bool isSafe(int row, int col)
            {
                //Checks whether there's a queen in a row 
                for (int x = 0; x < 8; x++)
                {
                    if (board[row, x] == 1)
                    {
                        return false;
                    }
                }
                //Checks whether there's a queen in a column
                for (int x = row, y = col; x < 8 && x >= 0 && y < 8 && y >= 0; x--)
                {
                    if (board[x, y] == 1)
                    {
                        return false;
                    }
                }
                //Checks whether there's a queen in a upper right to lower left diagonal
                for (int x = row, y = col; x >= 0 && y >= 0; x--, y--)
                {
                    if (board[x, y] == 1)
                    {
                        return false;
                    }
                }
                //Checks whether there's a queen in a lower right to upper left diagonal
                for(int x = row, y = col; x < 8 && y >= 0; x++, y--)
                {
                    if (board[x, y] == 1)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
