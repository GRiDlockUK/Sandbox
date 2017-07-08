using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameIsolation
{

    public partial class Form1 : Form
    {

        #region Class

        public class BoardLoc
        {
            public int row, col;
            public BoardLoc(int row, int col)
            {
                this.row = row;
                this.col = col;
            }
            public int TileNumber()
            {
                return (row - 1) * colcount + col - 1;
            }
            public override string ToString()
            {
                return "(" + row.ToString() + "," + col.ToString() + ")";
            }
        }

        public class Player
        {
            public int level; // 0 = Human, 1+ Computer Level
            public char tile;
            public BoardLoc home, poss;
            public Player(char tile, int row, int col, int level)
            {
                this.tile = tile;
                BoardLoc loc = new BoardLoc(row, col);
                this.poss = loc;
                this.home = loc;
                this.level = level;
            } 
        }

        public enum TileType { free, pushed, home, player };

        public class Tile
        {
            public BoardLoc poss;
            public char token;
            public TileType tiletype;
            public Tile(BoardLoc loc, char token, TileType tiletype)
            {
                this.poss = loc;
                this.token = token;
                this.tiletype = tiletype;
            }
        }

        #endregion

        #region Init

        // declaration
        const int rowcount = 6, colcount = 8, tilecount = rowcount * colcount;
        const char tokenfree = ' ', tokenpush = 'X', tokenhome = '#';
        const int tilesize = 50;
        bool movemode = true, gameover = false;

        // init players
        Player[] PlayerArray = new Player[2];
        int currentplayer = 0;

        // init tiles
        Tile[] TileArray = new Tile[tilecount];
        Button[] ButtonArray = new Button[tilecount];

        #endregion

        public Form1()
        {
            InitializeComponent();
        }
  
        private void Form1_Load(object sender, EventArgs e)
        {
            setupBoard();
            displayAction();
        }

        private void setupBoard()
        {
            // initialise all tiles as free tiles
            for (int row = 1; row < rowcount + 1; row++)
            {
                for (int col = 1; col < colcount + 1; col++)
                {
                    BoardLoc loc = new BoardLoc(row, col);
                    TileArray[loc.TileNumber()] = new Tile(loc, tokenfree, TileType.free);
                }
            }

            // initialise players
            PlayerArray[0] = new Player('A', 3, 1, 0);
            PlayerArray[1] = new Player('B', rowcount - 2, colcount, 0);
            foreach (Player PlayerRef in PlayerArray)
            {
                int t = PlayerRef.poss.TileNumber();
                TileArray[t].tiletype = TileType.player;
                TileArray[t].token = PlayerRef.tile;
            }

            // define board size
            this.Size = new Size(colcount * tilesize + 35, rowcount * tilesize + 120);

            int i = 0;
            foreach (Tile tile in TileArray)
            {
                ButtonArray[i] = new Button();
                ButtonArray[i].Name = i.ToString();
                ButtonArray[i].Text = tile.token.ToString();
                ButtonArray[i].Font = new Font("Berlin Sans FB", 20);
                //ButtonArray[i].BackColor = Color.Blue;
                //ButtonArray[i].ForeColor = Color.Beige;
                ButtonArray[i].Width = tilesize - 1;
                ButtonArray[i].Height = tilesize - 1;
                ButtonArray[i].Location = new Point((tile.poss.col - 1) * tilesize + 10, (tile.poss.row -1) * tilesize + 10);
                ButtonArray[i].Enabled = true;
                ButtonArray[i].Visible = true;
                ButtonArray[i].Click += btntile_Click;
                this.Controls.Add(ButtonArray[i]);

                i++;
            }

            // position label
            labelAction.Location = new Point(10, rowcount * tilesize + 20);
        }

        private void displayAction()
        {
            if (gameover)
                endGame();

            else
            {
                if (movemode)  // player move
                    labelAction.Text = "Player " + PlayerArray[currentplayer].tile.ToString() + " - Pick move location";
                else  // tile remove
                    labelAction.Text = "Player " + PlayerArray[currentplayer].tile.ToString() + " - Pick tile to remove";
            }
        }

        private void endGame()
        {
            for (int row = 1; row < rowcount + 1; row++)
            {
                for (int col = 1; col < colcount + 1; col++)
                {
                    int t = new BoardLoc(row, col).TileNumber();
                    ButtonArray[t].Click += null;
                }
            }
            labelAction.Text = "Game Over";
        }

        private void btntile_Click(object sender, EventArgs e)
        {
            Button buttonpress = (Button)sender;
            int newloc = Convert.ToInt32(buttonpress.Name);
            int fromloc = PlayerArray[currentplayer].poss.TileNumber();

            if (movemode) // select new location to move to
            {
                if (testTileMove(PlayerArray[currentplayer].poss, TileArray[newloc].poss))
                {
                    movePlayer(fromloc, newloc);
                    movemode = false;
                    displayAction();
                }
            }
            else // select tile to remove
            {
                if (testTilePush(newloc))
                {
                    pressTile(newloc);
                    movemode = true;

                    // check if player has trapped themselves
                    if (testNoMoreMoves(PlayerArray[currentplayer].poss))
                        endGame();

                    changePlayer();

                    // check if next player is trapped themselves
                    if (testNoMoreMoves(PlayerArray[currentplayer].poss))
                        endGame();

                    displayAction();
                }
            }

            resetHomeTiles();

        }

        private void movePlayer(int fromloc, int newloc)
        {
            // change player to new location & update tile
            PlayerArray[currentplayer].poss = TileArray[newloc].poss;
            TileArray[newloc].token = PlayerArray[currentplayer].tile;
            TileArray[newloc].tiletype = TileType.player;
            ButtonArray[newloc].Text = TileArray[newloc].token.ToString();
            //Buttonarray[newloc].BackColor = Color.Black;

            // amend previous location
            TileArray[fromloc].tiletype = TileType.free;
            TileArray[fromloc].token = tokenfree;
            ButtonArray[fromloc].Text = TileArray[fromloc].token.ToString();
            //buttonarray[newloc].BackColor = Color.Blue;
        }

        private void pressTile(int newloc)
        {
            // change player to new location & update tile
            TileArray[newloc].tiletype = TileType.pushed;
            TileArray[newloc].token = tokenpush;
            ButtonArray[newloc].Text = TileArray[newloc].token.ToString();
            ButtonArray[newloc].Visible = false;
        }



        private void resetHomeTiles()
        {
            foreach (Player p in PlayerArray)
            {
                int hometile = p.home.TileNumber();
                if (TileArray[hometile].token == tokenfree)
                {
                    TileArray[hometile].tiletype = TileType.home;
                    TileArray[hometile].token = tokenhome;
                    ButtonArray[hometile].Text = tokenhome.ToString();
                }
            }
        }

        private void changePlayer()
        {
            if (currentplayer == 0)
                currentplayer = 1;
            else
                currentplayer = 0;
        }


        private bool testTileMove(BoardLoc posFrom, BoardLoc posTo)
        {
            // check new position is directly adjacent before checking if valid tile move
            int rowDiff = Math.Abs(posFrom.row - posTo.row);
            int colDiff = Math.Abs(posFrom.col - posTo.col);
            if ((rowDiff > 1 || colDiff > 1) || (rowDiff == 0 && colDiff == 0))
                return false;
            else
                return testTileMove(posTo.TileNumber());
        }

        private bool testTileMove(int tile)
        {
            // check tile is free or a home base
            if (tile >= 0 && tile <= tilecount && (TileArray[tile].tiletype == TileType.free || TileArray[tile].tiletype == TileType.home))
                return true;
            else
                return false;
        }

        private bool testTilePush(int tile)
        {
            // check tile is free
            if (tile >= 0 && tile <= tilecount && TileArray[tile].tiletype == TileType.free)
                return true;
            else
                return false;
        }
        
        private bool testNoMoreMoves(BoardLoc posFrom)
        {
            // return true if no more moves...
            int moves = 0;

            if (testMoveAllowed(posFrom, posFrom.row - 1, posFrom.col - 1))
                moves = moves + 1;
            if (testMoveAllowed(posFrom, posFrom.row - 1, posFrom.col))
                moves = moves + 1;
            if (testMoveAllowed(posFrom, posFrom.row - 1, posFrom.col + 1))
                moves = moves + 1;

            if (testMoveAllowed(posFrom, posFrom.row, posFrom.col - 1))
                moves = moves + 1;
            if (testMoveAllowed(posFrom, posFrom.row, posFrom.col + 1))
                moves = moves + 1;

            if (testMoveAllowed(posFrom, posFrom.row + 1, posFrom.col - 1))
                moves = moves + 1;
            if (testMoveAllowed(posFrom, posFrom.row + 1, posFrom.col))
                moves = moves + 1;
            if (testMoveAllowed(posFrom, posFrom.row + 1, posFrom.col + 1))
                moves = moves + 1;

            //MessageBox.Show("Player: " + currentplayer.ToString() + " - moves " + moves.ToString());

            if (moves > 0)
                return false;
            else
            {
                gameover = true;
                return true;
            }
 
        }

        private bool testMoveAllowed(BoardLoc posFrom, int newRow, int newCol)
        {
            // check still within the board
            if (newRow < 1 || newRow > rowcount || newCol < 1 || newCol > colcount)
                return false; // invalid move
            else
            {
                if (testTileMove(new BoardLoc(newRow, newCol).TileNumber()))
                    return true; // valid move
                else
                    return false; // invalid move
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button buttonpress = (Button)sender;
            int newloc = Convert.ToInt32(buttonpress.Name);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PRESSED");
        }

    }

}