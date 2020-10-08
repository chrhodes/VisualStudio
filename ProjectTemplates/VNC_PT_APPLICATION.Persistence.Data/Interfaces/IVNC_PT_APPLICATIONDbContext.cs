
using System.Data.Entity;

using VNC_PT_APPLICATION.Domain;

namespace VNC_PT_APPLICATION.Persistence.Data
{
    public interface IVNC_PT_APPLICATIONDbContext
    { 
        int SaveChanges();

        DbSet<TYPE> TYPESet { get; set; }
    }
}
