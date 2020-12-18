using System.Windows.Controls;

using VNC;
//using System.Windows.Forms;

namespace SupportTools_Visio.Presentation.Views
{
    public partial class $safeitemname$ : UserControl
    {
        private readonly XXXViewModel _viewModel;

        #region Constructors and Load

        public $safeitemname$(XXXViewModel viewModel)
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
