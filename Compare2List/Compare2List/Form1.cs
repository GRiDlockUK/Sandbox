using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Compare2List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            // If comparing Want to Swap, we need the duplicates only

            string[] split; 

            split = textBoxWant.Text.Split(',');
            int[] want = new int[split.Length];
            for (int i = 0; i < split.Length; i++)
                want[i] = Convert.ToInt32(split[i].Trim());

            split = textBoxSwap.Text.Split(',');
            int[] swap = new int[split.Length];
            for (int i = 0; i < split.Length; i++)
                swap[i] = Convert.ToInt32(split[i].Trim());

            textBoxResult.Clear();
            foreach (int i in swap)
                if (Array.IndexOf(want, i) > -1)
                    textBoxResult.Text = textBoxResult.Text + i.ToString() + " ";
	
        }

    }
}
