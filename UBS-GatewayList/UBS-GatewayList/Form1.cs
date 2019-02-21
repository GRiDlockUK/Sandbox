using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace GatewayList
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
            // TEMP code
            //int datacount = 1;
            //datarecord[] dr = new datarecord[150];

            //dr[datacount] = new datarecord();
            //dr[datacount].Gateway = "London";
            //dr[datacount].Fundname = "ABCDE";

            // REM load data for Gateways and Funds

            String[] gateways = new String[] { "London", "Chicago", "Kettering" }; // load from INI
            String[] funds = new String[] { "fund1", "fund2", "fund3", "fund4" }; // load from INI

            //foreach (string s in gateways)
            //{
            //    TreeNode treeNode = new TreeNode(s.ToUpper());
            //    treeView1.Nodes.Add(treeNode);
            //    foreach (string t in funds)
            //    {
            //        treeNode.Nodes.Add(s.ToUpper() + "_" + t.ToUpper());
            //    }
            //}

            loadData();

            treeView1.ExpandAll();

            textFund.Text = "";
            addToolStripMenuItem.Text = "Add " + textFund.Text;

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

 
        private void log(string action, string content)
        {
            listBox2.Items.Add(action + ": " + content);
        }


        public class datarecord
        {
            public string Gateway { get; set; }
            public string Fundname { get; set; }

        }


        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String fund = textFund.Text.Trim().ToUpper(); 
            
            if (fund == "")
            {
                log("ERROR", "Fund name is blank");
            }
            else
            {
                TreeNode selectedNode = treeView1.SelectedNode;
                if (selectedNode.Parent == null)
                {
                    selectedNode.Nodes.Add(fund);
                    log("ACTION", "Added fund " + fund + " to " + selectedNode.Text);
                }
                else
                {
                    TreeNode parentNode = selectedNode.Parent;
                    parentNode.Nodes.Add(fund);
                    log("ACTION", "Added fund " + fund + " to " + parentNode.Text);
                }
            }

        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            TreeNode selectedNode = treeView1.SelectedNode;
            if (selectedNode.Parent == null)  
            {
                log("ERROR", "Cannot remove gateway - " + selectedNode.Text);
            } else {
                TreeNode parentNode = selectedNode.Parent;
                selectedNode.Remove();
                log("ACTION", "Removed fund " + selectedNode.Text + " from " + parentNode.Text);
            } 

        }

        private void textFund_TextChanged(object sender, EventArgs e)
        {
            addToolStripMenuItem.Text = "Add " + textFund.Text;
        }

        private void buttonCommit_Click(object sender, EventArgs e)
        {

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.NewLineOnAttributes = true;
            XmlWriter writer = XmlWriter.Create("data.xml", settings);
            using (writer)

            //XmlWriterSettings settings = new XmlWriterSettings();
            //settings.Indent = true;
            //settings.NewLineOnAttributes = true;
            //XmlWriter writer = XmlWriter.Create("books.xml", settings);

            {
                writer.WriteStartDocument();
                writer.WriteStartElement("BloombergGatewayData");

                foreach (TreeNode parentNode in treeView1.Nodes)
                {
                    writer.WriteStartElement(parentNode.Text);
                    foreach (TreeNode childNode in parentNode.Nodes)
                    {
                        writer.WriteElementString("Fund", childNode.Text);
                    }
                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
            
        }

        private void loadData()
        {
            XmlDataDocument xmldoc = new XmlDataDocument();
            XmlNode xmlnode;
            FileStream fs = new FileStream("data.xml", FileMode.Open, FileAccess.Read);
            xmldoc.Load(fs);
            xmlnode = xmldoc.ChildNodes[1];
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add(new TreeNode(xmldoc.DocumentElement.Name));
            TreeNode tNode;
            tNode = treeView1.Nodes[0];
            AddNode(xmlnode, tNode);
        }

        private void AddNode(XmlNode inXmlNode, TreeNode inTreeNode)
        {
            XmlNode xNode;
            TreeNode tNode;
            XmlNodeList nodeList;
            int i = 0;
            if (inXmlNode.HasChildNodes)
            {
                nodeList = inXmlNode.ChildNodes;
                for (i = 0; i <= nodeList.Count - 1; i++)
                {
                    xNode = inXmlNode.ChildNodes[i];
                    inTreeNode.Nodes.Add(new TreeNode(xNode.Name));
                    tNode = inTreeNode.Nodes[i];
                    AddNode(xNode, tNode);
                }
            }
            else
            {
                inTreeNode.Text = inXmlNode.InnerText.ToString();
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            log("INFO", "NodeMouseClick " + e.Node.Text + " (" + e.Node.Nodes.Count + ")");
            if (e.Node.Nodes.Count == 0)
            {
                removeToolStripMenuItem.Text = "Remove " + e.Node.Text;
                removeToolStripMenuItem.Enabled = true;
            }
            else
            {
                removeToolStripMenuItem.Text = "Remove";
                removeToolStripMenuItem.Enabled = false;
            }
            
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }
    }



}
