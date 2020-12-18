using VNC.Core.Domain;

namespace $safeprojectname$.Domain.Lookups
{
    public class LookupTYPE : ILookupItem<int>
    {
        public int Id { get; set; }
        public string DisplayMember { get; set; }
    }
}
