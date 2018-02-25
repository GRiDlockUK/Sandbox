using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LoadMatrixTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string homepath = null;

        public MainWindow()
        {
            InitializeComponent();
            homepath = Environment.GetEnvironmentVariable("homepath");
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {

            DataTable dt = new DataTable();

            // group list example
            string[] _groupList = new string[] { "g1", "g2", "g3" };
            foreach (string _groupName in _groupList)
            {
                dt.Columns.Add(_groupName, typeof(string));
            }

            // user list example
            string[] _userList = new string[] { "u1", "u2", "u3" };
            foreach (string _userName in _userList)
            {
                DataRow row = dt.NewRow();
                row[0] = _userName;
                row[1] = _userName;
                row[2] = _userName;
                dt.Rows.Add(row);
            }


            //load data
            string[] lines = System.IO.File.ReadAllLines(homepath + @"\OneDrive\GitHub\Sandbox\LoadMatrixTest\exampledata2.txt");

            // example with dictionary
            var dict = new Dictionary<string, string>();
            foreach (string line in lines)
            {
                string[] sections = line.Split(';');
                dict.Add(sections[0],sections[1]);
            }

            foreach (KeyValuePair<string, string> entry in dict)
            {
                List<string> users = entry.Value.Split(',').ToList<string>();
                foreach (string user in users)
                {
                    DataRow dataRow = dt.NewRow();
                    dataRow[0] = "user";
                    dataRow[1] = user;
                    dt.Rows.Add(dataRow);

                }
            }

            dataGrid.ItemsSource = dt.DefaultView;
        }

     public class _groupUserData
     {
         public string group { get; set; }
         public List<string> user { get; set; }

         public _groupUserData(string gp, List<string> us)
         {
             this.group = gp;
             this.user = us;
         }

         public string returnCSV()
         {
             //return "\"" + this.user + "\",\"" + this.group + "\"";
             return null;
         }


     }
    }
    





}
