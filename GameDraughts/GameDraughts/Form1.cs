using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameDraughts
{
    public partial class Form1 : Form
    {
        public class tile
        {
            public loc tileloc;
            public char tilestate;
            public tile(int c, int r)
            {
                this.tilestate = ' ';
                this.tileloc = new loc(c, r);
            }

        }

        public class player
        {
            public int playernumber;
            public loc playerloc;
            public player(int n, loc l)
            {
                this.playernumber = n;
                this.playerloc = l;
            }
        }

        public class loc
        {
            public int col, row;
            public loc(int c, int r)
            {
                this.col = c;
                this.row = r;
            }
            public override string ToString()
            {
                return "("+ col.ToString() + "," + row.ToString() + ")";
            }
        }
    
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Start();
        }

        public void Start()
        {

            diag("setup players");
            int playercount = 2;

            player[] playerarray = new player[playercount];
            //            playerarray[0].playernumber = 0;
            //            playerarray[0].playerloc = new loc(0,0);
            //            playerarray[1].playernumber = 1;
            //            playerarray[0].playerloc = new loc(maxx,maxy);

            diag("setup tiles");
            int maxcol = 8, maxrow = 8, tilecount = maxrow * maxcol;
            tile[] tilearray = new tile[tilecount];
            for (int row = 0; row < maxrow; row++)
            {
                for (int col = 0; col < maxcol; col++)
                {
                    int tilenumber = calcTileNumber(row, col, maxcol);
                    tilearray[tilenumber] = new tile(col, row);
                }
            }

            diag("draw board");
            Button[] buttonArray = new Button[tilecount];
            int i = 0, btnsize = 50;
            foreach (tile t in tilearray)
            {
                buttonArray[i] = new Button();
                buttonArray[i].Size = new Size(btnsize, btnsize);
                buttonArray[i].Name = "" + i + "";
                buttonArray[i].Click += btn_Click;
                buttonArray[i].Location = new Point((t.tileloc.col * btnsize), (t.tileloc.row * btnsize));
                Controls.Add(buttonArray[i]);

                i++;

            }
        }

        private void btn_Click(object sender, EventArgs e)
        {

        }

        private int calcTileNumber(int row, int col, int maxcol)
        {
            return (row * maxcol) + col;
        }

        private void diag(string s)
        {
            txtDialog.Text = txtDialog.Text + s + "\r\n";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

    }
}
