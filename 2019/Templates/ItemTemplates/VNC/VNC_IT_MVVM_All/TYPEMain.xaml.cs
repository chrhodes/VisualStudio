using System;
using System.Windows;

using VNC;
using VNC.Core.Mvvm;

namespace $customAPPLICATION$.Presentation.Views
{
    public partial class $customTYPE$Main : ViewBase, I$customTYPE$Main, IInstanceCountV
    {

        public $customTYPE$Main(ViewModels.I$customTYPE$MainViewModel viewModel)
        {
            Int64 startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_APPNAME);

            InstanceCountV++;
            InitializeComponent();

            ViewModel = viewModel;
            Loaded += UserControl_Loaded;

            Log.CONSTRUCTOR("Exit", Common.LOG_APPNAME, startTicks);
        }

        private async void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            Int64 startTicks = Log.EVENT_HANDLER("($customTYPE$Main) Enter", Common.LOG_APPNAME);

            await ((ViewModels.I$customTYPE$MainViewModel)ViewModel).LoadAsync();

            Log.EVENT_HANDLER("($customTYPE$Main) Exit", Common.LOG_APPNAME, startTicks);
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
