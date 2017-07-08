using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sandbox_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = BlahString("testing",5);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string BlahString(string input, int count)
        {
            string blah = input;
            for (int i = 0; i < count -1; i++)
            {
                blah = blah + " " + input;
            }
            return blah;
        }
    }

    public class Graham
    {
        public void Test123()
        {

        }
    }


}
