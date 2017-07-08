using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Isolation
{
    public partial class Form1 : Form
    {

        string[] Board;
        int[] Player;
        Play PlayerOne = new Play();
        Play PlayerTwo;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
 
            InitialiseBoard(48);

            PlayerOne.Name = "Graham";
            PlayerOne.Position = 17;
            PlayerOne.Colour = "Blue";
            Board[PlayerOne.Position] = "1";

            Play PlayerTwo = new Play();
            PlayerTwo.Name = "Lorraine";
            PlayerTwo.Position = 30;
            Board[PlayerTwo.Position] = "2";

            Board[22] = "Y";

            PrintBoard();

        }

        private void PrintBoard()
        {
            string result = "";
            int count = 0;
            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col < 8 ; col++)
                {   
                    result = result + Board[count];
                    count += 1;
                }
                result = result + "\n";
            }
            labelGameArea.Text = result;
        }

        private void InitialiseBoard(int BoardSize)
        {
            Board = new string[BoardSize];
            for (int i = 0; i < BoardSize; i++)
            {
                Board[i] = "O";
            }
            Board[16] = "H";
            Board[31] = "H";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int PosNext = PlayerOne.Position +1;

            if (Board[PosNext] == "O")
            {
                Board[PosNext] = "1";
                Board[PlayerOne.Position] = "X";
                PlayerOne.Position = PosNext;
                PrintBoard();
            }
            else
            {
                MessageBox.Show("You cannot move into that location because it contains : " + Board[PosNext],"Error");
            }


            //PlayerOne.CheckPlayer(PosNext);
            //PlayerOne.MovePlayer(PosNext);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
 
    }

    public class Play
    {
        
        public string Name { get; set; }
        public int Position { get; set; }
        public string Colour { get; set; }
        public int GamesWon { get; set; }

        public void CheckPlayer(int Location)
        {
        }

        //public string  MovePlayer(int Location)
        //{
        //}


    }

}
