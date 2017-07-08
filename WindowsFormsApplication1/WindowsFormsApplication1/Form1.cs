using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tmrHeartbeat_Tick(object sender, EventArgs e)
        {
            txtStatus.Text += "..ping ";
            if (progressBar1.Value <= 90)
            {
                progressBar1.Value += 10;                
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string path = ConfigurationManager.AppSettings["HomeFolder"];
            txtStatus.Text += "..load " + path;

            treeView1.Nodes.Clear();

            string[] dirs = Directory.GetDirectories(path);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            txtStatus.Text += "..save ";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (tmrHeartbeat.Enabled)
            {
                tmrHeartbeat.Enabled = false;
                txtStatus.Text += "..timer off ";
            }
            else
            {
                tmrHeartbeat.Enabled = true;
                txtStatus.Text += "..timer on ";
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        public static TreeNode MakeTreeFromPaths(List<string> paths, string rootNodeName = "", char separator = '/')
        {
            var rootNode = new TreeNode(rootNodeName);
            foreach (var path in paths.Where(x => !string.IsNullOrEmpty(x.Trim())))
            {
                var currentNode = rootNode;
                var pathItems = path.Split(separator);
                foreach (var item in pathItems)
                {
                    var tmp = currentNode.Nodes.Cast<TreeNode>().Where(x => x.Text.Equals(item));
                    currentNode = tmp.Count() > 0 ? tmp.Single() : currentNode.Nodes.Add(item);
                }
            }
            return rootNode;
        }

    }
}
