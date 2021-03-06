﻿using System;
using System.Windows.Input;

using Prism.Commands;
using Prism.Events;

using $customAPPLICATION$.Core.Events;

using VNC;
using VNC.Core.Mvvm;
using VNC.Core.Events;

namespace $customAPPLICATION$.Presentation.ViewModels
{
    public class NavigationItemViewModel : ViewModelBase
    {
        private IEventAggregator _eventAggregator;

        private string _displayMember;
        private string _detailViewModelName;

        public NavigationItemViewModel(
            int id,
            string displayMember,
            string detailViewModelName,
            IEventAggregator eventAggregator)
        {
            Int64 startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_APPNAME);

            Id = id;
            DisplayMember = displayMember;
            _detailViewModelName = detailViewModelName;
            _eventAggregator = eventAggregator;

            OpenDetailViewCommand = new DelegateCommand(OnOpenDetailViewExecute);

            Log.COnSTRUCTOR("Exit", Common.LOG_APPNAME, startTicks);
        }

        public int Id { get; set; }

        public string DisplayMember
        {
            get { return _displayMember; }
            set
            {
                if (_displayMember == value)
                    return;
                _displayMember = value;
                OnPropertyChanged();
            }
        }

        public ICommand OpenDetailViewCommand { get; }

        private void OnOpenDetailViewExecute()
        {
            Int64 startTicks = Log.EVENT(String.Format("Enter"), Common.LOG_APPNAME);

            switch (_detailViewModelName)
            {
                // case nameof(CatDetailViewModel):
                    // _eventAggregator.GetEvent<OpenCatDetailViewEvent>()
                      // .Publish
                        // (
                            // new OpenDetailViewEventArgs
                            // {
                                // Id = Id,
                                // ViewModelName = _detailViewModelName
                            // }
                        // );
                    // break;

                case nameof($customTYPE$DetailViewModel):
                    _eventAggregator.GetEvent<Open$customTYPE$DetailViewEvent>()
                      .Publish
                        (
                            new OpenDetailViewEventArgs
                            {
                                Id = Id,
                                ViewModelName = _detailViewModelName
                            }
                        );
                    break;
            }

            //_eventAggregator.GetEvent<OpenDetailViewEvent>()
            //      .Publish
            //        (
            //            new OpenDetailViewEventArgs
            //            {
            //                Id = Id,
            //                ViewModelName = _detailViewModelName
            //            }
            //        );

            Log.EVENT(String.Format("Exit"), Common.LOG_APPNAME, startTicks);
        }
    }
}

