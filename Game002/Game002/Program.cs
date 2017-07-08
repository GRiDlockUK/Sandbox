using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game002
{
    public class Location
    {
        public int row;
        public int col;
    }

    class Player
    {
        public char tile { get; set; }
        public Location currpos;
        public Location homepos;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //setup
	        const int Playercount = 2, boardrows = 6, boardcols = 8; // please use minimum 5 x 5
	        const char freetile = '.', pushtile = ' ', hometile = 'o';
            char[,] board = new char[boardrows, boardcols]; 
            int currentPlayer = 0, moveinput, moverow, movecol;


            Location l = new Location();

            Player Graham = new Player();
            Graham.tile = 'A';

            Player[] P1 = new Player[Playercount];

                //P1[0].tile = 'A';
                //    l.row = 2;
                //    l.col = 0;
                //P1[0].currpos = l;
                //P1[0].homepos = l;

                //P1[1].tile = 'B';
                //    l.row = boardrows - 3;
                //    l.col = boardcols - 1;
                //P1[1].currpos = l;
                //P1[1].homepos = l;

            // init board
            for (int row = 0; row < boardrows; ++row)
            {
                for (int col = 0; col < boardcols; ++col)
                {
                    board[row,col] = freetile;
                }
            }

        }
    }
}
