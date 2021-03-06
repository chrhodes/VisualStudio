﻿using System;

using VNC;
using VNC.Core.Mvvm;

namespace $xxxAPPLICATIONxxx$.Presentation.Views
{
    public partial class $xxxITEMxxx$Detail : ViewBase, I$xxxITEMxxx$Detail, IInstanceCountV
    {

        public $xxxITEMxxx$Detail()
        {
            Int64 startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_APPNAME);

            InstanceCountV++;
            InitializeComponent();

            Log.CONSTRUCTOR("Exit", Common.LOG_APPNAME, startTicks);
        }

        public $xxxITEMxxx$Detail(ViewModels.I$xxxITEMxxx$DetailViewModel viewModel)
        {
            Int64 startTicks = Log.CONSTRUCTOR($"Enter ({viewModel.GetType()})", Common.LOG_APPNAME);

            InstanceCountV++;
            InitializeComponent();
            ViewModel = viewModel;

            Log.CONSTRUCTOR("Exit", Common.LOG_APPNAME, startTicks);
        }

        #region IInstanceCount

        private static int _instanceCountV;

        public int InstanceCountV
        {
            get => _instanceCountV;
            set => _instanceCountV = value;
        }

        #endregion

    }
}
