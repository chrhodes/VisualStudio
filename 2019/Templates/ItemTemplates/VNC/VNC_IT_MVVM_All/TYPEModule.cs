using System;

using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

using Unity;

using $xxxAPPLICATIONxxx$.Core;
using $xxxAPPLICATIONxxx$.DomainServices;
using $xxxAPPLICATIONxxx$.Presentation.Views;
using $xxxAPPLICATIONxxx$.Presentation.ViewModels;

using VNC;
namespace $xxxAPPLICATIONxxx$
{
    public class $xxxTYPExxx$Module : IModule
    {
        private readonly IRegionManager _regionManager;

        // 01

        public $xxxTYPExxx$Module(IRegionManager regionManager)
        {
            Int64 startTicks = Log.CONSTRUCTOR("Enter", Common.LOG_APPNAME);

            _regionManager = regionManager;

            Log.CONSTRUCTOR("Exit", Common.LOG_APPNAME, startTicks);
        }

        // 02

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            Int64 startTicks = Log.MODULE("Enter", Common.LOG_APPNAME);

            containerRegistry.Register<I$xxxTYPExxx$MainViewModel, $xxxTYPExxx$MainViewModel>();
            containerRegistry.RegisterSingleton<I$xxxTYPExxx$Main, $xxxTYPExxx$Main>();

            containerRegistry.Register<I$xxxTYPExxx$NavigationViewModel, $xxxTYPExxx$NavigationViewModel>();
            containerRegistry.RegisterSingleton<I$xxxTYPExxx$Navigation, $xxxTYPExxx$Navigation>();

            containerRegistry.Register<I$xxxTYPExxx$DetailViewModel, $xxxTYPExxx$DetailViewModel>();
            containerRegistry.RegisterSingleton<I$xxxTYPExxx$Detail, $xxxTYPExxx$Detail>();

            containerRegistry.RegisterSingleton<I$xxxTYPExxx$LookupDataService, $xxxTYPExxx$LookupDataService>();
            containerRegistry.Register<I$xxxTYPExxx$DataService, $xxxTYPExxx$DataService>();

            Log.MODULE("Exit", Common.LOG_APPNAME, startTicks);
        }

        // 03

        public void OnInitialized(IContainerProvider containerProvider)
        {
            Int64 startTicks = Log.MODULE("Enter", Common.LOG_APPNAME);

            // NOTE(crhodes)
            // using typeof(TYPE) calls constructor
            // using typeof(ITYPE) resolves type (see RegisterTypes)

            //this loads $xxxTYPExxx$Main into the Shell loaded in CreateShell() in App.Xaml.cs
            _regionManager.RegisterViewWithRegion(RegionNames.$xxxTYPExxx$MainRegion, typeof(I$xxxTYPExxx$Main));

            // These load into $xxxTYPExxx$Main.xaml
            _regionManager.RegisterViewWithRegion(RegionNames.$xxxTYPExxx$NavigationRegion, typeof(I$xxxTYPExxx$Navigation));
            _regionManager.RegisterViewWithRegion(RegionNames.$xxxTYPExxx$DetailRegion, typeof(I$xxxTYPExxx$Detail));

            Log.MODULE("Exit", Common.LOG_APPNAME, startTicks);
        }

        // TODO(crhodes)
        // Place these in Core\RegionNames.cs

        public static string $xxxTYPExxx$MainRegion = "$xxxTYPExxx$MainRegion";
        public static string $xxxTYPExxx$NavigationRegion = "$xxxTYPExxx$NavigationRegion";
        public static string $xxxTYPExxx$DetailRegion = "$xxxTYPExxx$DetailRegion";

        // TODO(crhodes)
        // Add this to App.xaml.cs - ConfigureModuleCatalog()

        moduleCatalog.AddModule(typeof($xxxTYPExxx$Module));
    }
}