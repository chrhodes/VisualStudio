using Prism.Commands;

using VNC;
using VNC.Core.Mvvm;

using $customAPPLICATION$.Presentation.ModelWrappers;
using $customAPPLICATION$.Presentation.Views;

namespace $rootnamespace$
{
    public class $safeitemname$ : ViewModelBase
    {
		#region Constructors and Load
		
        // View First
        // View creates new ViewModel in code or Xaml
        // or ViewModel passed into View constructor
		
        public $safeitemname$()
        {
            long startTicks = Log.Trace("Enter", Common.PROJECT_NAME);
	
            // TODO(crhodes)
            // Decide if we want defaults
            //$customTYPE$ = new $customTYPE$Wrapper(new Domain.$customTYPE$());

            InitializeViewModel();

            Log.Trace("Exit", Common.PROJECT_NAME, startTicks);
        }

		// ViewModel First
		// Calling base(view) wires this ViewModel into the View
		
        public $safeitemname$($customTYPE$ view) : base(view)
        {
            long startTicks = Log.Trace("Enter", Common.PROJECT_NAME);

            InitializeViewModel();

            Log.Trace("Exit", Common.PROJECT_NAME, startTicks);
        }
		
		private void InitializeViewModel()
        {
			// TODO(crhodes)
            // Initialize any controls and/or properties that need to be
			
			DoSomethingCommand = new DelegateCommand(OnDoSomethingExecute, OnDoSomethingCanExecute);
            DoSomethingContent = "Update Actions for selected shapes";
            DoSomethingToolTip = "ToolTip for DoSomething Button";
			
			Message_DoubleClick_Command = new DelegateCommand(Message_DoubleClick);
			
            //InitializeRows();
        }
		
		#endregion
		
		#region Fields

		#endregion
		
		#region Properties
		
        string _message = "Click Button to do something";
        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
				if (_message == value) return;
				
                _message = value;
                OnPropertyChanged();
            }
        }
		
		// TODO(crhodes)
		// This is for a Grid or List
		
		// public System.Collections.ObjectModel.ObservableCollection<string> SelectedFruits { get; set; }
				
        // public System.Collections.ObjectModel.ObservableCollection<$customTYPE$Wrapper> Rows { get; set; }

		// // and the SelectedItem in the Grid or List
		
        // $customTYPE$Wrapper _selectedItem;
        // public $customTYPE$Wrapper SelectedItem
        // {
            // get
            // {
                // return _selectedItem;
            // }
            // set
            // {
                // _selectedItem = value;
                // OnPropertyChanged();
            // }
        // }
		
		// Don't forget to uncomment InitializeRows in InitializeViewModel()
		
		// void InitializeRows()
        // {
            // Rows = new System.Collections.ObjectModel.ObservableCollection<$customTYPE$Wrapper>();
            // Rows.Add(new $customTYPE$Wrapper(new Domain.$customTYPE$(){ StringProperty ="Red", IntProperty = 1}));
            // Rows.Add(new $customTYPE$Wrapper(new Domain.$customTYPE$(){ StringProperty = "Green", IntProperty = 2 }));
            // Rows.Add(new $customTYPE$Wrapper(new Domain.$customTYPE$(){ StringProperty = "Blue", IntProperty = 3 }));

            // OnPropertyChanged("Rows");
        // }		
		
		#endregion

        #region Commands

        #region DoSomething Command
		
		public DelegateCommand DoSomethingCommand { get; set; }
		public string DoSomethingContent { get; set; }
        public string DoSomethingToolTip { get; set; }
		
        public void OnDoSomethingExecute()
        {
            // TODO(crhodes)
            // Do something amazing.

            Message = "Cool, you did something!";
        }

        public bool OnDoSomethingCanExecute()
        {
            // TODO(crhodes)
            // Add any before button is enabled logic.

            return true;
        }
		
		#endregion
		
		#region Control Commands (Not Buttons)
		
		public DelegateCommand Message_DoubleClick_Command { get; set; }
		
		public void Message_DoubleClick()
        {
            Message = "Message DoubleClicked!";
        }
		
		#endregion
		
		#endregion Commands
		
    }
}
