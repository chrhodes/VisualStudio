using System.Collections.Generic;
using System.Threading.Tasks;

using VNC.Core.DomainServices;

namespace APPLICATION.DomainServices
{
    public interface ITYPELookupDataService
    {
        Task<IEnumerable<LookupItem>> GetTYPELookupAsync();
    }
}
