using System;
using System.Windows;
using System.Windows.Controls;

using VNC;
using VNC.Core.Mvvm;

namespace $customAPPLICATION$.Presentation.Views
{
    public partial class $customTYPE$Main : UserControl, I$customTYPE$Main
    {

        public $customTYPE$Main(ViewModels.I$customTYPE$MainViewModel viewModel)
        {
            Int64 startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_APPNAME);

            InitializeComponent();

            ViewModel = viewModel;
            Loaded += UserControl_Loaded;

            Log.CONSTRUCTOR("Exit", Common.LOG_APPNAME, startTicks);
        }

        private async void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            Int64 startTicks = Log.VIEW("Enter", Common.LOG_APPNAME);

            await ((ViewModels.I$customTYPE$MainViewModel)ViewModel).LoadAsync();

            Log.VIEW("Exit", Common.LOG_APPNAME, startTicks);
        }

        public IViewModel ViewModel
        {
            get { return (IViewModel)DataContext; }
            set { DataContext = value; }
        }
    }
}
