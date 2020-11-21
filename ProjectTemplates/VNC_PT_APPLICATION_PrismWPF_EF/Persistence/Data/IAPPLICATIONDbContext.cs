
using System.Data.Entity;

using APPLICATION.Domain;

namespace APPLICATION.Persistence.Data
{
    public interface IAPPLICATIONDbContext
    { 
        int SaveChanges();

        DbSet<TYPE> TYPESet { get; set; }
    }
}
