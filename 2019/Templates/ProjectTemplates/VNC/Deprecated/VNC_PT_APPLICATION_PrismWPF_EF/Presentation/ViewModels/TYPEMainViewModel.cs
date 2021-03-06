﻿using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

using Prism.Commands;
using Prism.Events;

using $customAPPLICATION$.Core.Events;
using $customAPPLICATION$.DomainServices;

using VNC;
using VNC.Core.Events;
using VNC.Core.Mvvm;
using VNC.Core.Services;

namespace $customAPPLICATION$.Presentation.ViewModels
{
    public class $customTYPE$MainViewModel : ViewModelBase, I$customTYPE$MainViewModel
    {
        private I$customTYPE$LookupDataService _lookupDataService;
        private IEventAggregator _eventAggregator;

        private Func<I$customTYPE$DetailViewModel> _detailViewModelCreator;

        private IDetailViewModel _selectedDetailViewModel;
        private IMessageDialogService _messageDialogService;

        public ICommand CreateNewDetailCommand { get; }

        public ICommand OpenSingleDetailViewCommand { get; }

        // N.B. This is public so View.Xaml can bind to it.
        public I$customTYPE$NavigationViewModel NavigationViewModel { get; }

        public $customTYPE$MainViewModel(
            I$customTYPE$NavigationViewModel navigationViewModel,
            Func<I$customTYPE$DetailViewModel> detailViewModelCreator,
            // I$customTYPE$LookupDataService lookupDataService,
            IEventAggregator eventAggregator,
            IMessageDialogService messageDialogService)
        {
            Int64 startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_APPNAME);

            // _lookupDataService = lookupDataService;
            _eventAggregator = eventAggregator;
            _detailViewModelCreator = detailViewModelCreator;
            _messageDialogService = messageDialogService;

            DetailViewModels = new ObservableCollection<IDetailViewModel>();

            _eventAggregator.GetEvent<Open$customTYPE$DetailViewEvent>()
                .Subscribe(OnOpenDetailView);

            _eventAggregator.GetEvent<AfterDetailDeletedEvent>()
                .Subscribe(AfterDetailDeleted);

            _eventAggregator.GetEvent<AfterDetailClosedEvent>()
                .Subscribe(AfterDetailClosed);

            CreateNewDetailCommand = new DelegateCommand<Type>(
                OnCreateNewDetailExecute);

            OpenSingleDetailViewCommand = new DelegateCommand<Type>(
                OnOpenSingleDetailExecute);

            NavigationViewModel = navigationViewModel;

            Log.Trace("Exit", Common.LOG_APPNAME, startTicks);
        }

        public ObservableCollection<IDetailViewModel> DetailViewModels { get; }

        public IDetailViewModel SelectedDetailViewModel
        {
            get
            {
                return _selectedDetailViewModel;
            }
            set
            {
                _selectedDetailViewModel = value;
                OnPropertyChanged();
            }
        }

        public async Task LoadAsync()
        {
            Int64 startTicks = Log.VIEWMODEL("Enter", Common.LOG_APPNAME);

            await NavigationViewModel.LoadAsync();

            Log.Trace(String.Format("Exit"), Common.LOG_APPNAME, startTicks);
        }

        public ObservableCollection<NavigationItemViewModel> $customTYPE$s { get; }

        public IView View
        {
            get;
            set;
        }

        NavigationItemViewModel _selected$customTYPE$;

        public NavigationItemViewModel Selected$customTYPE$
        {
            get { return _selected$customTYPE$; }
            set
            {
                _selected$customTYPE$ = value;
                OnPropertyChanged();

                if (_selected$customTYPE$ != null)
                {
                    _eventAggregator.GetEvent<Open$customTYPE$DetailViewEvent>()
                      .Publish
                        (
                            new OpenDetailViewEventArgs
                            {
                                Id = _selected$customTYPE$.Id,
                                ViewModelName = nameof($customTYPE$DetailViewModel)
                            }
                        );
                }
            }
        }

        private int _nextNewItemId = 0;

        private void OnCreateNewDetailExecute(Type viewModelType)
        {
            Int64 startTicks = Log.VIEWMODEL("Enter", Common.LOG_APPNAME);

            OnOpenDetailView(
                new OpenDetailViewEventArgs
                {
                    Id = _nextNewItemId--,  // Ids in DB > 0.  Can now create multiple new items
                    ViewModelName = viewModelType.Name
                });

            Log.Trace(String.Format("Exit"), Common.LOG_APPNAME, startTicks);
        }

        private async void OnOpenDetailView(OpenDetailViewEventArgs args)
        {
            Int64 startTicks = Log.VIEWMODEL("Enter", Common.LOG_APPNAME);

            var detailViewModel = DetailViewModels
                    .SingleOrDefault(vm => vm.Id == args.Id
                    && vm.GetType().Name == args.ViewModelName);

            if (detailViewModel == null)
            {
                switch (args.ViewModelName)
                {
                    case nameof($customTYPE$DetailViewModel):
                        detailViewModel = (IDetailViewModel)_detailViewModelCreator();
                        break;

                    //case nameof(MeetingDetailViewModel):
                    //    detailViewModel = _meetingDetailViewModelCreator();
                    //    break;

                    //case nameof(ProgrammingLanguageDetailViewModel):
                    //    detailViewModel = _programmingLanguageDetailViewModelCreator();
                    //    break;
                    
                    // This should not happen anymore withe TYPEEvent
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
                    _messageDialogService.ShowInfoDialog(
                        "Cannot load the entity, it may have been deleted" +
                        " by another user.  Updating Navigation");
                    await NavigationViewModel.LoadAsync();
                    return;
                }

                DetailViewModels.Add(detailViewModel);
            }

            SelectedDetailViewModel = detailViewModel;

            Log.Trace(String.Format("Exit"), Common.LOG_APPNAME, startTicks);
        }

        private void AfterDetailDeleted(AfterDetailDeletedEventArgs args)
        {
            Int64 startTicks = Log.EVENT("Enter", Common.LOG_APPNAME);

            RemoveDetailViewModel(args.Id, args.ViewModelName);

            Log.Trace("Exit", Common.LOG_APPNAME, startTicks);
        }

        void AfterDetailClosed(AfterDetailClosedEventArgs args)
        {
            Int64 startTicks = Log.EVENT("Enter", Common.LOG_APPNAME);

            RemoveDetailViewModel(args.Id, args.ViewModelName);

            Log.Trace("Exit", Common.LOG_APPNAME, startTicks);
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

        void OnOpenSingleDetailExecute(Type viewModelType)
        {
            Int64 startTicks = Log.VIEWMODEL("Enter", Common.LOG_APPNAME);

            OnOpenDetailView(
                new OpenDetailViewEventArgs
                {
                    Id = -1,
                    ViewModelName = viewModelType.Name
                });

            Log.VIEWMODEL("Exit", Common.LOG_APPNAME, startTicks);
        }
    }
}
