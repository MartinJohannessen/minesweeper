using System;
using System.Collections.Generic;

namespace minesweeper
{
    internal class MineField
    {
        private int numberOfRows;
        private int numberOfColumns;
        private int numberOfMines;
        private List<Mine> mines = new List<Mine>();
        // A representation of the underying board with mines = <0, clear = 0, number = number>0.
        public int[,] Board { get; set; }

        public MineField(int numberOfRows, int numberOfColumns, int numberOfMines)
        {
            this.numberOfRows = numberOfRows;
            this.numberOfColumns = numberOfColumns;
            this.numberOfMines = numberOfMines;
        }



        public void PlaceMines()
        {
            Board = new int[numberOfRows, numberOfColumns];
            Random random = new Random();
            int mineCounter = numberOfMines;
            while (mineCounter > 0)
            {
                // Random coordinates to place mine in.
                int mineRowCordinate = random.Next(numberOfRows);
                int mineColumnCordinate = random.Next(numberOfColumns);

                // Check if there is already a mine there.
                int cordinateValue = Board[mineRowCordinate, mineColumnCordinate];
                if (cordinateValue < 0) { continue; }

                // The bombs start as -10 because the PlaceNumbers() method adds 1 to all coordinates around the bomb.
                Board[mineRowCordinate, mineColumnCordinate] = -10;

                // Add the mines to a list because they are used in the PlaceNumbers() method.
                mines.Add(new Mine(mineRowCordinate, mineColumnCordinate));
                mineCounter--;

            }
        }

        /* 
         * For each mine in the field, add 1 to any cell that is adjacent(and itself incidentally),
         * this is done using a 3x3 loop with the mine in the center.
         */
        public void PlaceNumbers()
        {
            foreach(Mine mine in mines)
            {
                int rowCord = mine.MineRowCordinate;
                int colCord = mine.MineColumnCordinate;

                for (int i = rowCord-1; i<=rowCord+1; i++)
                {
 
                    for (int j = colCord - 1; j <= colCord + 1; j++)
                    {
                        // Check if index is inside the board.
                        if ((i>=0 && i< numberOfRows)&&(j >= 0 && j < numberOfColumns))
                        {
                            Board[i, j]++;
                        }
                        
                    }
                }
            }
        }
        

        
    }
}