using Prism.Ioc;
using Prism.Modularity;

namespace VNC_PT_APPLICATION.DomainServices
{
    public class VNC_PT_APPLICATIONServicesModule : IModule
    {
        IContainerProvider _containerProvider;

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _containerProvider = containerProvider;
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // TODO(crhodes)
            // Maybe this is where we register the CustomPoolAndSpaDbContext

            //throw new NotImplementedException();
        }
    }
}
