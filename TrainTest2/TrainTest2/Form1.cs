using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainTest2.ServiceReferenceLDB;

namespace TrainTest2
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

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //StationBoard GetDepartureBoard(numRows, crs, filterCrs, filterType)
            //StationBoard GetArrivalBoard(numRows, crs, filterCrs, filterType)
            //StationBoard GetArrivalDepartureBoard(numRows, crs, filterCrs, filterType)
            //ServiceDetails GetServiceDetails(serviceID)


        }
    }
}
