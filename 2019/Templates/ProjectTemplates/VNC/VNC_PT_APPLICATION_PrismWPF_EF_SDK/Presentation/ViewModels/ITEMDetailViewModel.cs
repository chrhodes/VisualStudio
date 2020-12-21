using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

using Prism.Commands;
using Prism.Events;

using $customAPPLICATION$.Domain;
using $customAPPLICATION$.DomainServices;
using $customAPPLICATION$.Presentation.ModelWrappers;

using VNC;
using VNC.Core.Events;
using VNC.Core.Mvvm;
using VNC.Core.Services;

namespace $customAPPLICATION$.Presentation.ViewModels
{
    public class $xxxITEMxxx$DetailViewModel : DetailViewModelBase, I$xxxITEMxxx$DetailViewModel, IInstanceCountVM
    {
        #region Contructors, Initialization, and Load

        public $xxxITEMxxx$DetailViewModel(
                I$xxxITEMxxx$DataService $xxxITEMxxx$DataService,
                IEventAggregator eventAggregator,
                IMessageDialogService messageDialogService) : base(eventAggregator, messageDialogService)
        {
            Int64 startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_APPNAME);

            InstanceCountVM++;

            _$xxxITEMxxx$DataService = $xxxITEMxxx$DataService;
            
            Title = "$xxxITEMxxx$s";
            $xxxITEMxxx$s = new ObservableCollection<$xxxITEMxxx$Wrapper>();
            
            AddCommand = new DelegateCommand(OnAddExecute);
            RemoveCommand = new DelegateCommand(OnRemoveExecute, OnRemoveCanExecute);            

            Log.CONSTRUCTOR("Exit", Common.LOG_APPNAME, startTicks);
        }

        #endregion

        #region Enums

        #endregion

        #region Structures

        #endregion

        #region Fields and Properties

        private I$xxxITEMxxx$DataService _$xxxITEMxxx$DataService;

        public ICommand AddCommand { get; }

        public ICommand RemoveCommand { get; }
        
                public ObservableCollection<$xxxITEMxxx$Wrapper> $xxxITEMxxx$s { get; }
        
        private $xxxITEMxxx$Wrapper _selected$xxxITEMxxx$;

        public $xxxITEMxxx$Wrapper Selected$xxxITEMxxx$
        {
            get { return _selected$xxxITEMxxx$; }
            set
            {
                _selected$xxxITEMxxx$ = value;
                OnPropertyChanged();
                ((DelegateCommand)RemoveCommand).RaiseCanExecuteChanged();
            }
        }

        #endregion

        #region Event Handlers

        // private async void OnOpenDetailView(OpenDetailViewEventArgs args)
        // {
            // Int64 startTicks = Log.EVENT("($xxxITEMxxx$DetailViewModel) Enter", Common.LOG_APPNAME);

            // await LoadAsync(args.Id);

            // Log.EVENT("($xxxITEMxxx$DetailViewModel) Exit", Common.LOG_APPNAME, startTicks);
        // }

        #endregion

        #region Public Methods

        public override async Task LoadAsync(int id)
        {
            Int64 startTicks = Log.VIEWMODEL("($xxxITEMxxx$DetailViewModel) Enter Id:({id})", Common.LOG_APPNAME);

            Id = id;

            foreach (var wrapper in $xxxITEMxxx$s)
            {
                wrapper.PropertyChanged -= Wrapper_PropertyChanged;
            }

            $xxxITEMxxx$s.Clear();

            var items = await _$xxxITEMxxx$DataService.AllAsync();

            foreach (var model in items)
            {
                var wrapper = new $xxxITEMxxx$Wrapper(model);
                wrapper.PropertyChanged += Wrapper_PropertyChanged;
                $xxxITEMxxx$s.Add(wrapper);
            }
            
            Log.VIEWMODEL("($xxxITEMxxx$DetailViewModel) Exit", Common.LOG_APPNAME, startTicks);
        }
        
        void Wrapper_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (! HasChanges)
            {
                HasChanges = _$xxxITEMxxx$DataService.HasChanges();
            }

            if (e.PropertyName == nameof($xxxITEMxxx$Wrapper.HasErrors))
            {
                ((DelegateCommand)SaveCommand).RaiseCanExecuteChanged();
            }
        }

        #endregion

        #region Protected Methods

        protected override bool OnDeleteCanExecute()
        {
            // TODO(crhodes)
            // Why do we need this?
            return true;
        }

        protected override async void OnDeleteExecute()
        {
            Int64 startTicks = Log.VIEWMODEL($"($xxxITEMxxx$DetailViewModel) Enter Id:({Selected$xxxITEMxxx$.Id})", Common.LOG_APPNAME);

            Log.VIEWMODEL("($xxxITEMxxx$DetailViewModel) Exit", Common.LOG_APPNAME, startTicks);
        }

        protected override bool OnSaveCanExecute()
        {
            return HasChanges && $xxxITEMxxx$s.All(p => !p.HasErrors);
        }

        protected override async void OnSaveExecute()
        {
            Int64 startTicks = Log.VIEWMODEL($"($xxxITEMxxx$DetailViewModel) Enter Id:({Selected$xxxITEMxxx$.Id})", Common.LOG_APPNAME);

            try
            {
                await _$xxxITEMxxx$DataService.UpdateAsync();
                
                HasChanges = _$xxxITEMxxx$DataService.HasChanges();

                PublishAfterCollectionSavedEvent();
            }
            catch (Exception ex)
            {
                while (ex.InnerException != null)
                {
                    ex = ex.InnerException;
                }

                MessageDialogService.ShowInfoDialog(
                    "Error while saving the $xxxITEMxxx$s, " +
                    "the data will be reloaded.  Details: " + ex.Message);
                await LoadAsync(Id);
            }

            Log.VIEWMODEL("($xxxITEMxxx$DetailViewModel) Exit", Common.LOG_APPNAME, startTicks);
        }

        #endregion

        #region Private Methods

        void OnAddExecute()
        {
            Int64 startTicks = Log.VIEWMODEL("($xxxITEMxxx$DetailViewModel) Enter", Common.LOG_APPNAME);

            var wrapper = new $xxxITEMxxx$Wrapper(new Domain.$xxxITEMxxx$());
            wrapper.PropertyChanged += Wrapper_PropertyChanged;

            _$xxxITEMxxx$DataService.Add(wrapper.Model);
            $xxxITEMxxx$s.Add(wrapper);

            wrapper.Name = "";  // Trigger the validation

            Log.VIEWMODEL("($xxxITEMxxx$DetailViewModel) Exit", Common.LOG_APPNAME, startTicks);
        }

        private async void OnRemoveExecute()
        {
            Int64 startTicks = Log.VIEWMODEL("($xxxITEMxxx$DetailViewModel) Enter", Common.LOG_APPNAME);
           
            var isReferenced =
                await _$xxxITEMxxx$DataService.IsReferencedBy$customTYPE$Async(Selected$xxxITEMxxx$.Id);

            if (isReferenced)
            {
                MessageDialogService.ShowInfoDialog(
                    $"The language {Selected$xxxITEMxxx$.Name}" +
                    " can't be removed;  It is referenced by at least one $customTYPE$");
                return;
            }

            Selected$xxxITEMxxx$.PropertyChanged -= Wrapper_PropertyChanged;
            _$xxxITEMxxx$DataService.Remove(Selected$xxxITEMxxx$.Model);
            $xxxITEMxxx$s.Remove(Selected$xxxITEMxxx$);
            Selected$xxxITEMxxx$ = null;
            HasChanges = _$xxxITEMxxx$DataService.HasChanges();
            
            ((DelegateCommand)SaveCommand).RaiseCanExecuteChanged();

            Log.VIEWMODEL("($xxxITEMxxx$DetailViewModel) Exit", Common.LOG_APPNAME, startTicks);
        }

        bool OnRemoveCanExecute()
        {
            return Selected$xxxITEMxxx$ != null;
        }

        #endregion

        #region IInstanceCount

        private static int _instanceCountVM;

        public int InstanceCountVM
        {
            get => _instanceCountVM;
            set => _instanceCountVM = value;
        }

        #endregion
    }
}
