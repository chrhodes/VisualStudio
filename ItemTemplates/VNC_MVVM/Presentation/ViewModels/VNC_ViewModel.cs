using Prism.Commands;

using VNC;
using VNC.Core.Mvvm;

using VNC_MVVM.Presentation.ModelWrappers;
using VNC_MVVM.Presentation.Views;

namespace VNC_MVVM.Presentation.ViewModels
{
    public class VNC_ViewModel : ViewModelBase
    {
        public System.Collections.ObjectModel.ObservableCollection<VNC_ModelWrapper> Rows { get; set; }

        VNC_ModelWrapper _selectedItem;
        public VNC_ModelWrapper SelectedItem
        {
            get
            {
                return _selectedItem;
            }
            set
            {
                _selectedItem = value;
                OnPropertyChanged();
            }
        }

        public DelegateCommand DoSomething { get; set; }
        public string DoSomethingContent { get; set; }
        public string DoSomethingToolTip { get; set; }

        string _message = "Click Button to do something";
        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                _message = value;
                OnPropertyChanged();
            }
        }

        public VNC_ViewModel()
        {
            Log.Trace("Enter", Common.PROJECT_NAME);

            DoSomething = new DelegateCommand(OnDoSomethingExecute, OnDoSomethingCanExecute);
            DoSomethingContent = "Update Actions for selected shapes";
            DoSomethingToolTip = "ToolTip for DoSomething Button";
            // TODO(crhodes)
            // Decide if we want defaults
            //XXX = new XXXWrapper(new Domain.XXX());

            InitializeRows();

            Log.Trace("Exit", Common.PROJECT_NAME);
        }

        public VNC_ViewModel(VNC_View view) : base(view)
        {
            Log.Trace("Enter", Common.PROJECT_NAME);

            DoSomething = new DelegateCommand(OnDoSomethingExecute, OnDoSomethingCanExecute);
            DoSomethingContent = "Update Actions for selected shapes";
            DoSomethingToolTip = "ToolTip for DoSomething Button";

            InitializeRows();

            //View = view;

            Log.Trace("Exit", Common.PROJECT_NAME);
        }

        void InitializeRows()
        {
            Rows = new System.Collections.ObjectModel.ObservableCollection<VNC_ModelWrapper>();
            Rows.Add(new VNC_ModelWrapper(new Domain.VNC_Model(){ StringProperty ="Red", IntProperty = 1}));
            Rows.Add(new VNC_ModelWrapper(new Domain.VNC_Model(){ StringProperty = "Green", IntProperty = 2 }));
            Rows.Add(new VNC_ModelWrapper(new Domain.VNC_Model(){ StringProperty = "Blue", IntProperty = 3 }));

            OnPropertyChanged("Rows");
        }

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
    }
}
