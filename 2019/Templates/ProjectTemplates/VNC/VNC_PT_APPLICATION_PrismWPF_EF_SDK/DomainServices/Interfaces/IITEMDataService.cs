using System.Threading.Tasks;

using $customAPPLICATION$.Domain;

using VNC.Core.DomainServices;

namespace $customAPPLICATION$.DomainServices
{
    public interface I$xxxITEMxxx$DataService : IGenericRepository<$xxxITEMxxx$>
    {
        Task<bool> IsReferencedBy$customTYPE$Async(int id);
    }
}
