using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Threading;
using System.Windows.Input;
using System.Runtime.InteropServices;
using System.Reflection;
using System.IO;
using System.Threading;
using System.ComponentModel;

namespace WpfApplication1
{
    class ApplicationVM : ModelBase, IUIService
    {
        private string _statusMessage;
        private string _modalMessage;
        private bool _isUILocked;
        private Dispatcher _dispatcher;
        private object _viewDataContext;

        //--------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        //--------------------------------------------------------------------------------
        public ApplicationVM(Dispatcher dispatcher)
        {
            _dispatcher = dispatcher;

            SelectToolCommand = new RelayCommand((p) => {

                string code = (string)p;

                foreach (var envMenuItem in AvailableTools)
                {
                    envMenuItem.IsChecked = false;
                    if (envMenuItem.Text == (string)p)
                    {
                        envMenuItem.IsChecked = true;
                        switch (envMenuItem.Text)
                        {
                            case "User Management":
                                ViewDataContext = _userManagementVM;
                                break;
                            case "Project Summary":
                                ViewDataContext = _summaryVM;
                                break;
                        }
                    }
                }

            }, (p) => { return true; });

            LogoutCommand = new RelayCommand((p) =>
            {
                ShowLogin();
            }, (p) => { return true; });

            AvailableTools = new List<MenuItemViewModel>();
            AvailableTools.Add(new MenuItemViewModel("User Management", SelectToolCommand, "User Management"));
            AvailableTools.Add(new MenuItemViewModel("Project Summary", SelectToolCommand, "Project Summary"));

            SetupUserStartMenu();
            // Start with Login Page
            ShowLogin();
        }

        //--------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        //--------------------------------------------------------------------------------
        private bool SafeDirectoryCreate(string directoryPath)
        {
            if (Directory.Exists(directoryPath))
            {
                return false;
            }
            else
            {
                Directory.CreateDirectory(directoryPath);
                Thread.Sleep(1000); // Give OS time to complete the command.
                return true;
            }
        }

        //--------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        //--------------------------------------------------------------------------------
        private void SetupUserStartMenu()
        {
            try
            {
                string applicationDataPath = Environment.GetEnvironmentVariable("appdata");
                if (!string.IsNullOrEmpty(applicationDataPath))
                {
                    string currentDirectory = string.Format("{0}{1}", applicationDataPath, @"\Microsoft\Windows\Start Menu\Programs\UBS - AM");
                    SafeDirectoryCreate(currentDirectory);

                    currentDirectory = string.Format("{0}{1}", currentDirectory, @"\TRPA");
                    SafeDirectoryCreate(currentDirectory);
                    var appSettings = JIRA_Utility.Properties.Settings.Default;

                    var linkPath = string.Format("{0}\\{1}.lnk", currentDirectory, "Jira Utility");
                    if (File.Exists(linkPath))
                    {
                        File.Delete(linkPath);
                        Thread.Sleep(1000);
                    }

                    CreateShortcut(linkPath, appSettings.ClickOnceUrl, 0);
                    Thread.Sleep(1000);
                }
            }
            catch
            {
                // Ignore all errors ...
            }
        }

        //--------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        //--------------------------------------------------------------------------------
        private void CreateShortcut(string shortcutPath, string targetPath, int iconIndex)
        {
            // Windows Script Host Shell Object
            Type shellType = Type.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8"));
            dynamic shell = Activator.CreateInstance(shellType);
            try
            {
                var lnk = shell.CreateShortcut(shortcutPath);
                try
                {
                    lnk.TargetPath = targetPath;
                    lnk.IconLocation = string.Format("{0}, {1}", Assembly.GetExecutingAssembly().Location, iconIndex);
                    lnk.Save();
                }
                finally
                {
                    Marshal.FinalReleaseComObject(lnk);
                }
            }
            finally
            {
                Marshal.FinalReleaseComObject(shell);
            }
        }

        //--------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        //--------------------------------------------------------------------------------
        private void ShowLogin()
        {
            //_userManagementVM = new UserManagementVM(this);
            //_summaryVM = new ScreenSummaryVM(this);
            foreach (var envMenuItem in AvailableTools)
            {
                envMenuItem.IsChecked = false;
            }

            ViewDataContext = new Screen1VM(this);
        }

        //--------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        //--------------------------------------------------------------------------------
        public void SetViewDataContext(object dataContext)
        {
            ViewDataContext = dataContext;
        }

        //--------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        //--------------------------------------------------------------------------------
        public ICommand LogoutCommand
        {
            get;
            private set;
        }

        //--------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        //--------------------------------------------------------------------------------
        public ICommand SelectToolCommand
        {
            get;
            private set;
        }

        //--------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        //--------------------------------------------------------------------------------
        public List<MenuItemViewModel> AvailableTools
        {
            get;
            private set;
        }

        //--------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        //--------------------------------------------------------------------------------
        public object ViewDataContext
        {
            get
            {
                return _viewDataContext;
            }
            set
            {
                if (_viewDataContext == value) return;
                _viewDataContext = value;
                RaiseNotifyPropertyChanged("ViewDataContext");
            }
        }

        //--------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        //--------------------------------------------------------------------------------
        public string StatusMessage
        {
            get { return _statusMessage; }
            set
            {
                if (_statusMessage == value) return;
                _statusMessage = value;
                RaiseNotifyPropertyChanged("StatusMessage");
            }
        }

        //--------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        //--------------------------------------------------------------------------------
        public string ModalMessage
        {
            get { return _modalMessage; }
            set
            {
                if (_modalMessage == value) return;
                _modalMessage = value;
                RaiseNotifyPropertyChanged("ModalMessage");
            }
        }

        //--------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        //--------------------------------------------------------------------------------
        public bool IsUILocked
        {
            get { return _isUILocked; }
            set
            {
                if (_isUILocked == value) return;
                _isUILocked = value;
                RaiseNotifyPropertyChanged("IsUILocked");
            }
        }

        //--------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        //--------------------------------------------------------------------------------
        public void SetStatusMessage(string message)
        {
            _dispatcher.BeginInvoke((Action)(() => { StatusMessage = message; }));
        }

        //--------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        //--------------------------------------------------------------------------------
        public void SetModalMessage(string message)
        {
            _dispatcher.BeginInvoke((Action)(() => { ModalMessage = message; }));
        }

        //--------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        //--------------------------------------------------------------------------------
        public void SetUILock(bool locked)
        {
            _dispatcher.BeginInvoke((Action)(() => { IsUILocked = locked; }));
        }

        //--------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        //--------------------------------------------------------------------------------
        public Dispatcher MainWindowDispatcher
        {
            get
            {
                return _dispatcher;
            }
        }
    }

    //--------------------------------------------------------------------------------
    /// <summary>
    /// 
    /// </summary>
    //--------------------------------------------------------------------------------
    public interface IUIService
    {
        void SetStatusMessage(string message);
        void SetModalMessage(string message);
        void SetUILock(bool locked);
        Dispatcher MainWindowDispatcher { get; }
        void SetViewDataContext(object dataContext);
    }
}
