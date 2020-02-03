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

            Tile[,] gameRepresentation = mineField.HiddenBoard;








        }

    }
}

