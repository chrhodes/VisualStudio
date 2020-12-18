using System;
using System.Windows.Controls;

using VNC;
using VNC.Core.Mvvm;

namespace $customAPPLICATION$.Presentation.Views
{
    public partial class $customTYPE$Navigation : UserControl, I$customTYPE$Navigation
    {
        public $customTYPE$Navigation()
        {
            Int64 startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_APPNAME);
            
            InitializeComponent();
            
            Log.CONSTRUCTOR("Exit", Common.LOG_APPNAME, startTicks);
        }

        public IViewModel ViewModel
        {
            get { return (IViewModel)DataContext; }
            set { DataContext = value; }
        }
    }
}
