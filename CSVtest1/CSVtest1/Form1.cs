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
using FileHelpers;

namespace CSVtest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void diag(string output)
        {
            tbOUTPUT.AppendText(DateTime.Now.ToString() + " -- " + output + Environment.NewLine);
        }

        private void btnLOAD_Click(object sender, EventArgs e)
        {
            diag("load start");

            //Prompt for CSV file
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"D:\TEMP\";
            dialog.Filter = "CSV file (*.csv)|*.csv|All Files (*.*)|*.*";
            dialog.Title = "Select the CSV file";

            //Process if file selected
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                diag("selected file - " + dialog.FileName);

                var engine = new FileHelperEngine<data>();
                var result = engine.ReadFile(dialog.FileName);

                foreach(var d in result)
                {
                        diag(d.first);
                        diag(d.last);
                        diag(d.gender);
                        diag(d.age);
                }

            }

            diag("load end");
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            diag("go start");
            diag("go end");
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    [DelimitedRecord(",")]
    public class data
    {
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string first;

        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string last;

        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string gender;

        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        public string age;
    }

}

