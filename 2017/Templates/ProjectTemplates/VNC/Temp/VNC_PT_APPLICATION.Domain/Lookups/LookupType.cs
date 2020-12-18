using VNC.Core.Domain;

namespace $safeprojectname$.Lookups
{
    public class LookupType : ILookupItem<int>
    {
        public int Id { get; set; }
        public string DisplayMember { get; set; }
    }
}
