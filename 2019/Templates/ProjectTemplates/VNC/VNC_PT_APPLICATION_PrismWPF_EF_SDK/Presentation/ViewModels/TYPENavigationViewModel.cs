using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

using Prism.Events;

using $xxxAPPLICATIONxxx$.DomainServices;

using VNC;
using VNC.Core.Events;
using VNC.Core.Mvvm;
using VNC.Core.Services;

namespace $xxxAPPLICATIONxxx$.Presentation.ViewModels
{
    public class $xxxTYPExxx$NavigationViewModel : EventViewModelBase, I$xxxTYPExxx$NavigationViewModel, IInstanceCountVM
    {

        #region Constructors, Initialization, and Load

        public $xxxTYPExxx$NavigationViewModel(
                I$xxxTYPExxx$LookupDataService $xxxTYPExxx$LookupDataService,
                IEventAggregator eventAggregator,
                IMessageDialogService messageDialogService) : base(eventAggregator, messageDialogService)
        {
            Int64 startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_APPNAME);

            _$xxxTYPExxx$LookupDataService = $xxxTYPExxx$LookupDataService;

            InitializeViewModel();

            Log.CONSTRUCTOR("Exit", Common.LOG_APPNAME, startTicks);
        }

        private void InitializeViewModel()
        {
            Int64 startTicks = Log.VIEWMODEL("Enter", Common.LOG_APPNAME);

            InstanceCountVM++;

            $xxxTYPExxx$s = new ObservableCollection<NavigationItemViewModel>();

            EventAggregator.GetEvent<AfterDetailSavedEvent>()
                .Subscribe(AfterDetailSaved);

            EventAggregator.GetEvent<AfterDetailDeletedEvent>()
                .Subscribe(AfterDetailDeleted);

            Log.VIEWMODEL("Exit", Common.LOG_APPNAME, startTicks);
        }

        #endregion

        #region Enums


        #endregion

        #region Structures


        #endregion

        #region Fields and Properties

        private I$xxxTYPExxx$LookupDataService _$xxxTYPExxx$LookupDataService;

        public ObservableCollection<NavigationItemViewModel> $xxxTYPExxx$s { get; private set;}

        #endregion

        #region Event Handlers

        private void AfterDetailSaved(AfterDetailSavedEventArgs args)
        {
            Int64 startTicks = Log.EVENT_HANDLER($"Enter Id:({args.Id})", Common.LOG_APPNAME);

            switch (args.ViewModelName)
            {
                case nameof($xxxTYPExxx$DetailViewModel):
                    AfterDetailSaved($xxxTYPExxx$s, args);
                    break;

                default:
                    return;
                    //throw new System.Exception($"AfterDetailSaved(): ViewModel {args.ViewModelName} not mapped.");
            }

            Log.EVENT_HANDLER("Exit", Common.LOG_APPNAME, startTicks);
        }

        private void AfterDetailDeleted(AfterDetailDeletedEventArgs args)
        {
            Int64 startTicks = Log.EVENT_HANDLER($"Enter Id:({args.Id})", Common.LOG_APPNAME);

            switch (args.ViewModelName)
            {
                case nameof($xxxTYPExxx$DetailViewModel):
                    AfterDetailDeleted($xxxTYPExxx$s, args);
                    break;

                default:
                    return;
                    //throw new System.Exception($"AfterDetailDeleted(): ViewModel {args.ViewModelName} not mapped.");
            }

            Log.EVENT_HANDLER("Exit", Common.LOG_APPNAME, startTicks);
        }

        #endregion

        #region Public Methods

        public async Task LoadAsync()
        {
            Int64 startTicks = Log.VIEWMODEL("($xxxTYPExxx$NavigationViewModel) Enter", Common.LOG_APPNAME);

            var lookup$xxxTYPExxx$s = await _$xxxTYPExxx$LookupDataService.Get$xxxTYPExxx$LookupAsync();

            $xxxTYPExxx$s.Clear();

            foreach (var item in lookup$xxxTYPExxx$s)
            {
                $xxxTYPExxx$s.Add(
                    new NavigationItemViewModel(item.Id, item.DisplayMember,
                    nameof($xxxTYPExxx$DetailViewModel),
                    EventAggregator, MessageDialogService));
            }

            Log.VIEWMODEL("($xxxTYPExxx$NavigationViewModel) Exit", Common.LOG_APPNAME, startTicks);
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
