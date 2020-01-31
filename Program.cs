using System;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

namespace minesweeper
{

    class Program
    {
        static void Main(string[] args)
        {



        }
    }



    public class Minefield
    {
        private int[,] minefield;

        public Minefield(int row, int col, int mines)
        {
        
            minefield = new int[row, col];

            Random rnd = new Random();


            while (mines > 0)
            {
                int xbomb = rnd.Next(row);
                int ybomb = rnd.Next(col);


                int valueXY = minefield[xbomb, ybomb];
                if (valueXY < 0) { continue; }

                minefield[xbomb, ybomb] = -10;
                mines--;
            }
        }
        


  

    }







}
