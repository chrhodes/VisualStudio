﻿using System.Windows;

using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using Prism.Regions;

using $customAPPLICATION$.DomainServices;
using $customAPPLICATION$.Presentation.$customTYPE$;

namespace $safeprojectname$
{
    public partial class App : PrismApplication
    {
        // 01

        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();
        }

        // 02

        protected override IContainerExtension CreateContainerExtension()
        {
            return base.CreateContainerExtension();
        }

        // 03 - Create the catalog of Modules

        protected override IModuleCatalog CreateModuleCatalog()
        {
            return base.CreateModuleCatalog();
        }

        // 04

        protected override void RegisterRequiredTypes(IContainerRegistry containerRegistry)
        {
            base.RegisterRequiredTypes(containerRegistry);
        }

        // 05

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //containerRegistry.RegisterSingleton<ICustomerDataService, CustomerDataServiceMock>();
            //containerRegistry.RegisterSingleton<IMaterialDataService, MaterialDataServiceMock>();

            // TODO(crhodes)
            // Think this is where we switch to using the Generic Repository.
            // But how to avoid pulling knowledge of EF Context in.  Maybe Service hides details
            // of 
            //containerRegistry.RegisterSingleton<IAddressDataService, AddressDataService>();
            // AddressDataService2 has a constructor that takes a CustomPoolAndSpaDbContext.

            containerRegistry.RegisterSingleton<I$customTYPE$DataService, $customTYPE$DataService>();
            containerRegistry.RegisterSingleton<I$customTYPE$LookupDataService, $customTYPE$LookupDataService>();

            // Add the new UI elements
        }

        // 06

        protected override void ConfigureServiceLocator()
        {
            base.ConfigureServiceLocator();
        }

        // 07 - Configure the catalog of modules
        // Modules are loaded at Startup and must be a project reference

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            //moduleCatalog.AddModule(typeof(CustomPoolAndSpaServicesModule));
            moduleCatalog.AddModule(typeof($customTYPE$Module));
        }

        // 08

        protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings)
        {
            base.ConfigureRegionAdapterMappings(regionAdapterMappings);
        }

        // 09

        protected override void ConfigureDefaultRegionBehaviors(IRegionBehaviorFactory regionBehaviors)
        {
            base.ConfigureDefaultRegionBehaviors(regionBehaviors);
        }

        // 10

        protected override void RegisterFrameworkExceptionTypes()
        {
            base.RegisterFrameworkExceptionTypes();
        }

        // 11 

        protected override Window CreateShell()
        {
            return Container.Resolve<Views.MainWindowDx>();
        }

        // 12

        protected override void InitializeShell(Window shell)
        {
            base.InitializeShell(shell);
        }

        // 13 

        protected override void InitializeModules()
        {
            base.InitializeModules();
        }
    }
}
