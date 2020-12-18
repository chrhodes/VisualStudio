﻿using System;

using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

using $customAPPLICATION$.Core;
using $customAPPLICATION$.DomainServices;
using $customAPPLICATION$.Presentation.ViewModels;
using $customAPPLICATION$.Presentation.Views;

using Unity;

using VNC;

namespace $customAPPLICATION$
{
    public class $customAPPLICATION$Module : IModule
    {
        private readonly IRegionManager _regionManager;

        // 01

        public $customAPPLICATION$Module(IRegionManager regionManager)
        {
            Int64 startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_APPNAME);

            _regionManager = regionManager;

            Log.CONSTRUCTOR("Exit", Common.LOG_APPNAME, startTicks);
        }

        // 02

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            Int64 startTicks = Log.MODULE("Enter", Common.LOG_APPNAME);

            containerRegistry.Register<ICombinedMainViewModel, CombinedMainViewModel>();
            containerRegistry.Register<ICombinedMain, CombinedMain>();

            containerRegistry.Register<ICombinedNavigationViewModel, CombinedNavigationViewModel>();
            containerRegistry.Register<ICombinedNavigation, CombinedNavigation>();

            Log.MODULE("Exit", Common.LOG_APPNAME, startTicks);
        }

        // 03

        public void OnInitialized(IContainerProvider containerProvider)
        {
            Int64 startTicks = Log.MODULE("Enter", Common.LOG_APPNAME);

            //This loads CombinedMain into the Shell loaded in App.Xaml.cs
            _regionManager.RegisterViewWithRegion(RegionNames.CombinedMainRegion, typeof(ICombinedMain));

            // These load into CombinedMain.xaml
            _regionManager.RegisterViewWithRegion(RegionNames.CombinedNavigationRegion, typeof(ICombinedNavigation));

            Log.MODULE("Exit", Common.LOG_APPNAME, startTicks);
        }
    }
}