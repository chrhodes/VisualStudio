using System.Threading.Tasks;

using $xxxAPPLICATIONxxx$.Domain;

using VNC.Core.DomainServices;

namespace $xxxAPPLICATIONxxx$.DomainServices
{
    public interface I$xxxITEMxxx$DataService : IGenericRepository<$xxxITEMxxx$>
    {
        Task<bool> IsReferencedBy$xxxTYPExxx$Async(int id);
    }
}
