using System;
using System.Collections.Generic;

namespace minesweeper
{
    internal class MineField
    {
        private int numberOfRows;
        private int numberOfColumns;
        private int numberOfMines;
        private int[,] minefield;
        private List<Mine> mines = new List<Mine>(); 

        public MineField(int numberOfRows, int numberOfColumns, int numberOfMines)
        {
            this.numberOfRows = numberOfRows;
            this.numberOfColumns = numberOfColumns;
            this.numberOfMines = numberOfMines;
        }

        public int[,] Minefield { get => minefield; set => minefield = value; }

        public void PlaceMines()
        {
            Minefield = new int[numberOfRows, numberOfColumns];

            
           
            Random random = new Random();
            int mineCounter = numberOfMines;
            while (mineCounter > 0)
            {
                
                int mineRowCordinate = random.Next(numberOfRows);
                int mineColumnCordinate = random.Next(numberOfColumns);

                int cordinateValue = Minefield[mineRowCordinate, mineColumnCordinate];
                if (cordinateValue < 0) { continue; }

                Minefield[mineRowCordinate, mineColumnCordinate] = -10;
                mines.Add(new Mine(mineRowCordinate, mineColumnCordinate));
                mineCounter--;

            }
        }

        public void PlaceNumbers()
        {
            foreach(Mine mine in mines)
            {
                int rowCord = mine.MineRowCordinate;
                int colCord = mine.MineColumnCordinate;

                for (int i = rowCord-1; i<rowCord+1; i++)
                {
                    for (int j = colCord - 1; j < colCord + 1; j++)
                    {
                       
                        if (i < 0 || i > numberOfRows) { continue; }
                        if (j < 0 || j > numberOfColumns) { continue; }

                        Minefield[i, j]++;
                    }
                }
            }
        }
        

        
    }
}