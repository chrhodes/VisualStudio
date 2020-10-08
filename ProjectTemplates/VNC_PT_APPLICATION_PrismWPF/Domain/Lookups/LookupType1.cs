using VNC.Core.Domain;

namespace VNC_PT_APPLICATION_PrismWPF.Domain.Lookups
{
    public class LookupType1 : ILookupItem<int>
    {
        public int Id { get; set; }
        public string DisplayMember { get; set; }
    }
}
