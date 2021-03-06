﻿using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

using Prism.Events;

using $customAPPLICATION$.DomainServices;

using VNC;
using VNC.Core.Events;
using VNC.Core.Mvvm;

namespace $customAPPLICATION$.Presentation.ViewModels
{
    public class $customTYPE$NavigationViewModel : ViewModelBase, I$customTYPE$NavigationViewModel
    {
        private I$customTYPE$LookupDataService _lookupDataService;
        private IEventAggregator _eventAggregator;

        private static int _instanceCountVM = 0;
        public ObservableCollection<NavigationItemViewModel> $customTYPE$s { get; }

        public $customTYPE$NavigationViewModel(
                IEventAggregator eventAggregator,
                I$customTYPE$LookupDataService lookupDataService)
        {
            Int64 startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_APPNAME);

            _instanceCountVM++;
            _eventAggregator = eventAggregator;

            _lookupDataService = lookupDataService;

            $customTYPE$s = new ObservableCollection<NavigationItemViewModel>();

            _eventAggregator.GetEvent<AfterDetailSavedEvent>()
                .Subscribe(AfterDetailSaved);

            _eventAggregator.GetEvent<AfterDetailDeletedEvent>()
                .Subscribe(AfterDetailDeleted);

            Log.CONSTRUCTOR("Exit", Common.LOG_APPNAME, startTicks);
        } 

        public int InstanceCountVM
        {
            get { return _instanceCountVM; }
            set { _instanceCountVM = value; }
        }

        public async Task LoadAsync()
        {
            Int64 startTicks = Log.VIEWMODEL("Enter", Common.LOG_APPNAME);

            var lookupF = await _lookupDataService.Get$customTYPE$LookupAsync();
            $customTYPE$s.Clear();

            foreach (var item in lookupF)
            {
                $customTYPE$s.Add(
                    new NavigationItemViewModel(item.Id, item.DisplayMember, 
                    nameof($customTYPE$DetailViewModel),
                    _eventAggregator));
            }

            Log.VIEWMODEL("Exit", Common.LOG_APPNAME, startTicks);
        }

        private void AfterDetailSaved(AfterDetailSavedEventArgs args)
        {
            Int64 startTicks = Log.EVENT("Enter", Common.LOG_APPNAME);

            switch (args.ViewModelName)
            {
                case nameof($customTYPE$DetailViewModel):
                    AfterDetailSaved($customTYPE$s, args);
                    break;

                default:
                    throw new System.Exception($"AfterDetailSaved(): ViewModel {args.ViewModelName} not mapped.");
            }

            Log.EVENT("Exit", Common.LOG_APPNAME, startTicks);
        }

        // TODO(crhodes)
        // Can't this be pushed down to base class?
        
        private void AfterDetailSaved(ObservableCollection<NavigationItemViewModel> items,
            AfterDetailSavedEventArgs args)
        {
            Int64 startTicks = Log.EVENT("Enter", Common.LOG_APPNAME);

            var lookupItem = items.SingleOrDefault(l => l.Id == args.Id);

            if (lookupItem == null)
            {
                items.Add(new NavigationItemViewModel(args.Id, args.DisplayMember,
                    args.ViewModelName,
                    _eventAggregator));
            }
            else
            {
                lookupItem.DisplayMember = args.DisplayMember;
            }

            Log.EVENT("Exit", Common.LOG_APPNAME, startTicks);
        }

        private void AfterDetailDeleted(AfterDetailDeletedEventArgs args)
        {
            Int64 startTicks = Log.EVENT("Enter", Common.LOG_APPNAME);

            switch (args.ViewModelName)
            {
                case nameof($customTYPE$DetailViewModel):
                    AfterDetailDeleted($customTYPE$s, args);
                    break;

                default:
                    throw new System.Exception($"AfterDetailDeleted(): ViewModel {args.ViewModelName} not mapped.");
            }

            Log.EVENT("Exit", Common.LOG_APPNAME, startTicks);
        }

        // TODO(crhodes)
        // Can't this be pushed down to base class?
        
        void AfterDetailDeleted(ObservableCollection<NavigationItemViewModel> items,
            AfterDetailDeletedEventArgs args)
        {
            Int64 startTicks = Log.EVENT("Enter", Common.LOG_APPNAME);

            var lookupItem = items.SingleOrDefault(f => f.Id == args.Id);

            if (lookupItem != null)
            {
                items.Remove(lookupItem);
            }

            Log.EVENT("Exit", Common.LOG_APPNAME, startTicks);
        }
    }
}
