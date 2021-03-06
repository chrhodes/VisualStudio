﻿using System;
using System.Windows;

using $customAPPLICATION$.ViewModels;

using VNC;

namespace $customAPPLICATION$.Presentation.Views
{
    public partial class MainWindowDxDockLayoutManager : Window
    {
        public MainWindowDxDockLayoutManagerViewModel _viewModel;

        public MainWindowDxDockLayoutManager(MainWindowDxDockLayoutManagerViewModel viewModel)
        {
            Int64 startTicks = Log.Trace(String.Format("Enter"), Common.LOG_APPNAME);

            InitializeComponent();

            _viewModel = viewModel;
            DataContext = _viewModel;

            Log.Trace(String.Format("Exit"), Common.LOG_APPNAME, startTicks);
        }
    }
}
