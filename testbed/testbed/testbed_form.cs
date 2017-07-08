using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testbed
{
    public partial class testbed_form : Form
    {

        bool firstcalltoAPI = true;

        public testbed_form()
        {
            InitializeComponent();
        }

        private void testbed_form_Load(object sender, EventArgs e)
        {

            write("start");
        }

        public void write(string s)
        {
            textBox1.Text = textBox1.Text + "\r\n" + DateTime.Now.ToString() + "  -- " + s;
            textBox1.Update();
        }

        private void btnEbayTime_Click(object sender, EventArgs e)
        {
            if (firstcalltoAPI)
            {
                write("Calling EBAY api - first call will take longer");
                firstcalltoAPI = false;
            }
            else
            {
                write("Calling EBAY api");
            }
            write(testbed.com.ebay.developer.GeteBayOfficialTime.ebaytime());
            write("Done");
        }

        private void btnNRE1_Click(object sender, EventArgs e)
        {
            write("Calling NRE api");
            write(testbed.uk.co.nationalrail.realtime.lite.testcl.testmt());
            write("Done");
        }

        private void btnWebservCCY_Click(object sender, EventArgs e)
        {
            write("Calling Webservices CCY api");
            write(testbed.net.webservicex.www.testcl.testmt());
            write("Done");
        }
    }

}
