using System.Collections.Generic;
using System.Threading.Tasks;

using VNC.Core.Domain;

namespace VNC_PT_APPLICATION_WPF.DomainServices
{
    public interface ITYPELookupDataService
    {
        Task<IEnumerable<LookupItem>> GetTYPELookupAsync();
    }
}
