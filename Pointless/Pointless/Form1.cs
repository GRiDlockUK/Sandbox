using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pointless
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            tbMain.Text = "label click from testing";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tbMain.Text = "start";
            tbMain.Text = tbMain.Text + "...";
            tbMain.Text = tbMain.Text + "...";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbMain_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
