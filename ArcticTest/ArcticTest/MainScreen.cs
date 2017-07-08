using System;
using System.Collections.Generic;
//using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//using System.Text;
//using System.Xml;
using System.Xml.Linq;
//using System.Xml.Serialization;
//using System.IO;
using System.Windows.Forms;

namespace ArcticTest
{
    public partial class ArcticTest : Form
    {
        //class FormTwo
        //{
        //    internal static EditPosition FormTwo;
        //}

        // declare structures -----

        public enum Direction
        { North, South, East, West, Up, Down };

        public class Position
        {
            public int index;
            public string desc;
            public Position()
            { }
            public Position(int i, string de)
            {
                index = i;
                desc = de;
            }
        }

        public class Item
        {
            public int index;
            public int pos;
            public string desc;
            public bool enabled;
            public Item()
            { }
            public Item(int i, int po, string de, bool en)
            {
                index = i;
                pos = po;
                desc = de;
                enabled = en;
            }
        }

        public class Route
        {
            public int index;
            public int pos;
            public Direction dir;
            public int dest;
            public bool enabled;
            public Route()
            { }
            public Route(int i, int po, Direction di, int de, bool en)
            {
                index = i;
                pos = po;
                dir = di;
                dest = de;
                enabled = en;
            }
        }

        public class Action
        {
            public int index;
            public int pos;
            public string desc;
            public string button;
            public int actionitem;
            public int actionroute;
            public int actionaction;
            public string result;
            public bool endgame;
            public bool enabled;
            public Action()
            { }
            public Action(int i, int po, string de, string bu, int it, int ro, int ac, string re, bool eg, bool en)
            {
                index = i;
                pos = po;
                desc = de;
                button = bu;
                actionitem = it;
                actionroute = ro;
                actionaction = ac;
                result = re;
                endgame = eg;
                enabled = en;
            }
        }

        public class Testing
        {
            public int test01;
            public string test02;
            public Testing()
            { }
            public Testing(int i, string s)
            {
                test01 = i;
                test02 = s;
            }
        }

        // declare variables ------

        public int curpos;
        public string lastaction;
        public bool editmodeflag;

        public static List<Position> Positions = new List<Position>();
        public List<Item> Items = new List<Item>();
        public List<Route> Routes = new List<Route>();
        public List<Action> Actions = new List<Action>();

        // Start point -----    

        public ArcticTest()
        {
            InitializeComponent();
            EditPosition.frm2 = new EditPosition();
        }

        private void ArcticTest_Load(object sender, EventArgs e)
        {
            startGame();
        }

        public void startGame()
        {
            curpos = 1;
            lastaction = null;
            setEditMode(false);

            clearDebug();
            clearMain();

            loadXML("data.xml");
            displayLocation();


        }

        public void loadXML(string file)
        {
            writeDebug("loadxml into the Class Arrays");

            XDocument doc = XDocument.Load(file);

            Positions =
                (from e in doc.Root.Elements("position")
                 select new Position
                 {
                     index = Int32.Parse(e.Element("index").Value),
                     desc = (string)e.Element("desc")
                 }).ToList();

            Items =
                (from e in doc.Root.Elements("item")
                 select new Item
                 {
                     index = Int32.Parse(e.Element("index").Value),
                     pos = Int32.Parse(e.Element("pos").Value),
                     desc = e.Element("desc").Value,
                     enabled = bool.Parse(e.Element("enabled").Value)
                 }).ToList();

            Routes =
                 (from e in doc.Root.Elements("route")
                  select new Route
                  {
                      index = Int32.Parse(e.Element("index").Value),
                      pos = Int32.Parse(e.Element("pos").Value),
                      dir = ((Direction)Enum.Parse(typeof(Direction), e.Element("dir").Value)),
                      dest = Int32.Parse(e.Element("dest").Value),
                      enabled = bool.Parse(e.Element("enabled").Value)
                  }).ToList();

            Actions =
                 (from e in doc.Root.Elements("action")
                  select new Action
                  {
                      index = Int32.Parse(e.Element("index").Value),
                      pos = Int32.Parse(e.Element("pos").Value),
                      desc = e.Element("desc").Value,
                      button = e.Element("button").Value,
                      actionitem = Int32.Parse(e.Element("actionitem").Value),
                      actionroute = Int32.Parse(e.Element("actionroute").Value),
                      actionaction = Int32.Parse(e.Element("actionaction").Value),
                      result = e.Element("result").Value,
                      endgame = bool.Parse(e.Element("endgame").Value),
                      enabled = bool.Parse(e.Element("enabled").Value)
                  }).ToList();

        }

        public void saveXML(string file)
        {
            writeDebug("savexml to " + file);

            XElement data = new XElement("data");

            foreach (Position p in Positions)
            {
                XElement section = new XElement("position");
                section.Add(new XElement("index", p.index));
                section.Add(new XElement("desc", p.desc));
                data.Add(section);
            }

            foreach (Item i in Items)
            {
                XElement section = new XElement("item");
                section.Add(new XElement("index", i.index));
                section.Add(new XElement("pos", i.pos));
                section.Add(new XElement("desc", i.desc));
                section.Add(new XElement("enabled", i.enabled));
                data.Add(section);
            }

            foreach (Route r in Routes)
            {
                XElement section = new XElement("route");
                section.Add(new XElement("index", r.index));
                section.Add(new XElement("pos", r.pos));
                section.Add(new XElement("dir", r.dir));
                section.Add(new XElement("dest", r.dest));
                section.Add(new XElement("enabled", r.enabled));
                data.Add(section);
            }

            foreach (Action a in Actions)
            {
                XElement section = new XElement("action");
                section.Add(new XElement("index", a.index));
                section.Add(new XElement("pos", a.pos));
                section.Add(new XElement("desc", a.desc));
                section.Add(new XElement("button", a.button));
                section.Add(new XElement("actionitem", a.actionitem));
                section.Add(new XElement("actionroute", a.actionroute));
                section.Add(new XElement("actionaction", a.actionaction));
                section.Add(new XElement("result", a.result));
                section.Add(new XElement("endgame", a.endgame));
                section.Add(new XElement("enabled", a.enabled));
                data.Add(section);
            }

            data.Save(file);

        }

        public void RefreshListBoxes()
        {
            listBox1.Items.Clear();
            foreach (Position p in Positions)
                listBox1.Items.Add(p.index.ToString() + "; " + p.desc);
            listBox2.Items.Clear();
            foreach (Item i in Items)
                listBox2.Items.Add(i.index.ToString() + "; " + i.pos.ToString() + "; " + i.desc + "; " + i.enabled.ToString());
            listBox3.Items.Clear();
            foreach (Route r in Routes)
                listBox3.Items.Add(r.index.ToString() + "; " + r.pos.ToString() + "; " + r.dir.ToString() + "; " + r.dest.ToString() + "; " + r.enabled.ToString());
            listBox4.Items.Clear();
            foreach (Action a in Actions)
                listBox4.Items.Add(a.index.ToString() + "; " + a.pos.ToString() + "; " + a.desc + "; " + a.button + "; " + a.actionitem.ToString() + "; "
                    + a.actionroute.ToString() + "; " + a.actionaction.ToString() + "; " + a.endgame.ToString() + "; " + a.enabled.ToString());
        }

        public void displayLocation()
        {
            writeDebug("displayLocation - Curpos = " + curpos.ToString());

            displayDescription();
            displayDirections();
            displayItems();
            displayActions();
            RefreshListBoxes();

        }
        public void displayDescription()
        {
            writeDebug("displayDescription");
            clearMain();
            if (lastaction != null)
            {
                writeMain(lastaction + "\r\n");
                lastaction = null;
            }

            writeMain("You are in " + Positions[curpos].desc + "\r\n");
        }
        public void displayDirections()
        {
            writeDebug("displayDirections");

            buttonNorth.Enabled = false;
            buttonEast.Enabled = false;
            buttonSouth.Enabled = false;
            buttonWest.Enabled = false;
            buttonUp.Enabled = false;
            buttonDown.Enabled = false;

            string s = null;
            foreach (Route r in Routes)
            {
                if (r.pos == curpos && r.enabled)
                {
                    s = s + "\r\n  " + r.dir;

                    switch (r.dir)
                    {
                        case Direction.North:
                            buttonNorth.Enabled = true; ;
                            break;
                        case Direction.South:
                            buttonSouth.Enabled = true;
                            break;
                        case Direction.East:
                            buttonEast.Enabled = true;
                            break;
                        case Direction.West:
                            buttonWest.Enabled = true;
                            break;
                        case Direction.Up:
                            buttonUp.Enabled = true;
                            break;
                        case Direction.Down:
                            buttonDown.Enabled = true;
                            break;
                    }

                }
            }

            if (s != null)
            {
                s = "Exits are available to " + s + "\r\n";
            }
            else
            {
                s = "You are trapped -- Game over \r\n";
            }
            writeMain(s);
        }
        public void displayItems()
        {
            writeDebug("displayItems");
            string s = null;

            foreach (Item i in Items)
            {
                if (i.pos == curpos && i.enabled)
                {
                    s = s + "\r\n  " + i.desc;
                }
            }

            if (s != null)
            {
                s = "Items here include " + s + "\r\n";
            }
            writeMain(s);
        }
        public void displayActions()
        {
            writeDebug("displayActions");

            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;

            foreach (Action a in Actions)
            {
                if (a.pos == curpos && a.enabled)
                {
                    button2.Text = a.desc;
                    button2.Visible = true;
                }
            }

        }

        public void writeMain(string s)
        {
            textMain.Text = textMain.Text + s + "\r\n";
        }
        public void clearMain()
        {
            textMain.Text = "";
        }
        public void writeDebug(string s)
        {
            textDebug.Text = s + "\r\n" + textDebug.Text;
        }
        public void clearDebug()
        {
            textDebug.Text = "";
        }
        public void write(string s, TextBox t)
        {
            t.Text = t.Text + s + "\r\n";
        }

        private void buttonNorth_Click(object sender, EventArgs e)
        {
            writeDebug("buttonNorth");
            buttonDir(Direction.North);
            displayLocation();
        }
        private void buttonEast_Click(object sender, EventArgs e)
        {
            writeDebug("buttonEast");
            buttonDir(Direction.East);
            displayLocation();
        }
        private void buttonSouth_Click(object sender, EventArgs e)
        {
            writeDebug("buttonSouth");
            buttonDir(Direction.South);
            displayLocation();
        }
        private void buttonWest_Click(object sender, EventArgs e)
        {
            writeDebug("buttonWest");
            buttonDir(Direction.West);
            displayLocation();
        }
        private void buttonUp_Click(object sender, EventArgs e)
        {
            writeDebug("buttonUp");
            buttonDir(Direction.Up);
            displayLocation();
        }
        private void buttonDown_Click(object sender, EventArgs e)
        {
            writeDebug("buttonDown");
            buttonDir(Direction.Down);
            displayLocation();
        }
        private void buttonDir(Direction di)
        {
            foreach (Route r in Routes)
            {
                if (r.pos == curpos && r.dir == di)
                {
                    curpos = r.dest;
                    break;
                }
            }
        }

        private void btnMode_Click(object sender, EventArgs e)
        {
            setEditMode(!editmodeflag);
        }

        private void setEditMode(bool b)
        {
            editmodeflag = b;

            // change the visibility
            groupBox1.Enabled = editmodeflag;
            groupBox1.Visible = editmodeflag;

            if (editmodeflag)
            {
                btnMode.Text = "Save XML";
            }
            else
            {
                // save when switching off edit mode
                saveXML("data2.xml");
                btnMode.Text = "Enable Edit";
            }

        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            startGame();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Action a in Actions)
            {
                if (a.pos == curpos && a.enabled)
                {
                    a.enabled = false;
                    Items[a.actionitem].enabled = false;
                    Items[a.actionitem].enabled = false;
                    Actions[a.actionaction].enabled = true;
                    Routes[a.actionroute].enabled = true;
                    lastaction = a.result;
                }
            }
            displayLocation();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditPosition.frm2.Show();
        }

        private void btnAddPosition_Click(object sender, EventArgs e)
        {
            if (textPositionDescription.Text != "")
            {
                Position p = new Position(Positions.Count, textPositionDescription.Text);
                Positions.Add(p);
                RefreshListBoxes();
            }
        }
    }
}
