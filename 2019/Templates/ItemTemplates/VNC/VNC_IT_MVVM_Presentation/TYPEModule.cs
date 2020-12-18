using System;

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
        //private readonly IUnityContainer _container;

        // 01

        public $customTYPE$Module(IRegionManager regionManager)
        {
            Int64 startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_APPNAME);

            //_container = container;
            _regionManager = regionManager;

            Log.CONSTRUCTOR("Exit", Common.LOG_APPNAME, startTicks);
        }

        // 02

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            Int64 startTicks = Log.MODULE("Enter", Common.LOG_APPNAME);

            containerRegistry.Register<I$customTYPE$MainViewModel, $customTYPE$MainViewModel>();
            containerRegistry.Register<I$customTYPE$Main, $customTYPE$Main>();
            
            containerRegistry.RegisterSingleton<I$customTYPE$NavigationViewModel, $customTYPE$NavigationViewModel>();
            containerRegistry.RegisterSingleton<I$customTYPE$Navigation, $customTYPE$Navigation>();            
            
            containerRegistry.Register<I$customTYPE$DetailViewModel, $customTYPE$DetailViewModel>();
            containerRegistry.Register<I$customTYPE$Detail, $customTYPE$Detail>();

            // containerRegistry.RegisterSingleton<I$customTYPE$LookupDataService, $customTYPE$LookupDataService>();
            // containerRegistry.RegisterSingleton<I$customTYPE$DataService, $customTYPE$DataService>();

            Log.MODULE("Exit", Common.LOG_APPNAME, startTicks);
        }

        // 03

        public void OnInitialized(IContainerProvider containerProvider)
        {
            Int64 startTicks = Log.MODULE("Enter", Common.LOG_APPNAME);

            // NOTE(crhodes)
            // using typeof(TYPE) calls constructor
            // using typeof(ITYPE) resolves type (see RegisterTypes)
            
            //this loads $customTYPE$Main into the Shell loaded in App.Xaml.cs
            _regionManager.RegisterViewWithRegion(RegionNames.$customTYPE$MainRegion, typeof(I$customTYPE$Main));

            // These load into $customTYPE$Main.xaml
            _regionManager.RegisterViewWithRegion(RegionNames.$customTYPE$NavigationRegion, typeof(I$customTYPE$Navigation));
            _regionManager.RegisterViewWithRegion(RegionNames.$customTYPE$DetailRegion, typeof(I$customTYPE$Detail));

            Log.MODULE("Exit", Common.LOG_APPNAME, startTicks);
        }
        
        TODO(crhodes) Place these in Core\RegionNames.cs
        
        //public static string $customTYPE$MainRegion = "$customTYPE$MainRegion";
        //public static string $customTYPE$NavigationRegion = "$customTYPE$NavigationRegion";
        //public static string $customTYPE$DetailRegion = "$customTYPE$DetailRegion";
        
        TODO(crhodes) Add this to App.xaml.cs - ConfigureModuleCatalog
        
        moduleCatalog.AddModule(typeof($customTYPE$Module));
    }
}