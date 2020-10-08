
using System.Data.Entity;

using VNC_PT_APPLICATION_PrismWPF.Domain;

namespace VNC_PT_APPLICATION_PrismWPF.Persistence.Data
{
    public interface IVNC_PT_APPLICATION_WPFDbContext
    {
        int SaveChanges();

        DbSet<TYPE> TYPESet { get; set; }
    }
}
