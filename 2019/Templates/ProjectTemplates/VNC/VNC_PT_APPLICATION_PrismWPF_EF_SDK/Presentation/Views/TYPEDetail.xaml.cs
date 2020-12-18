using System;

using VNC;
using VNC.Core.Mvvm;

namespace $customAPPLICATION$.Presentation.Views
{
    public partial class $customTYPE$Detail : ViewBase, I$customTYPE$Detail, IInstanceCountV
    {

        public $customTYPE$Detail()
        {
            Int64 startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_APPNAME);

            InstanceCountV++;
            InitializeComponent();

            Log.CONSTRUCTOR("Exit", Common.LOG_APPNAME, startTicks);
        }

        public $customTYPE$Detail(ViewModels.I$customTYPE$DetailViewModel viewModel)
        {
            Int64 startTicks = Log.CONSTRUCTOR($"Enter ({viewModel.GetType()})", Common.LOG_APPNAME);

            InstanceCountV++;
            InitializeComponent();
            ViewModel = viewModel;

            Log.CONSTRUCTOR("Exit", Common.LOG_APPNAME, startTicks);
        }

        #region IInstanceCount

        private static int _instanceCountV;

        public int InstanceCountV
        {
            get => _instanceCountV;
            set => _instanceCountV = value;
        }

        #endregion

    }
}
