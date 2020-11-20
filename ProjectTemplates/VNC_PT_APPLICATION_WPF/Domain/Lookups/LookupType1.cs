using VNC.Core.DomainServices;

namespace VNC_PT_APPLICATION_WPF.Domain.Lookups
{
    public class LookupType1 : ILookupItem<int>
    {
        public int Id { get; set; }
        public string DisplayMember { get; set; }
    }
}
