using System.Collections.Generic;
using System.Threading.Tasks;

using VNC.Core.Domain;

namespace $safeprojectname$.DomainServices
{
    public interface ITYPELookupDataService
    {
        Task<IEnumerable<LookupItem>> GetTYPELookupAsync();
    }
}
