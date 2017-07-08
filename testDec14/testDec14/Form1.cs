using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace testDec14
{
    public partial class Form1 : Form
    {
        public const string newline = "\r\n";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Log("Start");

            string[] filelist = Directory.GetFiles("D:\\TEMP\\");
            foreach (string filename in filelist)
	        {
                textBox1.Text += filename + newline;
        	}


            Log("End");

        }

        private void Log(string t)
        {
            textBox3.Text += DateTime.Now + " - " + t + newline;

        } 
    }
}
