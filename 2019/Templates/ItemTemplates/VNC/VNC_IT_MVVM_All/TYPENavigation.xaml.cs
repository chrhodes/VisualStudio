﻿using System;

using VNC;
using VNC.Core.Mvvm;

namespace $xxxAPPLICATIONxxx$.Presentation.Views
{
    public partial class $xxxTYPExxx$Navigation : ViewBase, I$xxxTYPExxx$Navigation, IInstanceCountV
    {
        public $xxxTYPExxx$Navigation()
        {
            Int64 startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_APPNAME);

            InstanceCountV++;
            InitializeComponent();

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
