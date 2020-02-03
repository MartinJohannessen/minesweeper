using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

namespace minesweeper
{

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = 10;
            int numberOfColumns = 10;
            int numberOfMines = 10;


            MineField mineField = new MineField(numberOfRows, numberOfColumns, numberOfMines);
            mineField.PlaceMines();
            mineField.PlaceNumbers();
            PrintBoard(mineField.Minefield);

        }

        private static void PrintBoard(int[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {

                    Console.Write(" [" + board[i, j] + "] ");
                  
                }

                Console.WriteLine();
            }
        }
    }

}
