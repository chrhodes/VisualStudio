﻿using System;

using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

using Unity;

using $customAPPLICATION$.Core;
using $customAPPLICATION$.DomainServices;
using $customAPPLICATION$.Presentation.Views;
using $customAPPLICATION$.Presentation.ViewModels;

using VNC;
namespace $customAPPLICATION$
{
    public class $customTYPE$Module : IModule
    {
        private readonly IRegionManager _regionManager;

        // 01

        public $customTYPE$Module(IRegionManager regionManager)
        {
            Int64 startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_APPNAME);

            _regionManager = regionManager;

            Log.CONSTRUCTOR("Exit", Common.LOG_APPNAME, startTicks);
        }

        // 02

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            Int64 startTicks = Log.MODULE("Enter", Common.LOG_APPNAME);

            containerRegistry.Register<I$customTYPE$MainViewModel, $customTYPE$MainViewModel>();
            containerRegistry.RegisterSingleton<I$customTYPE$Main, $customTYPE$Main>();
            
            containerRegistry.Register<I$customTYPE$NavigationViewModel, $customTYPE$NavigationViewModel>();
            containerRegistry.RegisterSingleton<I$customTYPE$Navigation, $customTYPE$Navigation>();  
            
            containerRegistry.Register<I$customTYPE$DetailViewModel, $customTYPE$DetailViewModel>();
            containerRegistry.RegisterSingleton<I$customTYPE$Detail, $customTYPE$Detail>();

            containerRegistry.RegisterSingleton<I$customTYPE$LookupDataService, $customTYPE$LookupDataService>();
            containerRegistry.Register<I$customTYPE$DataService, $customTYPE$DataService>();

            Log.MODULE("Exit", Common.LOG_APPNAME, startTicks);
        }

        // 03

        public void OnInitialized(IContainerProvider containerProvider)
        {
            Int64 startTicks = Log.MODULE("Enter", Common.LOG_APPNAME);

            // NOTE(crhodes)
            // using typeof(TYPE) calls constructor
            // using typeof(ITYPE) resolves type (see RegisterTypes)
            
            //this loads $customTYPE$Main into the Shell loaded in CreateShell() in App.Xaml.cs
            _regionManager.RegisterViewWithRegion(RegionNames.$customTYPE$MainRegion, typeof(I$customTYPE$Main));

            // These load into $customTYPE$Main.xaml
            _regionManager.RegisterViewWithRegion(RegionNames.$customTYPE$NavigationRegion, typeof(I$customTYPE$Navigation));
            _regionManager.RegisterViewWithRegion(RegionNames.$customTYPE$DetailRegion, typeof(I$customTYPE$Detail));

            Log.MODULE("Exit", Common.LOG_APPNAME, startTicks);
        }
    }
}