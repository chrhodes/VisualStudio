using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

using Unity;

using VNC_PT_APPLICATION.Core;
using VNC_PT_APPLICATION.DomainServices;

namespace VNC_PT_APPLICATION.Presentation.TYPE
{
    public class TYPEModule : IModule
    {
        private readonly IRegionManager _regionManager;
        private readonly IUnityContainer _container;

        // 01

        public TYPEModule(IUnityContainer container, IRegionManager regionManager)
        {
            _container = container;
            _regionManager = regionManager;
        }

        // 02

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // TODO(crhodes)
            // Should we be registering stuff here and not in App.Xaml.cs
            _container.RegisterType<ViewModels.ITYPEDetailViewModel, ViewModels.TYPEDetailViewModel>();
            _container.RegisterType<Views.ITYPEDetail, Views.TYPEDetail>();

            _container.RegisterType<ITYPEDataService, TYPEDataService>();

            _container.RegisterType<ViewModels.ITYPEViewModel, ViewModels.TYPEViewModel>();
            _container.RegisterType<Views.ITYPE, Views.TYPE>();

            _container.RegisterType<ITYPELookupDataService, TYPELookupDataService>();
        }

        // 03

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.TYPERegion, typeof(Views.TYPE));
            _regionManager.RegisterViewWithRegion(RegionNames.TYPEDetailRegion, typeof(Views.TYPEDetail));
        }
    }
}