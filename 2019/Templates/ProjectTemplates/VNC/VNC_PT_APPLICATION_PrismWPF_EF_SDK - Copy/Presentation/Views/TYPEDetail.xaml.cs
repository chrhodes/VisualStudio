using System;
using System.Windows.Controls;

using VNC;
using VNC.Core.Mvvm;

namespace $customAPPLICATION$.Presentation.Views
{
    public partial class $customTYPE$Detail : UserControl, I$customTYPE$Detail
    {

        public $customTYPE$Detail()
        {
            Int64 startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_APPNAME);
                        
            InitializeComponent();
            
            Log.CONSTRUCTOR("Exit", Common.LOG_APPNAME, startTicks);            
        }

        public $customTYPE$Detail(ViewModels.I$customTYPE$DetailViewModel viewModel)
        {
            Int64 startTicks = Log.CONSTRUCTOR($"Enter ({viewModel.GetType()})", Common.LOG_APPNAME);

            InitializeComponent();
            ViewModel = viewModel;

            Log.CONSTRUCTOR("Exit", Common.LOG_APPNAME, startTicks);
        }

        public IViewModel ViewModel
        {
            get { return (IViewModel)DataContext; }
            set { DataContext = value; }
        }
    }
}
