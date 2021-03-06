﻿using System;
using System.Threading;
using System.Windows;

using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Prism.Unity;
using $customAPPLICATION$.DomainServices;
using $customAPPLICATION$.Presentation.Views;

using VNC;
using VNC.Core.Services;

namespace $customAPPLICATION$
{
    public partial class App : PrismApplication
    {
        public App()
        {
            // HACK(crhodes)
            // If don't delay a bit here, the SignarlR logging infrastructure does not initialize quickly enough
            // and the first few log messsages are missed.
            // NB.  All are properly recored in the log file.
            Int64 startTicks = Log.APPLICATION_START("App()", Common.LOG_APPNAME);
            Thread.Sleep(250);
            Log.APPLICATION_START(String.Format("Exit"), Common.LOG_APPNAME, startTicks);
        }
        // 01

        protected override void ConfigureViewModelLocator()
        {
            Int64 startTicks = Log.APPLICATION_INITIALIZE("Enter", Common.LOG_APPNAME);

            base.ConfigureViewModelLocator();

            Log.APPLICATION_INITIALIZE("Exit", Common.LOG_APPNAME, startTicks);
        }

        // 02

        protected override IContainerExtension CreateContainerExtension()
        {
            Int64 startTicks = Log.APPLICATION_INITIALIZE("Enter", Common.LOG_APPNAME);

            Log.APPLICATION_INITIALIZE("Exit", Common.LOG_APPNAME, startTicks);

            return base.CreateContainerExtension();
        }

        // 03 - Create the catalog of Modules

        protected override IModuleCatalog CreateModuleCatalog()
        {
            Int64 startTicks = Log.APPLICATION_INITIALIZE("Enter", Common.LOG_APPNAME);

            Log.APPLICATION_INITIALIZE("Exit", Common.LOG_APPNAME, startTicks);

            return base.CreateModuleCatalog();
        }

        // 04

        protected override void RegisterRequiredTypes(IContainerRegistry containerRegistry)
        {
            Int64 startTicks = Log.APPLICATION_INITIALIZE("Enter", Common.LOG_APPNAME);

            base.RegisterRequiredTypes(containerRegistry);

            Log.APPLICATION_INITIALIZE("Exit", Common.LOG_APPNAME, startTicks);
        }

        // 05

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            Int64 startTicks = Log.APPLICATION_INITIALIZE("Enter", Common.LOG_APPNAME);

            //containerRegistry.RegisterSingleton<ICustomerDataService, CustomerDataServiceMock>();
            //containerRegistry.RegisterSingleton<IMaterialDataService, MaterialDataServiceMock>();

            // TODO(crhodes)
            // Think this is where we switch to using the Generic Repository.
            // But how to avoid pulling knowledge of EF Context in.  Maybe Service hides details
            // of
            //containerRegistry.RegisterSingleton<IAddressDataService, AddressDataService>();
            // AddressDataService2 has a constructor that takes a CustomPoolAndSpaDbContext.

            //containerRegistry.RegisterSingleton<I$customTYPE$LookupDataService, $customTYPE$LookupDataService>();
            containerRegistry.Register<IMessageDialogService, MessageDialogService>();

            // Add the new UI elements

            Log.APPLICATION_INITIALIZE("Exit", Common.LOG_APPNAME, startTicks);
        }

        // 06

        protected override void ConfigureServiceLocator()
        {
            Int64 startTicks = Log.APPLICATION_INITIALIZE("Enter", Common.LOG_APPNAME);

            base.ConfigureServiceLocator();

            Log.APPLICATION_INITIALIZE("Exit", Common.LOG_APPNAME, startTicks);
        }

        // 07 - Configure the catalog of modules
        // Modules are loaded at Startup and must be a project reference

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            Int64 startTicks = Log.APPLICATION_INITIALIZE("Enter", Common.LOG_APPNAME);

            moduleCatalog.AddModule(typeof($customTYPE$Module));
            // moduleCatalog.AddModule(typeof(TYPEModule));

            Log.APPLICATION_INITIALIZE("Exit", Common.LOG_APPNAME, startTicks);
        }

        // 08

        protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings)
        {
            Int64 startTicks = Log.APPLICATION_INITIALIZE("Enter", Common.LOG_APPNAME);

            base.ConfigureRegionAdapterMappings(regionAdapterMappings);

            Log.APPLICATION_INITIALIZE("Exit", Common.LOG_APPNAME, startTicks);
        }

        // 09

        protected override void ConfigureDefaultRegionBehaviors(IRegionBehaviorFactory regionBehaviors)
        {
            Int64 startTicks = Log.APPLICATION_INITIALIZE("Enter", Common.LOG_APPNAME);

            base.ConfigureDefaultRegionBehaviors(regionBehaviors);

            Log.APPLICATION_INITIALIZE("Exit", Common.LOG_APPNAME, startTicks);
        }

        // 10

        protected override void RegisterFrameworkExceptionTypes()
        {
            Int64 startTicks = Log.APPLICATION_INITIALIZE("Enter", Common.LOG_APPNAME);

            base.RegisterFrameworkExceptionTypes();

            Log.APPLICATION_INITIALIZE("Exit", Common.LOG_APPNAME, startTicks);
        }

        // 11

        protected override Window CreateShell()
        {
            Int64 startTicks = Log.APPLICATION_INITIALIZE("Enter", Common.LOG_APPNAME);

            Log.APPLICATION_INITIALIZE("Exit", Common.LOG_APPNAME, startTicks);

            //return Container.Resolve<MainWindow>();
            return Container.Resolve<MainWindowDxLayout>();
            //return Container.Resolve<MainWindowDxDockLayoutManager>();
        }

        // 12

        protected override void InitializeShell(Window shell)
        {
            Int64 startTicks = Log.APPLICATION_INITIALIZE("Enter", Common.LOG_APPNAME);

            base.InitializeShell(shell);

            Log.APPLICATION_INITIALIZE("Exit", Common.LOG_APPNAME, startTicks);
        }

        // 13

        protected override void InitializeModules()
        {
            Int64 startTicks = Log.APPLICATION_INITIALIZE("Enter", Common.LOG_APPNAME);

            base.InitializeModules();

            Log.APPLICATION_INITIALIZE("Exit", Common.LOG_APPNAME, startTicks);
        }

        private void Application_DispatcherUnhandledException(object sender,
            System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            Log.Error("Unexpected error occurred. Please inform the admin."
              + Environment.NewLine + e.Exception.Message, Common.LOG_APPNAME);
              
            MessageBox.Show("Unexpected error occurred. Please inform the admin."
              + Environment.NewLine + e.Exception.Message, "Unexpected error");

            e.Handled = true;
        }
    }
}
