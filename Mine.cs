namespace minesweeper
{
    internal class Mine
    {
        public int MineRowCordinate { get; set; }
        public int MineColumnCordinate { get; set; }

        public Mine(int mineRowCordinate, int mineColumnCordinate)
        {
            this.MineRowCordinate = mineRowCordinate;
            this.MineColumnCordinate = mineColumnCordinate;
        }


    }
}