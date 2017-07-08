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

namespace FILM_COMPARE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Clear();

            string[] filenames = Directory.GetFiles(textBox1.Text);
            //foreach (var f in filenames)
            //{
            //    listView1.Items.Add(f);
            //}
            //listView1.Items.AddRange(filenames);
            listBox1.Items.AddRange(filenames);
        }
    }
}
