using System.Windows.Controls;

using VNC;
using VNC.Core.Mvvm;
using $customAPPLICATION$.Infrastructure.Presentation.ViewModels;

namespace $rootnamespace$
{
    public partial class $safeitemname$ : UserControl, IView
    {
        #region Constructors and Load

		// View First.  
		// View is passed ViewModel through Injection
		// or can declare ViewModel in Xaml or Code
		
		// ViewModel First.  
		// ViewModel creates View 
		// and sets DataContext by setting ViewModel property
		
        public $safeitemname$()
        {
            long startTicks = Log.Trace("Enter", Common.PROJECT_NAME);
			
            InitializeComponent();
			
			// If View First with ViewModel in Xaml
            // Expose ViewModel
            // ViewModel = (I$customTYPE$ViewModel)DataContext;
			
			// Can create directly
			// ViewModel = new $customTYPE$ViewModel();
			
			InitializeView();
			
            Log.Trace("Exit", Common.PROJECT_NAME, startTicks);
        }
		
        public $safeitemname$(I$customTYPE$ViewModel viewModel)
        {
            long startTicks = Log.Trace("Enter", Common.PROJECT_NAME);
			
            InitializeComponent();
			
            ViewModel = viewModel;
			
			InitializeView();

            Log.Trace("Exit", Common.PROJECT_NAME, startTicks);
        }
		
        private void InitializeView()
        {
            // TODO(crhodes)
			// Perform any initialization or configuration of View

            //lgMain.IsCollapsed = true;
        }
		
		#endregion
		
		#region Properties
		
        private IViewModel _viewModel;

        public IViewModel ViewModel
        {
            get { return _viewModel; }

            set
            {
                _viewModel = value;
                DataContext = _viewModel;
            }
        }

        #endregion
    }
}
