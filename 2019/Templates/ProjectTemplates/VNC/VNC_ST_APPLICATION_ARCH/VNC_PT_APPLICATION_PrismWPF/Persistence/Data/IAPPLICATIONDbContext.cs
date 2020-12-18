
using System.Data.Entity;

using $safeprojectname$.Domain;

namespace $safeprojectname$.Persistence.Data
{
    public interface IAPPLICATIONDbContext
    { 
        int SaveChanges();

        DbSet<TYPE> TYPESet { get; set; }
    }
}
