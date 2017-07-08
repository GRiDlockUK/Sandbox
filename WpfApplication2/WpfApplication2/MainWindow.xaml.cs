using System.Windows;
using System.Windows.Input;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Helper helper = new Helper();

        public MainWindow()
        {
            InitializeComponent();

        }

        private void pnlMainGrid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("You clicked me at " + e.GetPosition(this).ToString());
        }

        private void readFiles()
        {

        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Command == ApplicationCommands.Close)
            {
                textBox1.Text += helper.addendstring("Close Pressed");
                Close();
            }
            if (e.Command == ApplicationCommands.Help)
            {
                textBox1.Text += helper.addendstring("Help Pressed");
                SecondWindow s = new SecondWindow();
                //MainWindow s = new MainWindow();
                s.Show();
            }
            if (e.Command == ApplicationCommands.Open)
            {
                textBox1.Text += helper.addendstring("Open Pressed - " + helper.CurrentLocation);
            }
            if (e.Command == ApplicationCommands.Save)
            {
                textBox1.Text += helper.addendstring("Save Pressed");
            }
        }
    }
}
