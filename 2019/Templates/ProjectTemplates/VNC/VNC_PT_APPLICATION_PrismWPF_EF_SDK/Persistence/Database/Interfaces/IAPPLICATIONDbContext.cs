using System.Data.Entity;

using $xxxAPPLICATIONxxx$.Domain;

namespace $xxxAPPLICATIONxxx$.Persistence.Data
{
    public interface I$xxxAPPLICATIONxxx$DbContext
    { 
        int SaveChanges();

        DbSet<$xxxTYPExxx$> $xxxTYPExxx$sSet { get; set; }
    }
}
