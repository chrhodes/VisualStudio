﻿//using Microsoft.Practices.Prism.Modularity;
//using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
//using Unity;

namespace $safeprojectname$
{
    public abstract class ModuleBase : IModule
    {
        protected IRegionManager RegionManager { get; private set; }
        protected IUnityContainer Container { get; private set; }

        public ModuleBase(IUnityContainer container, IRegionManager regionManager)
        {
            Container = container;
            RegionManager = regionManager;
        }

        public void Initialize()
        {
            RegisterTypes();
            InitializeModule();
        }

        protected abstract void InitializeModule();

        protected abstract void RegisterTypes();
    }
}
