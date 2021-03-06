﻿using System;
using System.Windows;

using $customAPPLICATION$.ViewModels;

using VNC;

namespace $customAPPLICATION$.Presentation.Views
{
    public partial class MainWindow : Window
    {
        public MainWindowViewModel _viewModel;
        
        public MainWindow(MainWindowViewModel viewModel)
        {
            Int64 startTicks = Log.Trace(String.Format("Enter"), Common.LOG_APPNAME);

            InitializeComponent();
            
            _viewModel = viewModel;
            DataContext = _viewModel;

            Log.Trace(String.Format("Exit"), Common.LOG_APPNAME, startTicks);
        }
    }
}
