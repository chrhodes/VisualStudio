using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

using Unity;

using APPLICATION.Core;
using APPLICATION.DomainServices;

namespace APPLICATION
{
    public class TYPEModule : IModule
    {
        private readonly IRegionManager _regionManager;
        //private readonly IUnityContainer _container;

        // 01

        public TYPEModule(IRegionManager regionManager)
        {
            //_container = container;
            _regionManager = regionManager;
        }

        // 02

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<Presentation.ViewModels.ITYPEDetailViewModel, Presentation.ViewModels.TYPEDetailViewModel>();
            containerRegistry.Register<Presentation.Views.ITYPEDetail, Presentation.Views.TYPEDetail>();

            containerRegistry.Register<ITYPEDataService, TYPEDataService>();

            containerRegistry.Register<Presentation.ViewModels.ITYPEViewModel, Presentation.TYPE.ViewModels.TYPEViewModel>();
            containerRegistry.Register<Presentation.Views.ITYPE, Presentation.Views.TYPE>();

            containerRegistry.Register<ITYPELookupDataService, LookupDataService>();
        }

        // 03

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.TYPERegion, typeof(Presentation.Views.TYPE));
            _regionManager.RegisterViewWithRegion(RegionNames.TYPEDetailRegion, typeof(Presentation.Views.TYPEDetail));
        }
    }
}