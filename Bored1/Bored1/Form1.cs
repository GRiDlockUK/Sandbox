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

namespace Bored1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            OpenFileDialog fd = new OpenFileDialog();
                fd.InitialDirectory = "c:\\";
                fd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                fd.FilterIndex = 2;
                fd.RestoreDirectory = true;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtFileContent.Text = File.ReadAllText(fd.FileName);
                    txtFileName.Text = fd.FileName;
                }
                catch (IOException)
                {
                }
            }

        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {

            SaveFileDialog fd = new SaveFileDialog();
            fd.InitialDirectory = "c:\\";
            fd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            fd.FilterIndex = 2;
            fd.RestoreDirectory = true;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(fd.FileName, txtFileContent.Text);
                    txtFileName.Text = fd.FileName;
                }
                catch (IOException)
                {
                }
            }
        }


    }
}
