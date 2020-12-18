using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

using Prism.Events;

using $customAPPLICATION$.DomainServices;

using VNC;
using VNC.Core.Events;
using VNC.Core.Mvvm;
using VNC.Core.Services;

namespace $customAPPLICATION$.Presentation.ViewModels
{
    public class CombinedNavigationViewModel : EventViewModelBase, ICombinedNavigationViewModel, IInstanceCountVM
    {

        #region Constructors, Initialization, and Load

        public CombinedNavigationViewModel(
                I$customTYPE$LookupDataService $customTYPE$LookupDataService,
                //I$customCatLookupDataService catLookupDataService,
                IEventAggregator eventAggregator,
                IMessageDialogService messageDialogService) : base(eventAggregator, messageDialogService)
        {
            Int64 startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_APPNAME);

            InstanceCountVM++;

            _$customTYPE$LookupDataService = $customTYPE$LookupDataService;
            //_catLookupDataService = catLookupDataService

            $customTYPE$s = new ObservableCollection<NavigationItemViewModel>();
            //Cats = new ObservableCollection<NavigationItemViewModel>();

            EventAggregator.GetEvent<AfterDetailSavedEvent>()
                .Subscribe(AfterDetailSaved);

            EventAggregator.GetEvent<AfterDetailDeletedEvent>()
                .Subscribe(AfterDetailDeleted);

            Log.CONSTRUCTOR("Exit", Common.LOG_APPNAME, startTicks);
        }

        #endregion

        #region Enums


        #endregion

        #region Structures


        #endregion

        #region Fields and Properties

        private I$customTYPE$LookupDataService _$customTYPE$LookupDataService;
        //private ICatLookupDataService _CatLookupDataService;

        public ObservableCollection<NavigationItemViewModel> $customTYPE$s { get; }
        //public ObservableCollection<NavigationItemViewModel> Cats { get; }

        #endregion

        #region Event Handlers

        private void AfterDetailSaved(AfterDetailSavedEventArgs args)
        {
            Int64 startTicks = Log.EVENT_HANDLER("Enter", Common.LOG_APPNAME);

            switch (args.ViewModelName)
            {
                case nameof($customTYPE$DetailViewModel):
                    AfterDetailSaved($customTYPE$s, args);
                    break;

                // case nameof($customTYPE$2DetailViewModel):
                    // AfterDetailSaved($customTYPE$2s, args);
                    // break;

                default:
                    throw new System.Exception($"AfterDetailSaved(): ViewModel {args.ViewModelName} not mapped.");
            }

            Log.EVENT_HANDLER("Exit", Common.LOG_APPNAME, startTicks);
        }

        private void AfterDetailDeleted(AfterDetailDeletedEventArgs args)
        {
            Int64 startTicks = Log.EVENT_HANDLER("Enter", Common.LOG_APPNAME);

            switch (args.ViewModelName)
            {
                case nameof($customTYPE$DetailViewModel):
                    AfterDetailDeleted($customTYPE$s, args);
                    break;

                // case nameof($customTYPE$2DetailViewModel):
                    // AfterDetailDeleted($customTYPE$2s, args);
                    // break;

                default:
                    throw new System.Exception($"AfterDetailDeleted(): ViewModel {args.ViewModelName} not mapped.");
            }

            Log.EVENT_HANDLER("Exit", Common.LOG_APPNAME, startTicks);
        }

        #endregion

        #region Public Methods

        public async Task LoadAsync()
        {
            Int64 startTicks = Log.VIEWMODEL("(NavigationViewModel) Enter", Common.LOG_APPNAME);

            var lookup$customTYPE$s = await _$customTYPE$LookupDataService.Get$customTYPE$LookupAsync();
            $customTYPE$s.Clear();

            foreach (var item in lookup$customTYPE$s)
            {
                $customTYPE$s.Add(
                    new NavigationItemViewModel(item.Id, item.DisplayMember,
                    nameof($customTYPE$DetailViewModel),
                    EventAggregator, MessageDialogService));
            }

            // var lookup$customTYPE$2s = await _$customTYPE$2LookupDataService.Get$customTYPE$2LookupAsync();
            // $customTYPE$2s.Clear();

            // foreach (var item in lookup$customTYPE$2s)
            // {
                // $customTYPE$2s.Add(
                    // new NavigationItemViewModel(item.Id, item.DisplayMember,
                    // nameof($customTYPE$2DetailViewModel),
                    // EventAggregator, MessageDialogService));
            // }

            //TODO(crhodes)
            // Load more TYPEs as needed here

            Log.VIEWMODEL("(NavigationViewModel) Exit", Common.LOG_APPNAME, startTicks);
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
