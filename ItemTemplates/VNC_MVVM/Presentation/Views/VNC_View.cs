using System.Windows.Controls;

using VNC;
using VNC.Core.Mvvm;
using VNC_MVVM.Presentation.ViewModels;

namespace VNC_MVVM.Presentation.Views
{
    public partial class VNC_View : UserControl, IView
    {
        #region Constructors and Load

        public VNC_View()
        {
            Log.Trace("Enter", Common.PROJECT_NAME);
            InitializeComponent();
            Log.Trace("Exit", Common.PROJECT_NAME);
        }

        private VNC_ViewModel _viewModel;

        public IViewModel ViewModel
        {
            get { return _viewModel; }

            set
            {
                _viewModel = (VNC_ViewModel)value;
                DataContext = _viewModel;
            }
        }

        public VNC_View(VNC_ViewModel viewModel)
        {
            Log.Trace("Enter", Common.PROJECT_NAME);
            InitializeComponent();
            _viewModel = viewModel;
            DataContext = _viewModel;
            Log.Trace("Exit", Common.PROJECT_NAME);
        }

        #endregion
    }
}
