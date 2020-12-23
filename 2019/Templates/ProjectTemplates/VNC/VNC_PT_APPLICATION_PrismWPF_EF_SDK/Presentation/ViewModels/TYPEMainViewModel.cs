using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

using Prism.Commands;
using Prism.Events;

using VNC;
using VNC.Core.Events;
using VNC.Core.Mvvm;
using VNC.Core.Services;

namespace $customAPPLICATION$.Presentation.ViewModels
{
    public class $customTYPE$MainViewModel : EventViewModelBase, I$customTYPE$MainViewModel, IInstanceCountVM
    {

        #region Constructors, Initialization, and Load

        public $customTYPE$MainViewModel(
            I$customTYPE$NavigationViewModel $customTYPE$NavigationViewModel,
            Func<I$customTYPE$DetailViewModel> $customTYPE$DetailViewModelCreator,
            Func<I$xxxITEMxxx$DetailViewModel> $xxxITEMxxx$DetailViewModelCreator,
            IEventAggregator eventAggregator,
            IMessageDialogService messageDialogService) : base(eventAggregator, messageDialogService)
        {
            Int64 startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_APPNAME);

            InstanceCountVM++;

            _$customTYPE$DetailViewModelCreator = $customTYPE$DetailViewModelCreator;
            _$xxxITEMxxx$DetailViewModelCreator = $xxxITEMxxx$DetailViewModelCreator;

            NavigationViewModel = $customTYPE$NavigationViewModel;
            
            DetailViewModels = new ObservableCollection<IDetailViewModel>();

            EventAggregator.GetEvent<OpenDetailViewEvent>()
                .Subscribe(OnOpenDetailView);

            EventAggregator.GetEvent<AfterDetailDeletedEvent>()
                .Subscribe(AfterDetailDeleted);

            EventAggregator.GetEvent<AfterDetailClosedEvent>()
                .Subscribe(AfterDetailClosed);

            CreateNewDetailCommand = new DelegateCommand<Type>(
                OnCreateNewDetailExecute);

            OpenSingleDetailViewCommand = new DelegateCommand<Type>(
                OnOpenSingleDetailExecute);



            Log.CONSTRUCTOR("Exit", Common.LOG_APPNAME, startTicks);
        }

        #endregion

        #region Enums


        #endregion

        #region Structures


        #endregion

        #region Fields and Properties

        private Func<I$customTYPE$DetailViewModel> _$customTYPE$DetailViewModelCreator;
        private Func<I$xxxITEMxxx$DetailViewModel> _$xxxITEMxxx$DetailViewModelCreator;
        
        private IDetailViewModel _selectedDetailViewModel;

        public ICommand CreateNewDetailCommand { get; }

        public ICommand OpenSingleDetailViewCommand { get; }

        // N.B. This is public so View.Xaml can bind to it.
        public I$customTYPE$NavigationViewModel NavigationViewModel { get; }

        public ObservableCollection<IDetailViewModel> DetailViewModels { get; }

                private int _nextNewItemId = 0;

        public IDetailViewModel SelectedDetailViewModel
        {
            get
            {
                return _selectedDetailViewModel;
            }
            set
            {
                _selectedDetailViewModel = value;
                // NOTE(crhodes)
                // We can check if different and skip notificaiton,
                // however, raisign the event will cause the tab to be selected
                // which will draw user to tab if another is selected.
                OnPropertyChanged();
            }
        }

        #endregion

        #region Event Handlers

        void OnOpenSingleDetailExecute(Type viewModelType)
        {
            Int64 startTicks = Log.EVENT_HANDLER("Enter", Common.LOG_APPNAME);

            OnOpenDetailView(
                new OpenDetailViewEventArgs
                {
                    Id = -1,
                    ViewModelName = viewModelType.Name
                });

            Log.EVENT_HANDLER("Exit", Common.LOG_APPNAME, startTicks);
        }

        private void OnCreateNewDetailExecute(Type viewModelType)
        {
            Int64 startTicks = Log.VIEWMODEL("Enter", Common.LOG_APPNAME);

            OnOpenDetailView(
                new OpenDetailViewEventArgs
                {
                    Id = _nextNewItemId--,  // Ids in DB > 0.  Can now create multiple new items
                    ViewModelName = viewModelType.Name
                });

            Log.VIEWMODEL("Exit", Common.LOG_APPNAME, startTicks);
        }

        private async void OnOpenDetailView(OpenDetailViewEventArgs args)
        {
            Int64 startTicks = Log.EVENT_HANDLER($"($customTYPE$MainViewModel) Enter Id:({args.Id}(", Common.LOG_APPNAME);

            var detailViewModel = DetailViewModels
                    .SingleOrDefault(vm => vm.Id == args.Id
                    && vm.GetType().Name == args.ViewModelName);

            if (detailViewModel == null)
            {
                switch (args.ViewModelName)
                {
                    case nameof($customTYPE$DetailViewModel):
                        detailViewModel = (IDetailViewModel)_$customTYPE$DetailViewModelCreator();
                        break;

                    //case nameof(MeetingDetailViewModel):
                    //    detailViewModel = _meetingDetailViewModelCreator();
                    //    break;

                    case nameof($xxxITEMxxx$DetailViewModel):
                       detailViewModel = _$xxxITEMxxx$DetailViewModelCreator();
                       break;

                    // Ignore event if we don't handle
                    default:
                        return;
                }

                // Verify item still exists (may have been deleted)

                try
                {
                    await detailViewModel.LoadAsync(args.Id);
                }
                catch (Exception ex)
                {
                    MessageDialogService.ShowInfoDialog($"Cannot load the entity ({ex})" +
                        "It may have been deleted by another user.  Updating Navigation");
                        
                    await NavigationViewModel.LoadAsync();
                    
                    return;
                }

                DetailViewModels.Add(detailViewModel);
            }

            SelectedDetailViewModel = detailViewModel;

            Log.VIEWMODEL("($customTYPE$MainViewModel) Exit", Common.LOG_APPNAME, startTicks);
        }

        private void AfterDetailDeleted(AfterDetailDeletedEventArgs args)
        {
            Int64 startTicks = Log.EVENT_HANDLER("Enter", Common.LOG_APPNAME);

            RemoveDetailViewModel(args.Id, args.ViewModelName);

            Log.EVENT_HANDLER("Exit", Common.LOG_APPNAME, startTicks);
        }

        void AfterDetailClosed(AfterDetailClosedEventArgs args)
        {
            Int64 startTicks = Log.EVENT_HANDLER("Enter", Common.LOG_APPNAME);

            RemoveDetailViewModel(args.Id, args.ViewModelName);

            Log.EVENT_HANDLER("Exit", Common.LOG_APPNAME, startTicks);
        }

        private void RemoveDetailViewModel(int id, string viewModelName)
        {
            Int64 startTicks = Log.VIEWMODEL("Enter", Common.LOG_APPNAME);

            var detailViewModel = DetailViewModels
                .SingleOrDefault(vm => vm.Id == id
                && vm.GetType().Name == viewModelName);

            if (detailViewModel != null)
            {
                DetailViewModels.Remove(detailViewModel);
            }

            Log.VIEWMODEL("Exit", Common.LOG_APPNAME, startTicks);
        }

        #endregion

        #region Public Methods

        public async Task LoadAsync()
        {
            Int64 startTicks = Log.VIEWMODEL("$customTYPE$MainViewModel) Enter", Common.LOG_APPNAME);

            await NavigationViewModel.LoadAsync();

            Log.VIEWMODEL("$customTYPE$MainViewModel) Exit", Common.LOG_APPNAME, startTicks);
        }

        #endregion

        #region Protected Methods


        #endregion

        #region Private Methods


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
