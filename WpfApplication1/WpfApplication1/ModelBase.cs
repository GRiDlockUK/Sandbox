using System.ComponentModel;

namespace WpfApplication1
{
    //--------------------------------------------------------------------------------
    /// <summary>
    /// 
    /// </summary>
    //--------------------------------------------------------------------------------
    public abstract class ModelBase : INotifyPropertyChanged
    {
        //--------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        //--------------------------------------------------------------------------------
        public event PropertyChangedEventHandler PropertyChanged;

        //--------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        //--------------------------------------------------------------------------------
        public void RaiseNotifyPropertyChanged(string propertyName)
        {
            if (string.IsNullOrEmpty(propertyName))
                return;

            var handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        //--------------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        //--------------------------------------------------------------------------------
        public bool IsModal
        {
            get;
            protected set;
        }

    }
}
