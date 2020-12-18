﻿using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

using Prism.Events;

using $customAPPLICATION$.DomainServices;

using VNC;
using VNC.Core.Events;
using VNC.Core.Mvvm;
using VNC.Core.Services;

namespace $customAPPLICATION$.Presentation.ViewModels
{
    public class $customTYPE$NavigationViewModel : EventViewModelBase, I$customTYPE$NavigationViewModel, IInstanceCountVM
    {

        #region Constructors, Initialization, and Load

        public $customTYPE$NavigationViewModel(
                IEventAggregator eventAggregator,
                IMessageDialogService messageDialogService,
                I$customTYPE$LookupDataService lookupDataService) : base(eventAggregator, messageDialogService)
        {
            Int64 startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_APPNAME);

            InstanceCountVM++;

            _lookupDataService = lookupDataService;

            $customTYPE$s = new ObservableCollection<NavigationItemViewModel>();

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

        private I$customTYPE$LookupDataService _lookupDataService;

        public ObservableCollection<NavigationItemViewModel> $customTYPE$s { get; }

        #endregion

        #region Event Handlers

        private void AfterDetailSaved(AfterDetailSavedEventArgs args)
        {
            Int64 startTicks = Log.EVENT_HANDLER($"Enter Id:({args.Id})", Common.LOG_APPNAME);

            switch (args.ViewModelName)
            {
                case nameof($customTYPE$DetailViewModel):
                    AfterDetailSaved($customTYPE$s, args);
                    break;

                default:
                    throw new System.Exception($"AfterDetailSaved(): ViewModel {args.ViewModelName} not mapped.");
            }

            Log.EVENT_HANDLER("Exit", Common.LOG_APPNAME, startTicks);
        }

        private void AfterDetailDeleted(AfterDetailDeletedEventArgs args)
        {
            Int64 startTicks = Log.EVENT_HANDLER($"Enter Id:({args.Id})", Common.LOG_APPNAME);

            switch (args.ViewModelName)
            {
                case nameof($customTYPE$DetailViewModel):
                    AfterDetailDeleted($customTYPE$s, args);
                    break;

                default:
                    throw new System.Exception($"AfterDetailDeleted(): ViewModel {args.ViewModelName} not mapped.");
            }

            Log.EVENT_HANDLER("Exit", Common.LOG_APPNAME, startTicks);
        }

        #endregion

        #region Public Methods

        public async Task LoadAsync()
        {
            Int64 startTicks = Log.VIEWMODEL("($customTYPE$NavigationViewModel) Enter", Common.LOG_APPNAME);

            var lookupF = await _lookupDataService.Get$customTYPE$LookupAsync();
            $customTYPE$s.Clear();

            foreach (var item in lookupF)
            {
                $customTYPE$s.Add(
                    new NavigationItemViewModel(item.Id, item.DisplayMember,
                    nameof($customTYPE$DetailViewModel),
                    EventAggregator, MessageDialogService));
            }

            Log.VIEWMODEL("($customTYPE$NavigationViewModel) Exit", Common.LOG_APPNAME, startTicks);
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