using Prism.Modularity;
using Prism.Regions;
using ModuleInterfaces;
using Prism.Ioc;
using Unity;

namespace VNCPrism7ModuleBase
{
    public class ModuleVNCPrism7Module : IModule
    {
        private readonly IRegionManager _regionManager;
        private readonly IUnityContainer _container;

        public ModuleVNCPrism7Module(IUnityContainer container, IRegionManager regionManager)
        {
            _container = container;
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            RegisterViewsAndServices();

            // CompositeCommand Example
            // This is for TabControl multiple view 

            //IRegion region = _regionManager.Regions[RegionNames.ContentRegionC_CC];

            //var vm = _container.Resolve<IPersonViewModel>();
            //vm.CreatePerson("Bob", "Smith");

            //region.Add(vm.View);
            //region.Activate(vm.View);

            //var vm2 = _container.Resolve<IPersonViewModel>();
            //vm2.CreatePerson("Karl", "Sums");
            //region.Add(vm2.View);

            //var vm3 = _container.Resolve<IPersonViewModel>();
            //vm3.CreatePerson("Jeff", "Lock");
            //region.Add(vm3.View);
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            throw new System.NotImplementedException();
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            throw new System.NotImplementedException();
        }

        protected void RegisterViewsAndServices()
        {
            _container.RegisterType<IPersonViewModel, PersonViewModel>();
            _container.RegisterType<IPerson, Person>();
        }
    }
}