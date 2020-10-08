using Prism.Regions;

namespace Infrastructure1.Prism
{
    public interface IRegionManagerAware
    {
        IRegionManager RegionManager { get; set; }
    }
}
