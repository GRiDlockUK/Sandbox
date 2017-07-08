using System.Windows;
using System.Windows.Input;
using System.IO;
using System.Reflection;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.MainHeading.Content = CurrentLocation;

            var appViewModel = new ApplicationVM(Dispatcher);
            DataContext = appViewModel;

        }

        public static string CurrentLocation
        {
            get
            {
                var fileInfo = new FileInfo(Assembly.GetExecutingAssembly().Location);
                return fileInfo.DirectoryName;
            }
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Command == ApplicationCommands.Close)
            {
                Close();
            }
        }
    }
}
