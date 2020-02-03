namespace minesweeper
{
    public class Tile
    {
        public Tile(bool flag, bool hidden, int tileValue, int row, int col)
        {
            this.Flag = flag;
            this.Hidden = hidden;
            this.TileValue = tileValue;
            this.Row = row;
            this.Col = col;
        }

        public int Row { get; set; }
        public int Col { get; set; }
        public int TileValue { get; set; }
        public bool Hidden { get; set; }
        public bool Flag { get; set; }
    }
}