using Prism.Regions;

namespace $safeprojectname$.Prism
{
    public interface IRegionManagerAware
    {
        IRegionManager RegionManager { get; set; }
    }
}
