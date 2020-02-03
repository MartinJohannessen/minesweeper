using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

namespace minesweeper
{

    class Program
    {
        static void Main()
        {
            int numberOfRows = 10;
            int numberOfColumns = 10;
            int numberOfMines = 10;


            MineField mineField = new MineField(numberOfRows, numberOfColumns, numberOfMines);
            mineField.PlaceMines();
            mineField.PlaceNumbers();
            mineField.PrintBoard();



        }


    }
}

        