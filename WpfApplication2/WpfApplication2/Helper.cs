using System.Reflection;
using System.IO;

namespace WpfApplication2
{
    class Helper
    {
        public string addendstring(string s)
        {
            return s + "... ";
        }

        public string CurrentLocation
        {
            get
            {
                var fileInfo = new FileInfo(Assembly.GetExecutingAssembly().Location);
                return fileInfo.DirectoryName;
            }
        }
    }
}
