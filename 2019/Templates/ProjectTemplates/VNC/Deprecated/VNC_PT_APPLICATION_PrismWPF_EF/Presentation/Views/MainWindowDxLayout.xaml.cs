﻿using System;
using System.Windows;

using $customAPPLICATION$.ViewModels;

using VNC;

namespace $customAPPLICATION$.Presentation.Views
{
    public partial class MainWindowDxLayout : Window
    {
        public MainWindowDxLayoutViewModel _viewModel;

        public MainWindowDxLayout(MainWindowDxLayoutViewModel viewModel)
        {
            Int64 startTicks = Log.Trace(String.Format("Enter"), Common.LOG_APPNAME);

            InitializeComponent();

            _viewModel = viewModel;
            DataContext = _viewModel;

            Loaded += MainWindowDxLayout_Loaded;

            Log.Trace(String.Format("Exit"), Common.LOG_APPNAME, startTicks);
        }

        // Load ViewModel asynchronously

        private async void MainWindowDxLayout_Loaded(object sender, RoutedEventArgs e)
        {
            Int64 startTicks = Log.Trace(String.Format("Enter"), Common.LOG_APPNAME);

            //_viewModel.Load();
            //await _viewModel.LoadAsync();

            Log.Trace(String.Format("Exit"), Common.LOG_APPNAME, startTicks);
        }
    }
}
