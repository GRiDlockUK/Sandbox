using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace ArcticTest
{
    public partial class EditPosition : Form
    {
        public static EditPosition frm2;
        public EditPosition()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditPosition_Load(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Drawing.Graphics graphicsObj;
            graphicsObj = this.CreateGraphics();
            Pen myPen = new Pen(System.Drawing.Color.Red, 3);


            foreach (ArcticTest.Position p in ArcticTest.Positions)
                graphicsObj.DrawRectangle(myPen, 200, 10 + 20*p.index, 50, 10);

        }
    }
}
